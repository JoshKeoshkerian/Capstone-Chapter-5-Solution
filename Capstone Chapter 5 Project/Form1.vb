Public Class frmMain
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'declare open as new openFiledialog so that when the Open Submenu is click,
        'the OpenfileDialog will appear.
        Dim Open As New OpenFileDialog()
        'it is declared as System input and output Streamreader
        'it reads characters from a byte stream in a particular encoding
        Dim myStreamReader As System.IO.StreamReader
        'in an open dialog box, it will give an opening filter for the current filenames,
        'or the save file types.   
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        'it checks if the file exists or not
        Open.CheckFileExists = True
        'sets the openfile dialog name as "OpenFile"
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)

        Try
            'it opens the selected file by the user
            Open.OpenFile()
            'opens the existing file
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            'it reads the streams from current position to the end of position and display the result to RichTextBox as Text
            rtbData.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception
            'it will catch if any errors occurs
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
