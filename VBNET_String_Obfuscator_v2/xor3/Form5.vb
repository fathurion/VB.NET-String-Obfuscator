Imports System.IO

Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(hljnbuYt)
        If Not TextBox1.Text = "" Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
            TextBox1.Focus()
            obfuscate()
            If ListBox1.SelectedIndex > -1 Then
            Else
                ListBox1.SelectedIndex = 0
            End If

        End If

    End Sub

    Private Sub cBInspect_CheckedChanged(sender As Object, e As EventArgs) Handles cBInspect.CheckedChanged, ckAlpa.CheckedChanged, ckChinese.CheckedChanged, ckGreek.CheckedChanged
        obfuscate()
        TextBox1.Focus()
    End Sub


    Sub obfuscate()
        If Not ListBox1.Items.Count = 0 Then
            RichTextBox1.Clear()
            RichTextBox2.Clear()
            RichTextBox3.Clear()
            RichTextBox4.Clear()

            For Each item In ListBox1.Items
                Dim based As String = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(item))
                Dim separatedBase64 As String = ""
                For i As Integer = 0 To based.Length - 1
                    Dim rnd1 As String = RandomString()
                    Dim rnd2 As String = RandomString()
                    Dim rnd3 As String = RandomString()
                    'Dim rnd4 As String = NormalRandomString()

                    Dim enc As String = XorEncrypt(Base64Encode(AESEncrypt(StringToBinary(based(i)), rnd2)), rnd3)

                    ' Dim asciiValues As String = ""
                    ' For Each ch As Char In enc
                    'Dim rans As String = RandomString()
                    '    asciiValues &= "Chr(" & Asc(ch) & ").ToString & "
                    '  Next
                    'RichTextBox1.Text += "Dim " & rnd1 & " As String = " & asciiValues.Substring(0, asciiValues.Length - 2) & vbNewLine

                    RichTextBox1.Text += "Dim " & rnd1 & " As String = " & Chr(34) & enc & Chr(34) & vbNewLine

                    If i = 0 Then
                        Dim rnd4 As String = NormalRandomString()
                        RichTextBox2.Text += "Public " & rnd4 & " As String = " & "Base64Decode("
                        RichTextBox3.Text += "' " & Chr(34) & item & Chr(34) & " = " & rnd4 & vbNewLine
                    End If

                    RichTextBox2.Text = RichTextBox2.Text & "BinaryToString(AESDecrypt(Base64Decode(XorDecrypt(" & rnd1 & "," & Chr(34) & rnd3 & Chr(34) & ")), " & Chr(34) & rnd2 & Chr(34) & "))" & " & "

                Next

                    RichTextBox2.Text = RichTextBox2.Text.Substring(0, Len(RichTextBox2.Text) - 3) & ")" & vbNewLine
                Next

            '=============================
            Dim xx1 As String = RandomString()
            Dim xx2 As String = RandomString()
            Dim xx3 As String = RandomString()
            Dim xx4 As String = RandomString()
            Dim xx5 As String = RandomString()
            Dim xx6 As String = RandomString()
            Dim xx7 As String = RandomString()
            Dim xx8 As String = RandomString()
            Dim xx9 As String = RandomString()
            Dim xx10 As String = RandomString()
            Dim xx11 As String = RandomString()
            Dim xx12 As String = RandomString()
            Dim xx13 As String = RandomString()
            Dim xx14 As String = RandomString()
            Dim xx15 As String = RandomString()
            Dim xx16 As String = RandomString()
            Dim xx17 As String = RandomString()
            Dim xx18 As String = RandomString()
            Dim xx19 As String = RandomString()
            Dim xx20 As String = RandomString()
            Dim xx21 As String = RandomString()
            Dim xx22 As String = RandomString()
            Dim xx23 As String = RandomString()
            Dim xx24 As String = RandomString()
            Dim xx25 As String = RandomString()
            Dim xx26 As String = NormalRandomString()
            Dim xxhaha As String = RandomString()
            Dim lines() As String = RichTextBox1.Text.Split(vbNewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            RichTextBox1.Text = String.Join(vbNewLine, lines)
            RichTextBox4.Text = My.Resources.dic.Replace("qq1", xx26) & RichTextBox3.Text & "' =====================================================" & _
                vbNewLine & vbNewLine & ShuffleRichTextBoxContent(RichTextBox1) & vbNewLine & vbNewLine & _RichTextBox2.Text.Replace("XorDecrypt", xx1). _
                Replace("Base64Decode", xx6).Replace("AESDecrypt", xx9).Replace("BinaryToString", xx20) & vbNewLine & vbNewLine & _
                My.Resources.plains.Replace("ob1", xx1).Replace("ob2", xx2).Replace("ob3", xx3).Replace("ob4", xx4).Replace("ob5", xx5).Replace("ob6", xx6). _
                Replace("ob7", xx7).Replace("ob8", xx8).Replace("ob9", xx9).Replace("ox1", xx10).Replace("ox2", xx11).Replace("ox3", xx12).Replace("ox4", xx13). _
                Replace("ox5", xx14).Replace("ox6", xx15).Replace("ox7", xx16).Replace("oy7", xx17).Replace("ox8", xx18).Replace("ox9", xx19).Replace("oy1", xx20). _
                Replace("oy2", xx21).Replace("oy3", xx22).Replace("oy4", xx23).Replace("oy5", xx24).Replace("oy6", xx25).Replace("obhaha", xxhaha) & vbNewLine & "End Module"
        End If

    End Sub
    'Dim anu As 
    Public Function NormalRandomString() As String
        Dim alpabetsx As String = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcba"
        Dim chinesex As String = "长两动从老已三同公面头经见本所前如又方行主用十手开无文看想当作只事成发还起于日没然都好能而天多心么什么小后里她以可可对学家过的之去着自会生以下要那就得年时也道出地你和子为们说到个国上来大中这他"
        Dim greekx As String = "ωΩψΨχΧφΦυΥτΤςσΣρπΠοΟξΞνΝμΜλΛκΚιΙθΘηΗζΖεΕδΔγΓβΒαΑ"
        Dim thaix As String = "ฮอฬหสษศวลรยมภฟพฝผปบนธทถตดณฒฑฐฏฎญฌซชฉจงฆฅคฃขก"
        Static r As New Random
        Dim chactersInStringx As Integer
        If cBInspect.Checked = True Then
            chactersInStringx = r.Next(4, 12)
        ElseIf cBInspect.Checked = False Then
            chactersInStringx = r.Next(4, 4)
        End If
        Dim sbx As New System.Text.StringBuilder
        If ckAlpa.Checked = True Then
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, alpabetsx.Length)
                sbx.Append(alpabetsx.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, alpabetsx.Length)
                sbx.Append(alpabetsx.Substring(idx, 1))
            Next
        End If
        If ckGreek.Checked = True Then
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, greekx.Length)
                sbx.Append(greekx.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, greekx.Length)
                sbx.Append(greekx.Substring(idx, 1))
            Next
        End If
        If ckChinese.Checked = True Then
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, chinesex.Length)
                sbx.Append(chinesex.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, chinesex.Length)
                sbx.Append(chinesex.Substring(idx, 1))
            Next
        End If
        If ckThai.Checked = True Then
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, thaix.Length)
                sbx.Append(thaix.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInStringx
                Dim idx As Integer = r.Next(0, thaix.Length)
                sbx.Append(thaix.Substring(idx, 1))
            Next
        End If

        Return sbx.ToString()
    End Function
    Public Function RandomString()
        Dim alpabets As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim chinese As String = "他这中大来上国个到说们为子和你地出道也时年得就那要下以生会自着去之的过家学对可可以她里后小么什么心多天而能好都然没日于起还发成事只作当想看文无开手十用主行方又如前所本见经头面公同三已老从动两长"
        Dim greek As String = "ΑαΒβΓγΔδΕεΖζΗηΘθΙιΚκΛλΜμΝνΞξΟοΠπρΣσςΤτΥυΦφΧχΨψΩω"
        Dim thai As String = "กขฃคฅฆงจฉชซฌญฎฏฐฑฒณดตถทธนบปผฝพฟภมยรลวศษสหฬอฮ"
        Static r As New Random
        Dim chactersInString As Integer
        If cBInspect.Checked = True Then
            chactersInString = r.Next(4, 128)
        ElseIf cBInspect.Checked = False Then
            chactersInString = r.Next(4, 4)
        End If

        Dim sb As New System.Text.StringBuilder
        If ckAlpa.Checked = True Then
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, alpabets.Length)
                sb.Append(alpabets.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, alpabets.Length)
                sb.Append(alpabets.Substring(idx, 1))
            Next
        End If
        If ckGreek.Checked = True Then
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, greek.Length)
                sb.Append(greek.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, greek.Length)
                sb.Append(greek.Substring(idx, 1))
            Next
        End If
        If ckChinese.Checked = True Then
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, chinese.Length)
                sb.Append(chinese.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, chinese.Length)
                sb.Append(chinese.Substring(idx, 1))
            Next
        End If
        If ckThai.Checked = True Then
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, thai.Length)
                sb.Append(thai.Substring(idx, 1))
            Next
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, thai.Length)
                sb.Append(thai.Substring(idx, 1))
            Next
        End If

        Return sb.ToString()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.Items.Count = 0 Then
            ListBox1.Items.Clear()
            RichTextBox1.Clear()
            RichTextBox2.Clear()
            RichTextBox3.Clear()
            RichTextBox4.Clear()
            'Button5.Enabled = False
        End If
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(RichTextBox4.Text)
        MsgBox("Copied to clipboard!", MsgBoxStyle.Information, "Success")
        TextBox1.Focus()
    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged
        If RichTextBox1.Text = "" Then
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        Else
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim words As String() = RichTextBox4.Text.Split(New Char() {" "c})
        Try
            Dim saveFileDialog As New SaveFileDialog

            With saveFileDialog
                .Filter = "Visual Basic Module (*.vb)|*.vb|All files (*.*)|*.*"
                .Title = "Save obfuscated module"
                .FileName = words(1) & ".vb"
                If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Using fs As New StreamWriter(.FileName)
                        fs.Write(RichTextBox4.Text)
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End If
            End With
        Catch ex As Exception
        End Try
        TextBox1.Focus()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(KyOBrikf)
        Me.AcceptButton = Button1
        TextBox1.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)


            obfuscate()
            If ListBox1.Items.Count = 0 Then
                RichTextBox4.Clear()
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
            End If
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Form5_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox(IbIftHfX & Chr(13) & Chr(13) & KwGmwfkX & Chr(13) & Chr(13) & DhClkmhU, MsgBoxStyle.Information, "About")
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class