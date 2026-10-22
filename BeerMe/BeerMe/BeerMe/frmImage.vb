''' <summary>
''' Author: Paul Killian
''' Contact: PaulKillian@DecodedCortex.com
''' Website: www.DecodedCortex.com
''' 
''' Class: frmImage
''' Description: This class handles the Windows Form that contains the selected Beer Images.
''' </summary>
''' <remarks>
''' This application may be modified from its original work as long as credit to the original developer is given
''' and the resulting application or code derived is not used for profit or other commercial purposes without 
''' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
''' </remarks>

Public Class frmImage

    'Load form and set form element positions
    Private Sub frmImage_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
            pbImage.Left = 0
            pbImage.Top = 0
            pbImage.Width = Me.Width
            pbImage.Height = Me.Height
            ResizePictureBox
    End Sub

    'Load the beer image to the picture box
    Public Sub LoadImage(pImageFilePath As String)
            Try
                If pImageFilePath <> "" Then'
                    pbImage.ImageLocation = pImageFilePath
                    Dim TempBitmap = New Bitmap(pImageFilePath)
                    Dim ImageRatio = TempBitmap.Width/TempBitmap.Height
                    Me.Height = 350
                    Me.Width = Me.Height * ImageRatio
                    ResizePictureBox
                End If
            Catch ex As Exception
                MsgBox("Unable to load image.")
            End Try
    End Sub

    'Form resized
    Private Sub frmImage_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ResizePictureBox
    End Sub

    'Set picture box size upon form resize
    Private Sub ResizePictureBox()
        pbImage.Width = Me.Width-10
        pbImage.Height = Me.Height-30
    End Sub


End Class