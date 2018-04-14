Imports System.Xml
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cm = """" + chrome_loc + """ --incognito --user-data-dir=$(mktemp -d) --kiosk --new-window --allow-running-insecure-content " + ip_admin + "\unbk"
        Shell("CMD.exe /c " + cm)
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Dim myValue As String = InputBox("Enter Value", "Enter Value", "Please Enter Value")
        If myValue = "12345" Then
            frm_setting.Show()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("ExamClientSetting.xml") Then
            Dim document As XmlReader = New XmlTextReader("ExamClientSetting.xml")
            While (document.Read())
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                    If (document.Name = "Shortcut") Then
                        shortcut = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Chrome") Then
                        chrome_loc = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "IP_ADMIN") Then
                        ip_admin = document.ReadInnerXml.ToString()
                    End If
                End If

            End While
            document.Close()
        End If
    End Sub
End Class
