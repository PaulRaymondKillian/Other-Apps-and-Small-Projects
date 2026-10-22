Imports System.Configuration
Imports MeTVLib

Module Module1

    Sub Main()
        
        'Dim MeTVLib As New MeTVLib.MeTVLib
        'Dim ShowRepo As New MeTVLib.ShowRepository
        Dim ConnectionString = ConfigurationManager.ConnectionStrings("MeTVdbEntities").ConnectionString
        Dim ShowRepo As New MeTVLib.ShowRepository(ConnectionString)
        Dim EpisodeRepo As New MeTVLib.EpisodeRepository(ConnectionString)

        Dim AllShows = ShowRepo.FindAllShows
        Dim AllEpisodes = EpisodeRepo.FindAllEpisodes
        Dim LikeShows = ShowRepo.FindShowsContains("Simps")

        For Each Show in AllShows
            Console.WriteLine(Show.Name)
        Next

        'Reverse the order of AllShows (default is ascending by name)
        Dim SortedDescShows = AllShows.OrderByDescending(Function(x) x.Name)

        For Each Show in SortedDescShows
            Console.WriteLine(Show.Name)
        Next

        For Each Episode in AllEpisodes
            Console.WriteLine(Episode.Name)
        Next

        For Each Show in LikeShows
            Console.WriteLine(Show.Name)
        Next

        Console.WriteLine("Press enter to exit...")
        Dim a As Char = Console.ReadLine

    End Sub

End Module
