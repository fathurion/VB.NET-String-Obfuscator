Imports System.Text

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = GSLqsKJf
    End Sub

    'Call GSLqsKJf For Obfuscated Text

    Dim rjqTqEgq As String = "kSYbhnL/Vs33Eg7eDKFOGQ=="
    Dim HGgbXRzR As String = "lYnzr+UQZPteSBfNlSxxhA=="
    Dim CrUhuOvx As String = "oifa0GwFApP+vHYizyggog=="
    Dim aLpdgJzJ As String = "+T6yP9qOuzRah9uSfb472w=="
    Dim WEPypnKt As String = "H+bgg5K5xAwmzgH4PcmFbQ=="
    Dim fxhVkTkC As String = "58WntaYsunAVv/PsYHAArQ=="
    Dim OxCaVOde As String = "mFOhBqEx06ZyZG1R1DqiCw=="
    Dim MbUzbPCB As String = "igprFJtG5ZUX4Sy9k7Cdaw=="
    Dim cSrBHIFW As String = "OUNz5ZPel7twjT1/xWxnzw=="

    Dim GSLqsKJf As String = Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(aLpdgJzJ, "IEIqrMbF"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(CrUhuOvx, "CAmRxPIB"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(fxhVkTkC, "EraPXdiE"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(cSrBHIFW, "QQgSIPyW"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(HGgbXRzR, "dMCjJTVG"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(WEPypnKt, "iLJkqbWA"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(MbUzbPCB, "GHhmWcgC"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(rjqTqEgq, "xTwBmiVj"))) & Encoding.UTF8.GetString(Convert.FromBase64String(NfuYqNxs(OxCaVOde, "EVOGdOIE")))

    Public Function NfuYqNxs(ByVal input As String, ByVal pass As String) As String
        Dim QroCPlRB As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_QroCPlRB As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_QroCPlRB.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            QroCPlRB.Key = hash
            QroCPlRB.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = QroCPlRB.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return input
        End Try
    End Function




End Class