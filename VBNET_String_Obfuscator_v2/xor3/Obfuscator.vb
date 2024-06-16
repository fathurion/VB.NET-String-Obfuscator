Module Obfuscator

    Public Function ShuffleRichTextBoxContent(ByVal richTextBox As RichTextBox) As String
        Dim lines() As String = richTextBox.Lines
        Dim random As New Random()
        lines = lines.OrderBy(Function(s) random.NextDouble()).ToArray()
        Return String.Join(vbCrLf, lines)
    End Function

    Public Function XorEncrypt(ByVal data As String, ByVal key As String) As String
        Dim dataBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(data)
        Dim keyBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(key)
        Dim result(dataBytes.Length - 1) As Byte
        For i As Integer = 0 To dataBytes.Length - 1
            result(i) = dataBytes(i) Xor keyBytes(i Mod keyBytes.Length)
        Next
        Return Convert.ToBase64String(result)
    End Function

    Public Function Base64Encode(ByVal data As String) As String
        Dim dataBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(data)
        Return Convert.ToBase64String(dataBytes)
    End Function

    Public Function AESEncrypt(ByVal plaintext As String, ByVal key As String) As String
        Dim AES As New Security.Cryptography.RijndaelManaged
        Dim SHA256 As New Security.Cryptography.SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.GenerateIV()
            AES.Key = SHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(key))

            AES.Mode = Security.Cryptography.CipherMode.CBC
            Dim DESEncrypter As Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.Encoding.ASCII.GetBytes(plaintext)
            ciphertext = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return Convert.ToBase64String(AES.IV) & Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function StringToBinary(text As String) As String
        Dim binaryString As String = ""
        For Each character As Char In text
            Dim asciiValue As Integer = Asc(character)
            Dim binaryChar As String = Convert.ToString(asciiValue, 2).PadLeft(8, "0")
            binaryString &= binaryChar
        Next
        Return binaryString
    End Function

End Module
