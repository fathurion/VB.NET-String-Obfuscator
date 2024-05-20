Imports System.Text

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        richTextBox1.Clear()
        RichTextBox2.Clear()
        RichTextBox3.Clear()
        TextBox2.Clear()
        Dim inputString As String = textBox1.Text
        Dim line As Integer = 1
        For Each character As Char In inputString
            Dim k As String = RandomString()
            Dim p As String = RandomString()
            richTextBox1.AppendText("Dim " & k & " As String = " & Chr(34) & AES_Encrypt(Convert.ToBase64String(Encoding.UTF8.GetBytes(character)), p) & Chr(34) & vbCrLf)
            '  RichTextBox3.AppendText("Dim " & k & " As String = " & Chr(34) & character & Chr(34) & vbCrLf)
            TextBox2.Text = TextBox2.Text & "System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(" & "AES_Decrypt(" & k & "," & Chr(34) & p & Chr(34) & ")))" & " & "
            line += 1
        Next
        Dim SecCode As String = RandomString()
        Dim wee As String = "Dim " & SecCode & " As String " & " = " & TextBox2.Text
        RichTextBox2.Text = wee.Substring(0, Len(wee) - 2)

        Dim lines As String() = richTextBox1.Lines
        Dim shuffledLines As New List(Of String)(lines)
        Dim random As New Random()
        shuffledLines = shuffledLines.OrderBy(Function(x) random.Next()).ToList()
        For Each linex As String In shuffledLines
            RichTextBox3.AppendText(linex & Environment.NewLine)
        Next

        Dim xlines As String() = RichTextBox3.Lines
        Dim nonBlankLines As IEnumerable(Of String) = xlines.Where(Function(liner) Not String.IsNullOrEmpty(liner.Trim()))
        RichTextBox3.Lines = nonBlankLines.ToArray()

        Dim kmkmk As String = RichTextBox3.Text.Replace(vbCrLf, "") & Chr(13) & Chr(13) & RichTextBox2.Text & Chr(13) & Chr(13) & My.Resources.aess
        Dim lol As String = RandomString()
        Dim lol2 As String = RandomString()
        Dim lol3 As String = RandomString()
        Dim lol4 As String = RandomString()
        Dim lol5 As String = RandomString()
        Dim lol6 As String = RandomString()
        Dim lol7 As String = RandomString()
        Dim lol8 As String = RandomString()
        Dim lol9 As String = RandomString()
        Dim lol10 As String = RandomString()
        RichTextBox4.Text = "'Call " & SecCode & " For Obfuscated Text" & Chr(13) & Chr(13) & kmkmk.Replace("AES_Decrypt", lol).Replace("AES", lol2).Replace("input", lol3).Replace("pass", lol4).Replace("hash", lol5).Replace("temp", lol6).Replace("DESDecrypter", lol7).Replace("Buffer", lol8).Replace("decrypted", lol9).Replace("INDON", lol10)
    End Sub

    Function RandomString()
        Dim s As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(8, 8)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim PBhSKFNP As String = "L6NiNVlSGYdUM9bgGoV0pw=="
        Dim TJpZHFDB As String = "ftERDalEYDs2UHZeoLgyMA=="
        Dim JwmDqVCI As String = "Z3mnHLXzIuhyYMZUo55U4g=="
        Dim jQTCpjgv As String = "jek7p2dk9ct28ypdnfZ0Bg=="
        Dim DqstwYLI As String = "cT6xp+YLa8DPAp9rKpPzmw=="
        Dim MhhdwVOf As String = "R1JFYtxVAWWN9owdyEcnWA=="
        Dim bPtVQGSP As String = "dGow+EDm/b64hNBeWegHUQ=="
        Dim gATwFrAg As String = "nzB5cNEcQTajAm0WKWNqeA=="
        Dim PQqAlHwz As String = "if9Tc/VobV3UnHxdUEzwUA=="
        Dim YEjbvKAG As String = Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(PBhSKFNP, "ONUloiOK"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(TJpZHFDB, "sIPDyCgY"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(JwmDqVCI, "UkhwPeri"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(jQTCpjgv, "xkorfpCe"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(DqstwYLI, "rWTKmqiX"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(MhhdwVOf, "FCeSTKQN"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(bPtVQGSP, "oMXYjigQ"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(gATwFrAg, "myciTyyg"))) & Encoding.UTF8.GetString(Convert.FromBase64String(AES_Decrypt(PQqAlHwz, "AGtWLdNJ")))
        MsgBox(YEjbvKAG)
    End Sub



    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return input 'If encryption fails, return the unaltered input.
        End Try
    End Function
    'Decrypt a string with AES
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return input 'If decryption fails, return the unaltered input.
        End Try
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clipboard.SetText(RichTextBox4.Text)
    End Sub
End Class
