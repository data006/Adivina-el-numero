Public Class frmKaboomVB

    Dim number As String
    Dim proceso As Boolean = False



    Sub Preguntar()
        proceso = True
        Randomize()
        number = Convert.ToInt32(Rnd() * 10)

        While (True)

            If (InputBox("Que numero estoy pensando?") = number) Then
                MsgBox("Correcto, adivina otro numero")
                proceso = False
                Exit While
            Else
                MsgBox("No, intenta de nuevo")
            End If

        End While

    End Sub









    'Genera numero aleatorio
    Private Sub frmKaboomVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub





    Private Sub tmrPrincipal_Tick(sender As Object, e As EventArgs) Handles tmrPrincipal.Tick
        If proceso = False Then

            Preguntar()
        End If

    End Sub

End Class
