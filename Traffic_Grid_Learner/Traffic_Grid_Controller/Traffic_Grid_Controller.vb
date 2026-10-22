Imports System.IO
Imports System.Text

Public Class Traffic_Grid_Controller

    Private _gridName As String
    Private _gridWidth As Integer
    Private _gridHeight As Integer
    Private _blockSize As Integer = 20

    Private _startBlock As Traffic_Grid_Library.TrafficBlock
    Private _endBlock As Traffic_Grid_Library.TrafficBlock
    Private _currentBlock As Traffic_Grid_Library.TrafficBlock

    Public Property gridWidth() As Integer
        Get
            Return _gridWidth
        End Get
        Set(ByVal value As Integer)
            _gridWidth = value
        End Set
    End Property

    Public Property gridHeight() As Integer
        Get
            Return _gridHeight
        End Get
        Set(ByVal value As Integer)
            _gridHeight = value
        End Set
    End Property

    Public Property gridName() As String
        Get
            Return _gridName
        End Get
        Set(ByVal value As String)
            _gridName = value
        End Set
    End Property

    Public Property blockSize() As Integer
        Get
            Return _blockSize
        End Get
        Set(ByVal value As Integer)
            _blockSize = value
        End Set
    End Property




    Public Sub New(ByVal gridFile As String)
        buildGrid(gridFile)

    End Sub

    Private Sub buildGrid(ByVal gridFile As String)
        Dim sr As System.IO.StreamReader
        sr = New StreamReader(gridFile)

        'First line of file should be the grid name
        _gridName = sr.ReadLine()

        'Second line of file should be the grid Width
        _gridWidth = Convert.ToInt32(sr.ReadLine().ToString)

        'Third line of file should be the grid Height
        _gridHeight = Convert.ToInt32(sr.ReadLine().ToString)

        Dim input As String
        For i As Integer = 0 To (_gridHeight * _gridWidth - 1)
            input = sr.ReadLine

            Dim newBlock As Traffic_Grid_Library.TrafficBlock

            If input = "G" Then
                newBlock = New Traffic_Grid_Library.Grass
            ElseIf input = "ET" Then
                newBlock = New Traffic_Grid_Library.TerminalEast
            ElseIf input = "WT" Then
                newBlock = New Traffic_Grid_Library.TerminalWest
            ElseIf input = "NT" Then
                newBlock = New Traffic_Grid_Library.TerminalNorth
            ElseIf input = "ST" Then
                newBlock = New Traffic_Grid_Library.TerminalSouth
            ElseIf input = "EWS" Then
                newBlock = New Traffic_Grid_Library.EWStreet
            ElseIf input = "NSS" Then
                newBlock = New Traffic_Grid_Library.NSStreet
            ElseIf input = "I" Then
                newBlock = New Traffic_Grid_Library.Intersection
            Else
                MsgBox("Error - Class: Traffic_Grid_Controller, Method: buildGrid, Description: Invalid/Unknown input variable from read file")
            End If

            If i = 0 Then
                _startBlock = newBlock
                _currentBlock = newBlock
            ElseIf i = (_gridWidth * _gridHeight - 1) Then
                _endBlock = newBlock
                _currentBlock.setlinkEast(newBlock)
                newBlock.setlinkWest(_currentBlock)
            Else
                _currentBlock.setlinkEast(newBlock)
                newBlock.setlinkWest(_currentBlock)
                _currentBlock = newBlock
            End If

        Next



        Dim _tempBlock As Traffic_Grid_Library.TrafficBlock

        _currentBlock = _startBlock
        _tempBlock = _startBlock
        For j As Integer = 1 To (_gridWidth * _gridHeight)
            For i As Integer = 1 To _gridWidth
                'If _tempBlock = _endBlock Then
                If _tempBlock.Equals(_endBlock) Then
                    _tempBlock = _startBlock._linkEast
                Else
                    _tempBlock = _tempBlock._linkEast
                End If
            Next
            _currentBlock.setLinkSouth(_tempBlock)
            _tempBlock.setLinkNorth(_currentBlock)
            _currentBlock = _tempBlock
        Next


        sr.Close()
    End Sub

    Public Function returnGridAsString() As String

        Dim sb As StringBuilder = New StringBuilder("")
        Dim _startOfCurrentRow As Traffic_Grid_Library.TrafficBlock

        _currentBlock = _startBlock
        _startOfCurrentRow = _startBlock

        For i As Integer = 1 To _gridHeight
            For j As Integer = 1 To _blockSize
                For k As Integer = 1 To _gridWidth
                    For l As Integer = 1 To _blockSize
                        sb.Append(_currentBlock.getCarIdAtLocation((l - 1), (j - 1)))
                    Next
                    _currentBlock = _currentBlock._linkEast
                Next
                If j < (_blockSize) Then
                    _currentBlock = _startOfCurrentRow
                Else
                    _startOfCurrentRow = _currentBlock
                End If
            Next
        Next

        Return sb.ToString

    End Function

    Public Sub advanceTime()

        _currentBlock = _startBlock
        Do
            _currentBlock.advanceWestBoundTraffic()
            _currentBlock = _currentBlock._linkEast
        Loop Until (_currentBlock.Equals(_endBlock))

        _currentBlock = _endBlock
        Do
            _currentBlock.advanceEastBoundTraffic()
            _currentBlock = _currentBlock._linkWest
        Loop Until (_currentBlock.Equals(_startBlock))

        _currentBlock = _startBlock
        Do
            _currentBlock.advanceNorthBoundTraffic()
            _currentBlock = _currentBlock._linkSouth
        Loop Until (_currentBlock.Equals(_endBlock))

        _currentBlock = _endBlock
        Do
            _currentBlock.advanceSouthBoundTraffic()
            _currentBlock = _currentBlock._linkNorth
        Loop Until (_currentBlock.Equals(_startBlock))

        If True = True Then
            'True = False
        End If
    End Sub

    Public Function debugReturnBlockTypes() As String
        Dim s As StringBuilder = New StringBuilder

        _currentBlock = _startBlock
        Do
            s.AppendLine(_currentBlock._blockType)
            _currentBlock = _currentBlock._linkEast

        Loop Until (_currentBlock.Equals(_endBlock))

        Return s.ToString

    End Function

End Class
