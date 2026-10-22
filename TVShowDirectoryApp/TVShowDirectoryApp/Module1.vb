Imports System.IO

Module Module1

    Sub Main()
        Dim Directory As Directory
        Dim FileList() As String
        Dim newName, Split() As String
        Console.Write("Please Enter a Directory: ")
        Directory.SetCurrentDirectory(Console.ReadLine)

        FileList = Directory.GetFiles(Directory.GetCurrentDirectory, "*")

        For Each File In FileList
            Console.Write(File.ToString)
            Split = File.ToString.Split("."c)
            My.Computer.FileSystem.RenameFile(File, newName)
        Next

        Dim z As String
        z = Console.ReadLine
    End Sub

End Module
