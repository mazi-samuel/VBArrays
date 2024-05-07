Imports System.Reflection.Emit

Public Class Form1
    Private Sub btnEvenOrOdd_Click(sender As Object, e As EventArgs) Handles btnDivisibility.Click

        ' Get the array of integers from the textbox
        Dim ar() As String
        ar = Split(txtArrays.Text, ",")

        ' Get the value of k
        Dim k As Integer
        If Integer.TryParse(txtK.Text, k) AndAlso k > 0 Then
            ' k has been successfully parsed from txtK.Text and it's greater than 0
            ' we can now proceed with further operations

            ' Initialize the count of valid pairs
            Dim count As Integer
            count = 0

            ' Iterate through all pairs of indices i and j such that i < j
            Dim i As Integer, j As Integer
            For i = 0 To UBound(ar) - 1
                For j = i + 1 To UBound(ar)
                    ' Calculate the sum of elements at indices i and j
                    Dim sum As Integer
                    sum = Val(ar(i)) + Val(ar(j))

                    ' Check if the sum is divisible by k
                    If sum Mod k = 0 Then
                        ' Increment count if divisible
                        count = count + 1
                    End If
                Next j
            Next i

            ' Display the count of valid pairs
            MsgBox("The Number of (i,j) pairs where I < j and ar[i] + ar[j] is divisible by k is: " & count)
        Else
            ' Handle the case where the input is not a valid positive integer
            MsgBox("Please provide a valid positive integer: A positive integer is a number greater than zero")
        End If





    End Sub

    Private Sub lblK_Click(sender As Object, e As EventArgs) Handles lblK.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtArrays.Text = ""
        txtK.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
