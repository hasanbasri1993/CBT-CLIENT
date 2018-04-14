Imports System
Imports System.Xml
Imports System.IO

Module Module1
    Public chrome_loc, shortcut, ip_admin As String

    Public Function save(a As String, b As String, c As String)
        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        Dim XmlWrt As XmlWriter = XmlWriter.Create("ExamClientSetting.xml", settings)

        With XmlWrt

            ' Write the Xml declaration.
            .WriteStartDocument()

            ' Write a comment.
            .WriteComment("XML Database.")

            ' Write the root element.
            .WriteStartElement("Data")

            ' Start our first person.
            .WriteStartElement("AppSetting")

            ' The person nodes.

            .WriteStartElement("Shortcut")
            .WriteString(a)
            .WriteEndElement()

            .WriteStartElement("Chrome")
            .WriteString(b)
            .WriteEndElement()

            .WriteStartElement("IP_ADMIN")
            .WriteString(c)
            .WriteEndElement()

            ' The end of this person.
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()

        End With
        MsgBox("Sukses Simpan")

        If File.Exists("ExamSycnSetting.xml") Then
            Dim document As XmlReader = New XmlTextReader("ExamSycnSetting.xml")
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
        Return False

    End Function


End Module
