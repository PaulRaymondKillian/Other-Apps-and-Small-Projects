Imports System.Configuration
Imports System.Diagnostics.Contracts

Public Class EpisodeRepository

    Private Context As MeTVdbEntities

    Public Sub New()
        Me.Context = New MeTVdbEntities(ConfigurationManager.ConnectionStrings("MeTVdbEntities").ConnectionString)
    End Sub

    Public Sub New(ConnectionString As String)
        Me.Context = New MeTVdbEntities(ConnectionString)
    End Sub

    Public Function FindAllEpisodes() As IList(Of Episode)
        Dim query = From episode In Me.Context.Episodes
                    Select episode

        Return query.ToList()
    End Function

End Class

