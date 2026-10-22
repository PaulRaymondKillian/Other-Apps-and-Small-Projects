Imports System.Linq

Public Class Form1

Private Sub Form1_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim doc As XDocument

doc = XDocument.Load("BeerData.xml")

Dim qx = From xe In doc.Descendants.Elements("Employee") Order By xe.<Empno>.Value Ascending _ 
         Select New With { _
                    .ID = xe.Attribute("ID").Value, _
                    .Empno = xe.Element("Empno").Value, _
                    .LastName = xe.Element("LastName").Value, _
                    .Salary = xe.Element("Salary").Value, _
                    .Deptno = xe.Element("Deptno").Value _
                    }
                
'        Dim qEmp = (From xe In doc.Descendants.Elements("Employee") _
'Where xe.<Empno>.Value = "1010" _
'Select New With { _
'.ID = xe.@ID, _
'.Empno = xe.<Empno>.Value, _
'.Ename = xe.<Ename>.Value, _
'.Sal = xe.<Sal>.Value, _
'.Deptno = xe.<Deptno>.Value _
'}).FirstOrDefault


                                        
Me.dgItemList.DataSource = qx.ToList


        '' Create List View Item (Row)  
        '    Dim lvi As New ListViewItem  
  
        '    ' First Column can be the listview item's Text  
        '    lvi.Text = "Row" 
  
        '    ' Second Column is the first sub item   
        '    lvi.SubItems.Add("B")  
  
        '    ' Third Column is the second sub item  
        '    lvi.SubItems.Add("CCCC")  
  
        '    ' Add the ListViewItem to the ListView  
        '    ListView1.Items.Add(lvi)


    'PopulateDataGrid
End Sub

Public Sub PopulateDataGrid
        Dim reader As New System.IO.StreamReader("test.txt")
        Dim line = reader.ReadLine
        Dim list As New List(Of String)
        Dim s1(3)
        s1(1) = "a"
        s1(2) = "b"
        s1(3) = "c"

        'list.Add(s1)

        'dgItemList.DataSource = list
        'dgItemList.Refresh

        'dgItemList.Rows.Add(s1) 
        'dgItemList.Refresh
        Dim DataSet1 As New DataTable
        'DataSet1.DataTable.AddRow(1, "John Doe", true) 
        

End Sub
End Class
