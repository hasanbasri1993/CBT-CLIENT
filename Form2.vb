Public Class frm_setting
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save(txt_shortcut.Text, txt_chrome.Text, txt_ip.Text)
        Me.Close()
    End Sub

    Private Sub frm_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_chrome.Text = chrome_loc
        txt_shortcut.Text = shortcut
        txt_ip.Text = ip_admin
    End Sub
End Class