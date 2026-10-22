Module Module1

    Sub Main()

        Dim _TrafficGrid As New TrafficGrid
        Dim x As String = ""
        Dim z As String = ""

        Do Until z = "exit"
            Do Until x = "1"
                For i As Integer = 0 To 91
                    Console.WriteLine(_TrafficGrid.returnGridRow(i))
                Next
                _TrafficGrid.advanceTime()
                _TrafficGrid.randomlyGenerateCar()

                x = Console.ReadLine
            Loop
            z = Console.ReadLine()
            _TrafficGrid.advanceTime()
            '_TrafficGrid.randomlyGenerateCar()
        Loop



        'Console.Write("Press Enter to Exit...")
        'x = Console.ReadLine()

    End Sub

End Module
