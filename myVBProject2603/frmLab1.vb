Public Class frmLab1










    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        lblyearsum.Text = txtSalary.Text * 12

        lblsumtax.Text = lblyearsum.Text * 0.05

        SumSum.Text = lblyearsum.Text - lblsumtax.Text


    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()

    End Sub
End Class
