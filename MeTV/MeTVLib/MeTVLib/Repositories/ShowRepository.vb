Imports System.Configuration
Imports System.Diagnostics.Contracts

Public Class ShowRepository

    Private Context As MeTVdbEntities

    Public Sub New()
        Me.Context = New MeTVdbEntities(ConfigurationManager.ConnectionStrings("MeTVdbEntities").ConnectionString)
    End Sub

    Public Sub New(ConnectionString As String)
        Me.Context = New MeTVdbEntities(ConnectionString)
    End Sub


    Public Function FindAllShows() As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Select show Order By show.Name Ascending
        Return query.ToList()
    End Function


    #Region "FIND BY SHOW NAME"

    Public Function FindShow(pName As String) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.Name =  pName
                    Select show
        Return query.ToList()
    End Function

    Public Function FindShow(pID As Integer) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.ID =  pID
                    Select show
        Return query.ToList()
    End Function

    Public Function FindShowsContains(pName As String) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.Name.Contains(pName)
                    Select show
        Return query.ToList()
    End Function

    Public Function FindShowsStartsWith(pName As String) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.Name.StartsWith(pName)
                    Select show
        Return query.ToList()
    End Function

    Public Function FindShowsEndsWith(pName As String) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.Name.EndsWith(pName)
                    Select show
        Return query.ToList()
    End Function

    #End Region

    Public Function FindShowsByGenre(pGenre As Integer) As IList(Of Show)
        Dim query = From show In Me.Context.Shows
                    Where show.Genre =  pGenre
                    Select show
        Return query.ToList()
    End Function
End Class
