Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO


Public Class MeTVLib

        Private Context As MeTVdbEntities

    Public Sub New()
        Me.Context = New MeTVdbEntities(ConfigurationManager.ConnectionStrings("dbDEVCisTEntities").ConnectionString)
        Dim a = New MeTVdbEntities(ConfigurationManager.ConnectionStrings("MeTVdbEntities").ConnectionString)
        Me.Context = New MeTVdbEntities(ConfigurationManager.connectionStrings("a").ConnectionString)
        Me.Context = New MeTVdbEntities(ConfigurationManager.AppSettings("MeTVdbEntities"))
        'Me.Context = New MeTVdbEntities("metadata=res://*/MeTVModel.csdl|res://*/MeTVModel.ssdl|res://*/MeTVModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=KILLIAN-PC\SQLExpress;Initial Catalog=MeTVdb;Integrated Security=True;MultipleActiveResultSets=True&quot; providerName=System.Data.EntityClient")    
    End Sub

End Class
