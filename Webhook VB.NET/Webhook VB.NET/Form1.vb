Imports System.Net
Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Text.RegularExpressions
Public Class Form1

    Public Shared Function Post(ByVal uri As String, ByVal pairs As NameValueCollection) As Byte()
        Using webClient As WebClient = New WebClient()
            Return webClient.UploadValues(uri, pairs)
        End Using
    End Function
    Public Shared Sub webhookgonder(ByVal Url As String, ByVal avatar_url As String, ByVal msg As String, ByVal Username As String)
        Post(Url, New System.Collections.Specialized.NameValueCollection() From {
        {"avatar_url", avatar_url},
        {"username", Username},
        {"content", msg}
    })
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        webhookgonder("https://webhookurl", "https://avatarurl", txt_message.Text, "DevSertcocuk87")
    End Sub

    '//////////// Developer's by Sertcocuk87 www.sertcocuk87.org /////////////
End Class
