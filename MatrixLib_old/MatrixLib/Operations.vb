Public Class Operations

    'Returns a Copy of the Matrix
    Public Shared Function CopyMatrix(ByVal oldMatrix As Matrix) As Matrix
        Dim newMatrix As New Matrix(oldMatrix.rows, oldMatrix.cols)

        For i As Integer = 0 To oldMatrix.rows - 1
            For j As Integer = 0 To oldMatrix.cols - 1
                newMatrix.Matrix(i)(j) = oldMatrix.Matrix(i)(j)
            Next
        Next

        Return newMatrix
    End Function

    'Return a Tranposed Matrix of the Parameter Matrix
    Public Shared Function Transpose(ByVal oldMatrix As Matrix) As Matrix
        'Its Transposed, so switch the cols and rows around for the new Matrix
        Dim newMatrix As New Matrix(oldMatrix.rows, oldMatrix.cols)

        'Input the values from Matrix to newMatrix in Tranposed fashion
        For i As Integer = 0 To oldMatrix.cols - 1
            For j As Integer = 0 To oldMatrix.rows - 1
                newMatrix.Matrix(j)(i) = oldMatrix.Matrix(i)(j)
            Next
        Next

        Return newMatrix
    End Function

    'Returns a Matrix equal to the two Matricies inputted Multiplied in Matrix1*Matrix2 format
    Public Shared Function Multiply(ByVal Matrix1 As Matrix, ByVal Matrix2 As Matrix) As Matrix
        Dim resultMatrix As New Matrix(Matrix1.cols, Matrix2.rows)
        Try
            If Matrix1.rows <> Matrix2.cols Then
                Throw New Exception("Cannot Multiply Matricies: Inputted matrix structures unsuitable for multiplication. Matrix1=" & Matrix1.rows & "x" & Matrix1.cols & ", Matrix2=" & Matrix2.rows & "x" & Matrix2.cols & ". Valid structure is 'MxN * NxP = MxP'")
            End If

            For resultRow As Integer = 0 To resultMatrix.rows - 1
                For resultCol As Integer = 0 To resultMatrix.cols - 1
                    For i As Integer = 0 To Matrix1.rows - 1
                        resultMatrix.Matrix(resultCol)(resultRow) += Matrix1.Matrix(resultCol)(i) * Matrix2.Matrix(i)(resultRow)
                    Next
                Next
            Next

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try

        Return resultMatrix
    End Function

    Public Shared Function Multiply(ByVal Matrix1 As Matrix, ByVal Scaler As Double) As Matrix
        Dim resultMatrix As New Matrix(Matrix1.rows, Matrix1.cols)

        For i As Integer = 0 To Matrix1.rows - 1
            For j As Integer = 0 To Matrix1.cols - 1
                resultMatrix.Matrix(i)(j) = Matrix1.Matrix(i)(j) * Scaler
            Next
        Next

        Return resultMatrix
    End Function

    Public Shared Function SignFunc(ByVal m As Matrix) As Matrix
        Dim resultMatrix As New Matrix(m.cols, m.rows)

        For i As Integer = 0 To m.cols - 1
            For j As Integer = 0 To m.rows - 1
                If m.Matrix(i)(j) > 0 Then
                    resultMatrix.Matrix(i)(j) = 1
                ElseIf m.Matrix(i)(j) <= 0 Then
                    resultMatrix.Matrix(i)(j) = -1
                End If
            Next
        Next

        Return resultMatrix
    End Function

End Class
