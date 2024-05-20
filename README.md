VB.NET String Obfuscator

Convert your secret string into an obfuscated code, using base64 and aes encryption with different password every char.

For Example, input text : password
then the obfuscated code look like this 

'Call judpWVrT For Obfuscated Text

Dim EuTuNFTz As String = "PyPugBfjG5L3g+Mz9QaGfg=="
Dim ripVniyW As String = "G2clkhH7pLld6hblmTqNjQ=="
Dim DJjjZmEh As String = "y4XNUWv4dznQeFKJb/TLUw=="
Dim MiDBThaK As String = "+XLb+iy2JNlmFpZ+VHG7ag=="
Dim dWPSMbmz As String = "FP8rfwZbP3XLjWd12MU1BQ=="
Dim PSfOOZkr As String = "ZIaMcRm6gTpYLwvFXj4LLQ=="
Dim pCiqWLXt As String = "OrhLGqYtv5NuA2mSHpvrew=="
Dim icALtcXM As String = "nHRNM1Bht0I0KJaNwan6WQ=="
Dim iRpgmncO As String = "kv93/GaR4qj6bo/1aypB5Q=="

Dim judpWVrT As String  = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(dWPSMbmz,"gyQmZGUg"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(EuTuNFTz,"eownvAYq"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(MiDBThaK,"hpHkfevs"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(DJjjZmEh,"GScqoIhi"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(icALtcXM,"QUjrScQu"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(pCiqWLXt,"FQbYcXgm"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(iRpgmncO,"aoaZzTbS"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(PSfOOZkr,"iRRmlFNH"))) & System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(vOdvmSrJ(ripVniyW,"RFqhXkrq"))) 

    Public Function vOdvmSrJ(ByVal EbUHVUlD As String, ByVal zcmuDumc As String) As String
        Dim qTEXqSUs As New System.Security.Cryptography.RijndaelManaged
        Dim jnHIkQBj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim sfkGgTxv As String = ""
        Try
            Dim bwtyQnAb(31) As Byte
            Dim PmeluDkN As Byte() = jnHIkQBj.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(zcmuDumc))
            Array.Copy(PmeluDkN, 0, bwtyQnAb, 0, 16)
            Array.Copy(PmeluDkN, 0, bwtyQnAb, 15, 16)
            qTEXqSUs.Key = bwtyQnAb
            qTEXqSUs.Mode = Security.Cryptography.CipherMode.ECB
            Dim cOTjkIFS As System.Security.Cryptography.ICryptoTransform = qTEXqSUs.CreateDecryptor
            Dim xVpkLnKT As Byte() = Convert.FromBase64String(EbUHVUlD)
            sfkGgTxv = System.Text.ASCIIEncoding.ASCII.GetString(cOTjkIFS.TransformFinalBlock(xVpkLnKT, 0, xVpkLnKT.Length))
            Return sfkGgTxv
        Catch ex As Exception
            Return EbUHVUlD
        End Try
    End Function
