Public Class frmPizza
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        'confirmation window appears after user clicks on Select Pizza

        If picDeepDish.Visible = True Then
            MessageBox.Show("Thank you, You have selected deep-dish pizza!", "Confirmation")
        ElseIf picThinCrust.Visible = True Then
            MessageBox.Show("Thank you, You have selected thin-crust pizza!", "Confirmation")
        End If

        'disable everything. User can't make changes.
        'ONLY option available should be to Exit. Make Exit appear.

        lblChoosePizza.Visible = False
        btnDeepDish.Visible = False
        picDeepDish.Visible = False
        btnThinCrust.Visible = False
        picThinCrust.Visible = False
        btnSelect.Visible = False
        btnExit.Visible = True

    End Sub

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click

        'When the button for deep-dish is chosen, the corresponding picture shows up

        picDeepDish.Visible = True
        picThinCrust.Visible = False

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click

        'When the button for deep-dish is chosen, the corresponding picture shows up

        picThinCrust.Visible = True
        picDeepDish.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exit Program

        Me.Close()

    End Sub
End Class
