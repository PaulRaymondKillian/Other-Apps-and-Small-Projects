Public Class ResourceDS

#Region "<< Constructors >>"
    Private Shared _list As List(Of Resource)
    Shared Sub New()
        _list = New List(Of Resource)()
        _list.Add(New Resource With { _
          .Id = "BA4CBF60-B8D7-4f3e-8345-4D09097846B8", _
          .Title = "A History of Hogwarts, 1000th Edition", _
          .AssetNumber = "AN1", _
          .Publisher = "Wizard House Publishing", _
          .DatePublished = #2/1/2010#.ToString("d"), _
          .Version = DateTime.Now.ToString("F") _
          })
        _list.Add(New Resource With { _
          .Id = Guid.NewGuid().ToString(), _
          .Title = "Dementors Have Feelings Too", _
          .AssetNumber = "AN2", _
          .Publisher = "House Elf Publishers, Inc.", _
          .DatePublished = #5/2/1900#.ToString("d"), _
          .Version = DateTime.Now.ToString("F") _
          })
        _list.Add(New Resource With { _
          .Id = Guid.NewGuid().ToString(), _
          .Title = "Being a Wizard in Modern Day England", _
          .AssetNumber = "AN3", _
          .Publisher = "Horcrux Publishing", _
          .DatePublished = #6/7/1970#.ToString("d"), _
          .Version = DateTime.Now.ToString("F") _
          })
        _list.Add(New Resource With { _
          .Id = Guid.NewGuid().ToString(), _
          .Title = "When Your Potions Teacher is Really a Hero", _
          .AssetNumber = "AN4", _
          .Publisher = "Horcrux Publishing", _
          .DatePublished = #1/23/2009#.ToString("d"), _
          .Version = DateTime.Now.ToString("F") _
          })
        _list.Add(New Resource With { _
          .Id = Guid.NewGuid().ToString(), _
          .Title = "Ron Weasley: A Story of Determination", _
          .AssetNumber = "AN5", _
          .Publisher = "House Elf Publishers, Inc.", _
          .DatePublished = #3/12/2010#.ToString("d"), _
          .Version = DateTime.Now.ToString("F") _
          })
    End Sub
#End Region

#Region "<< Select Methods >>"
    Private Shared _maxItemCount As Int64 = 0L

    Public Shared Function SelectOneAsList(ByVal id As String) As IEnumerable(Of Resource)
        Dim query = From r In DataSource() Where id = r.Id Select r
        Return MapModelToViewModel(query).ToList()
    End Function

    Public Shared Function SelectOne(ByVal id As String) As Resource
        Return SelectOneAsList(id).SingleOrDefault()
    End Function

    Public Function SelectOne( _
        ByVal editMode As String, _
        ByVal id As String) As IEnumerable(Of Resource)

        Dim newResource As IEnumerable(Of Resource) = Nothing

        If editMode = Constants.TypeOfEditOperation.EditItem Then
            Dim query = From r In DataSource() Where id = r.Id Select r
            newResource = MapModelToViewModel(query).ToList()

        ElseIf editMode = Constants.TypeOfEditOperation.CloneItem Then
            Dim query = From r In DataSource() Where id = r.Id Select r
            newResource = MapModelToViewModel(query).ToList()

            newResource(0).Id = Guid.NewGuid().ToString()
        ElseIf editMode = Constants.TypeOfEditOperation.NewItem Then
            Dim list = New List(Of Resource)()
            list.Add(New Resource())
            newResource = list
            newResource(0).Id = Guid.NewGuid().ToString()
        End If

        newResource(0).EditMode = editMode

        Return newResource
    End Function

    Public Shared Function SelectAll() As IList(Of Resource)
        Dim query = From r In DataSource() Select r
        Return MapModelToViewModel(query).ToList()
    End Function

    Public Shared Function SelectAllWithPaging( _
        ByVal filterParamters As String, _
        ByVal itemsToSkip As Int32, _
        ByVal itemsPerPage As Int32) As IList(Of Resource)

        Dim titleFilter = UIUtility.UnpackParameters(filterParamters)(0)
        Dim filter = titleFilter.ToUpper() & "*"

        Dim query1 = From r In DataSource() _
                        Where r.Title.ToUpper() Like filter _
                        Order By r.Title _
                        Select r

        Dim query2 = From r In query1 _
                     Skip itemsToSkip Take itemsPerPage _
                     Select r

        _maxItemCount = query1.Count()
        Return MapModelToViewModel(query2).ToList()
    End Function

    Public Shared Function SelectCount() As Int32
        Dim int32Max As Int64 = Int32.MaxValue
        If _maxItemCount > int32Max Then
            Throw New ArgumentOutOfRangeException( _
                    String.Format("The number of rows provided '{0}' cannot be handled by the ODS.", _maxItemCount))
        End If

        Return CType(_maxItemCount, Int32)
    End Function

#End Region

#Region "<< Update, Insert, Delete Methods >>"
    Public Shared Sub MultiPurposeUpdate(ByVal vmResource As Resource)
        If vmResource.EditMode = Constants.TypeOfEditOperation.EditItem Then
            Update(vmResource)
        ElseIf vmResource.EditMode = Constants.TypeOfEditOperation.CloneItem Then
            Insert(vmResource)
        ElseIf vmResource.EditMode = Constants.TypeOfEditOperation.NewItem Then
            Insert(vmResource)
        End If
    End Sub

    Public Shared Sub Update( _
        ByVal vmResource As Resource)

        Dim model = (From r In DataSource() Where r.Id = vmResource.Id Select r).Single()
        MapViewModelToModel(vmResource, model)
        model.Version = DateTime.Now.ToString("F")

        MapModelToViewModel(model, vmResource)
    End Sub

    Public Shared Sub Insert(ByVal vmResource As Resource)
        Dim model As New Resource()

        MapViewModelToModel(vmResource, model)
        model.Version = DateTime.Now.ToString("F")
        model.Id = vmResource.Id

        DataSource.Add(model)

        MapModelToViewModel(model, vmResource)
    End Sub

    Public Shared Sub Delete(ByVal vmResource As Resource)
        Dim item = (From r In DataSource() Where r.Id = vmResource.Id Select r).Single()
        DataSource().Remove(item)
    End Sub

    Public Shared Sub DeleteById(ByVal id As String)
        Dim item = (From r In DataSource() Where r.Id = id Select r).Single()
        DataSource().Remove(item)
    End Sub
#End Region

#Region "<< Helpers >>"
    'In a real app we would likely get our data from a database...
    Private Shared Function DataSource() As List(Of Resource)
        Return _list
    End Function

    Private Shared Function MapModelToViewModel( _
        ByVal model As IEnumerable(Of Resource)) As IEnumerable(Of Resource)

        Dim newList = From r In model Select New Resource() With { _
            .Id = r.Id, _
            .Title = r.Title, _
            .AssetNumber = r.AssetNumber, _
            .Publisher = r.Publisher, _
            .DatePublished = r.DatePublished, _
            .Version = r.Version _
        }
        Return newList
    End Function

    Private Shared Sub MapModelToViewModel( _
        ByVal model As Resource, _
        ByVal viewModel As Resource)

        viewModel.Title = model.Title
        viewModel.AssetNumber = model.AssetNumber
        viewModel.Publisher = model.Publisher
        viewModel.DatePublished = model.DatePublished
        viewModel.Version = model.Version
    End Sub

    Private Shared Sub MapViewModelToModel( _
        ByVal viewModel As Resource, _
        ByVal model As Resource)

        model.Title = viewModel.Title
        model.AssetNumber = viewModel.AssetNumber
        model.Publisher = viewModel.Publisher
        model.Version = viewModel.Version
        model.DatePublished = viewModel.DatePublished
    End Sub
#End Region
End Class
