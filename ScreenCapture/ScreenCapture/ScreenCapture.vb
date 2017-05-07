Imports System
Imports System.Drawing


Public Class ScreenCapture

    Private bMap As Bitmap


    Private Sub ScreenCapture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ScreenCapture_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

    End Sub


    Private Sub CaptureBtn_Click(sender As System.Object, e As System.EventArgs) Handles CaptureBtn.Click
        Try
            bMap = New Bitmap(Me.CaptureBox.Width, Me.CaptureBox.Height)

            Dim gp As Graphics = Graphics.FromImage(bMap)
            gp.CopyFromScreen(PointToScreen(New Point(Me.CaptureBox.Location.X, Me.CaptureBox.Location.Y)), New Point(0, 0), bMap.Size)

            gp.Dispose()


        Catch ex As Exception
            MsgBox("CaptureBtn_Click : " + ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles SaveBtn.Click
        Try
            Me.FileSaveDlg.ShowDialog()
            If (Me.FileSaveDlg.FileName = "") Then
                Exit Sub
            Else
                Dim SaveFileName As String = Me.FileSaveDlg.FileName

                bMap.Save(SaveFileName)

            End If

        Catch ex As Exception
            MsgBox("SaveBtn_Click : " + ex.Message)
        End Try
    End Sub


    Private Sub ScreenCapture_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Private Sub ScreenCapture_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub


End Class
