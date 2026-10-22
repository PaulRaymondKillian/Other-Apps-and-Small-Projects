Public Class Resource

#Region "<< Id - Surrogate Key >>"
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
#End Region

#Region "<< Title >>"
    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
#End Region

#Region "<< DatePublished >>"
    Private _datePublished As String
    Public Property DatePublished() As String
        Get
            Return _datePublished
        End Get
        Set(ByVal value As String)
            _datePublished = value
        End Set
    End Property
#End Region

#Region "<< ResourceType >>"
    Private _resourceType As Int32
    Public Property ResourceType() As Int32
        Get
            Return _resourceType
        End Get
        Set(ByVal value As Int32)
            _resourceType = value
        End Set
    End Property
#End Region

#Region "<< AssetNumber >>"
    Private _assetNumber As String
    Public Property AssetNumber() As String
        Get
            Return _assetNumber
        End Get
        Set(ByVal value As String)
            _assetNumber = value
        End Set
    End Property
#End Region

#Region "<< Publisher >>"
    Private _publisher As String
    Public Property Publisher() As String
        Get
            Return _publisher
        End Get
        Set(ByVal value As String)
            _publisher = value
        End Set
    End Property

#End Region

#Region "<< Version >>"
    Private _version As String
    Public Property Version() As String
        Get
            Return _version
        End Get
        Set(ByVal value As String)
            _version = value
        End Set
    End Property
#End Region

#Region "<< EditMode >>"
    Private _editMode As String
    Public Property EditMode() As String
        Get
            Return _editMode
        End Get
        Set(ByVal value As String)
            _editMode = value
        End Set
    End Property
#End Region

End Class

