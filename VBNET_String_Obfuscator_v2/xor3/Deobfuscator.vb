Module Deobfuscator



    Public Function XorDecrypt(ByVal encryptedData As String, ByVal key As String) As String
        Dim dataBytes As Byte() = Convert.FromBase64String(encryptedData)
        Dim keyBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(key)
        Dim result(dataBytes.Length - 1) As Byte
        For i As Integer = 0 To dataBytes.Length - 1
            result(i) = dataBytes(i) Xor keyBytes(i Mod keyBytes.Length)
        Next
        Return System.Text.Encoding.UTF8.GetString(result)
    End Function

    Public Function Base64Decode(ByVal base64String As String) As String
        Dim dataBytes As Byte() = Convert.FromBase64String(base64String)
        Return System.Text.Encoding.UTF8.GetString(dataBytes)
    End Function

    Public Function AESDecrypt(ByVal ciphertext As String, ByVal key As String) As String
        Dim AES As New Security.Cryptography.RijndaelManaged
        Dim SHA256 As New Security.Cryptography.SHA256Cng
        Dim plaintext As String = ""
        Dim iv As String = ""
        Try
            Dim ivct = ciphertext.Split({"=="}, StringSplitOptions.None)
            iv = ivct(0) & "=="
            ciphertext = If(ivct.Length = 3, ivct(1) & "==", ivct(1))
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.IV = Convert.FromBase64String(iv)
            AES.Mode = Security.Cryptography.CipherMode.CBC
            Dim DESDecrypter As Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(ciphertext)
            plaintext = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return plaintext
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function BinaryToString(binaryString As String) As String
        Dim text As String = ""
        For i As Integer = 0 To binaryString.Length - 1 Step 8
            Dim byteString As String = binaryString.Substring(i, 8)
            Dim asciiValue As Integer = Convert.ToInt32(byteString, 2)
            Dim character As Char = Chr(asciiValue)
            text &= character
        Next
        Return text
    End Function

End Module
