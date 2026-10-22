''' <summary>
''' Author: Paul Killian
''' Contact: PaulKillian@DecodedCortex.com
''' Website: www.DecodedCortex.com
''' 
''' Class: BeerMeLib
''' Description: This class handles the linq data object controls and interfaces that manage the XML database of beer information
''' </summary>
''' <remarks>
''' This application may be modified from its original work as long as credit to the original developer is given
''' and the resulting application or code derived is not used for profit or other commercial purposes without 
''' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
''' </remarks>

Public Structure Beer
    Dim Name, Company, Style, Image, Comments As String
    Dim Look, Smell, Taste, Feel As Integer
    Dim Overall As Double
End Structure

Public Class BeerMeLib
    Private Const _CLASS  As String = "BeerMeLib"

    Public XMLFilePath As String        'File path of XML Data File
    Private XMLDoc As XDocument         'Data Object holding all in-memory LINQ Database
    Private Const LOGFILENAME As String = "BeerMeLager.Log"
    Private LoggingEnabled As Boolean = False

    'Default Constructor
    Public Sub New()
        'This constructor is used only if a new BeerMe data file needs to be created without first creating the BeerMeLib object with an existing data object
    End Sub
    
    'Constructor
    Public Sub New(pXMLFilePath As String, Optional pLoggingEnabled As Boolean = False)
        Dim _METHOD As String = "New(pXMLFilePath, Optional pLoggingEnabled)"
        Try
            LoggingEnabled = pLoggingEnabled
            XMLFilePath = pXMLFilePath
            XMLDoc = XDocument.Load(XMLFilePath)
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub

    'Add new beer to linq data object
    Public Sub AddBeer( pName As String, pCompany As String, pStyle As String, pLook As Integer, pSmell As Integer, pTaste As Integer, pFeel As Integer, pImage As String, pComments As String)
        Dim _METHOD As String = "AddBeer(...)"
        Try
            Dim newBeer As XElement = _
                <Beer Name="">
		            <Style></Style>
                    <Company></Company>
		            <Look></Look>
		            <Smell></Smell>
		            <Taste></Taste>
		            <Feel></Feel>
                    <Overall></Overall>
		            <Image></Image>
                    <Comments></Comments>
	           </Beer>

            'Set beer xelement values
            newBeer.Attribute("Name").Value = pName
            newBeer.Element("Company").Value = pCompany
            newBeer.Element("Style").Value = pStyle
            newBeer.Element("Look").Value = pLook
            newBeer.Element("Smell").Value = pSmell
            newBeer.Element("Taste").Value = pTaste
            newBeer.Element("Feel").Value = pFeel
            newBeer.Element("Overall").Value = OverallBeerValue(pLook, pSmell, pTaste, pFeel)
            newBeer.Element("Image").Value = pImage
            newBeer.Element("Comments").Value = pComments

            'Add Beer to linq data object
            XMLDoc.Element("BeerInfo").Add(newBeer)
            SaveXMLData()
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub

    'Calculate average of 3 inputted values (Strings as Numerics)
    Public Function OverallBeerValue(pLook As String, pSmell As String, pTaste As String, pFeel As String)
        Dim _METHOD As String = "OverallBeerValue(pLook, pSmell, pTaste, pFeel)"
        Dim Overall As Double = 0
        Try 
            If IsNumeric(pLook)
                Overall += Convert.ToInt32(pLook)
            End If
            If IsNumeric(pSmell)
                Overall += Convert.ToInt32(pSmell)
            End If
            If IsNumeric(pTaste)
                Overall += Convert.ToInt32(pTaste)
            End If
            If IsNumeric(pFeel)
                Overall += Convert.ToInt32(pFeel)
            End If
            Overall /= 4
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
        Return Overall
    End Function

    'Remove beer object from linq data object
    Public Sub RemoveBeer(pName As String)
        Dim _METHOD As String = "RemoveBeer(pName)"
        Try
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Where item.Attribute("Name").Value = pName _ 
               Select item
        
            query.Remove
            XMLDoc.Save(XMLFilePath)
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub

    'Retrieve all beers in default order from linq data object
    Public Function GetAllBeers() As IEnumerable
        Dim _METHOD As String = "GetAllBeers(void)"
        Try
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Order By item.Element("Style").Value Descending _ 
             Select New With { _
                        .Name = item.Attribute("Name").Value, _
                        .Company = item.Element("Company").Value, _ 
                        .Style = item.Element("Style").Value, _
                        .Look = item.Element("Look").Value, _
                        .Smell = item.Element("Smell").Value, _
                        .Taste = item.Element("Taste").Value, _
                        .Feel = item.Element("Feel").Value, _
                        .Overall = item.Element("Overall").Value _ 
                        }
        
            Return query.ToList
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Function

    'Query the linq data object using select and ordering criteria
    Public Function QueryBeers(pNames As String(), pCompanies As String(), pStyles As String(),  _
                                                pLookLower As Integer, pLookUpper As Integer, _ 
                                                pSmellLower As Integer, pSmellUpper As Integer, _ 
                                                pTasteLower As Integer, pTasteUpper As Integer, _ 
                                                pFeelLower As Integer, pFeelUpper As Integer, _ 
                                                pOverallLower As Integer, pOverallUpper As Integer, _ 
                                                pOrderBy As String, pAscending As Boolean) As IEnumerable
        Dim _METHOD As String = "QueryBeers(...)"
        Try
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Where pNames.Contains(item.Attribute("Name").Value) And _
                            pCompanies.Contains(item.Element("Company").Value) And pStyles.Contains(item.Element("Style").Value) And _
                            item.Element("Look").Value >= pLookLower And item.Element("Look").Value <= pLookUpper And _ 
                            item.Element("Smell").Value >= pSmellLower And item.Element("Smell").Value <= pSmellUpper And _
                            item.Element("Taste").Value >= pTasteLower And item.Element("Taste").Value <= pTasteUpper And _
                            item.Element("Feel").Value >= pFeelLower And item.Element("Feel").Value <= pFeelUpper And _ 
                            item.Element("Overall").Value >= pOverallLower And item.Element("Overall").Value <= pOverallUpper _ 
                            Order By item.Descendants(pOrderBy).Value Ascending, item.Attribute("Name").Value
            Select New With { _
                        .Name = item.Attribute("Name").Value, _
                        .Company = item.Element("Company").Value, _
                        .Style = item.Element("Style").Value, _
                        .Look = item.Element("Look").Value, _
                        .Smell = item.Element("Smell").Value, _
                        .Taste = item.Element("Taste").Value, _
                        .Feel = item.Element("Feel").Value, _ 
                        .Overall = item.Element("Overall").Value _
                        }
                
            If(Not pAscending)
                query = query.Reverse
            End If
        
            Return query.ToList
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Function

    'Get an individual beer from linq data object
    Public Function GetBeer(pName As String) As Beer
        Dim _METHOD As String = "GetBeer(pName)"
        Dim Beer As New Beer
        Try
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Where item.Attribute("Name").Value = pName _ 
             Select New With { _
                        .Name = item.Attribute("Name").Value, _
                        .Company = item.Element("Company").Value, _
                        .Style = item.Element("Style").Value, _
                        .Look = item.Element("Look").Value, _
                        .Smell = item.Element("Smell").Value, _
                        .Taste = item.Element("Taste").Value, _
                        .Feel = item.Element("Feel").Value, _ 
                        .Overall = item.Element("Overall").Value, _ 
                        .Image = item.Element("Image").Value, _ 
                        .Comments = item.Element("Comments").Value _ 
                        }
        
            Dim result = query.ToList.First
            Beer.Name = result.Name
            Beer.Style = result.Style
            Beer.Company = result.Company
            Beer.Look = result.Look
            Beer.Smell = result.Smell
            Beer.Taste = result.Taste
            Beer.Feel = result.Feel
            Beer.Overall = result.Overall
            Beer.Image = result.Image
            Beer.Comments = result.Comments
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
        Return Beer

    End Function

    'Check if inputted name does not already exist in linq data object
    Public Function UniqueName(pName As String) As Boolean
        Dim _METHOD As String = "UniqueName(pName)"
        Try
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Where pName.Contains(item.Attribute("Name").Value)
                            Select item
        
            If query.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Function

    'Update the values of a beer object in the linq data object
    Public Sub UpdateBeer(pUpdateBeer As Beer)
        Dim _METHOD As String = "UpdateBeer(pUpdateBeer)"
        Try
            'Retrieve beer item from linq data object
            Dim query = From item In XMLDoc.Descendants.Elements("Beer") Where item.Attribute("Name").Value = pUpdateBeer.Name _ 
             Select item
        
            'If beer object was returned, update the values
            If query IsNot Nothing
                query.FirstOrDefault.Element("Company").Value = pUpdateBeer.Company
                query.FirstOrDefault.Element("Style").Value = pUpdateBeer.Style
                query.FirstOrDefault.Element("Look").Value = pUpdateBeer.Look
                query.FirstOrDefault.Element("Smell").Value = pUpdateBeer.Smell
                query.FirstOrDefault.Element("Taste").Value = pUpdateBeer.Taste
                query.FirstOrDefault.Element("Feel").Value = pUpdateBeer.Feel
                query.FirstOrDefault.Element("Overall").Value = pUpdateBeer.Overall
                query.FirstOrDefault.Element("Image").Value = pUpdateBeer.Image
                query.FirstOrDefault.Element("Comments").Value = pUpdateBeer.Comments
                
                'Save the linq data object with the updated beer values
                SaveXMLData
            Else
                Throw New Exception("Cannot update beer - Beer not found")
            End If
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub

    'Save the linq data object to file
    Private Sub SaveXMLData()
        Dim _METHOD As String = "SaveXMLData(void)"
        Try
            XMLDoc.Save(XMLFilePath)
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub
    
    'Create a new, blank linq xml data file
    Public Sub CreateNewDataFile(pNewXMLFilePath As String)
        Dim _METHOD As String = "CreateNewDataFile(pNewXMLFilePath)"
        Try
            XMLFilePath = pnewXMLFilePath
            XMLDoc = New XDocument
            Dim newBeerInfo As XElement = _
                <BeerInfo>
                </BeerInfo>

            XMLDoc.Add(newBeerInfo)
            SaveXMLData()
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error: " & ex.Message
            Lager(ErrorMsg)
            Throw New Exception(ErrorMsg)
        End Try
    End Sub

    'Logs a message to the BeerMe log file
    Public Sub Lager(pMessage As String)
        Dim _METHOD As String = "Lager(pMessage)"
        If LoggingEnabled
            Try
                Dim sw As System.IO.StreamWriter
                If System.IO.File.Exists(LOGFILENAME) = True Then
                    sw = System.IO.File.AppendText(LOGFILENAME)
                Else
                    sw = System.IO.File.CreateText(LOGFILENAME)
                End If

                If sw IsNot Nothing Then
                    sw.WriteLine(DateTime.Now & ": " & pMessage)
                    sw.Close
                Else
                    Throw New Exception("Unable to open/write to log file.")
                End If 
            Catch ex As Exception
                MsgBox("Error Logging to Log File. Please resolve error or turn off logging in the configuration file. - Error: " & ex.Message)
            End Try
        End If  
    End Sub
End Class
