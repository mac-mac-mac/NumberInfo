Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumber.Text = ""
        lblNumberInfo.Text = ""
        radWord.Checked = True
    End Sub

    Private Function ValidateInput() As Boolean
        Dim intNum As Integer
        Dim blnValid As Boolean

        Try
            intNum = Convert.ToInt32(txtNumber.Text)
            If intNum > 0D And intNum < 1001D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a positive whole number between 1 and 1000", , "Input Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Input Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount", , "Input Error")
        Catch Exception As SystemException
            MsgBox("Please enter a valid number", , "Input Error")
        End Try

        Return blnValid
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intInput As Integer

        If ValidateInput() Then
            intInput = Convert.ToInt32(txtNumber.Text)

            If radBin.Checked Then
                lblNumberInfo.Text = "Binary Form" + Convert.ToString(intInput)
            End If

            If radHex.Checked Then
                lblNumberInfo.Text = "Hexadecimal Form" + Convert.ToString(intInput)
            End If

            If radRoman.Checked Then
                lblNumberInfo.Text = "Roman Numeral Form" + Convert.ToString(intInput)
            End If

            If radPrimes.Checked Then
                lblNumberInfo.Text = getPrimes(intInput)
            End If

            If radWord.Checked Then
                lblNumberInfo.Text = getWordForm(intInput)
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber.Text = ""
        lblNumberInfo.Text = ""
        radWord.Checked = True
    End Sub

    Private Function getWordForm(num As Integer) As String
        Dim wordForm As String = Convert.ToString(num) + " - Word Form:" + vbNewLine + vbNewLine

        If num = 1000 Then
            Return wordForm + "one thousand"
        End If

        If num < 1000 And num > 899 Then
            wordForm = wordForm + "nine hundred "
            num = num - 900
        End If

        If num < 900 And num > 799 Then
            wordForm = wordForm + "eight hundred "
            num = num - 800
        End If

        If num < 800 And num > 699 Then
            wordForm = wordForm + "seven hundred "
            num = num - 700
        End If

        If num < 700 And num > 599 Then
            wordForm = wordForm + "six hundred "
            num = num - 600
        End If

        If num < 600 And num > 499 Then
            wordForm = wordForm + "five hundred "
            num = num - 500
        End If

        If num < 500 And num > 399 Then
            wordForm = wordForm + "four hundred "
            num = num - 400
        End If

        If num < 400 And num > 299 Then
            wordForm = wordForm + "three hundred "
            num = num - 300
        End If

        If num < 300 And num > 199 Then
            wordForm = wordForm + "two hundred "
            num = num - 200
        End If

        If num < 200 And num > 99 Then
            wordForm = wordForm + "one hundred "
            num = num - 100
        End If

        If num < 100 And num > 89 Then
            wordForm = wordForm + "ninety "
            num = num - 90
        End If

        If num < 90 And num > 79 Then
            wordForm = wordForm + "eighty "
            num = num - 80
        End If

        If num < 80 And num > 69 Then
            wordForm = wordForm + "seventy "
            num = num - 70
        End If

        If num < 70 And num > 59 Then
            wordForm = wordForm + "sixty "
            num = num - 60
        End If

        If num < 60 And num > 49 Then
            wordForm = wordForm + "fifty "
            num = num - 50
        End If

        If num < 50 And num > 39 Then
            wordForm = wordForm + "forty "
            num = num - 40
        End If

        If num < 40 And num > 29 Then
            wordForm = wordForm + "thirty "
            num = num - 30
        End If

        If num < 30 And num > 19 Then
            wordForm = wordForm + "twenty "
            num = num - 20
        End If

        If num = 19 Then
            Return wordForm + "nineteen"
        End If

        If num = 18 Then
            Return wordForm + "eighteen"
        End If

        If num = 17 Then
            Return wordForm + "seventeen"
        End If

        If num = 16 Then
            Return wordForm + "sixteen"
        End If

        If num = 15 Then
            Return wordForm + "fifteen"
        End If

        If num = 14 Then
            Return wordForm + "fourteen"
        End If

        If num = 13 Then
            Return wordForm + "thirteen"
        End If

        If num = 12 Then
            Return wordForm + "twelve"
        End If

        If num = 11 Then
            Return wordForm + "eleven"
        End If

        If num = 10 Then
            Return wordForm + "ten"
        End If

        If num = 9 Then
            Return wordForm + "nine"
        End If

        If num = 8 Then
            Return wordForm + "eight"
        End If

        If num = 7 Then
            Return wordForm + "seven"
        End If

        If num = 6 Then
            Return wordForm + "six"
        End If

        If num = 5 Then
            Return wordForm + "five"
        End If

        If num = 4 Then
            Return wordForm + "four"
        End If

        If num = 3 Then
            Return wordForm + "three"
        End If

        If num = 2 Then
            Return wordForm + "two"
        End If

        If num = 1 Then
            Return wordForm + "one"
        End If

        Return wordForm

    End Function

    Private Function getPrimes(num As Integer) As String
        Dim message As String = Convert.ToString(num) + " - Prime Factorization:" + vbNewLine + vbNewLine
        Dim primes As New List(Of String)

        If num = 1 Then
            Return message + "1 is neither prime nor composite. 1 has only 1 factor (itself)."
        End If

        Dim x As Integer = 2
        While x * x <= num
            If num Mod x = 0 Then
                primes.Add(Convert.ToString(x))
                num = num / x
            Else
                x = x + 1
            End If
        End While

        If num > 1 Then
            primes.Add(Convert.ToString(num))
        End If

        Return message + String.Join(" x ", primes)
    End Function

    Private Function getRoman(num As Integer) As String
        Return ""
    End Function

    Private Function getHex(num As Integer) As String
        Return ""
    End Function

    Private Function getBin(num As Integer) As String
        Return ""
    End Function
End Class

