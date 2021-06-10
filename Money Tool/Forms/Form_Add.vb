Public Class Form_Add
    Private Sub Form_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TransactionsFillComboToolStripButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Try
            'add data to table
            Transaction_ListTableAdapter.Insert(ComboBox_Name.Text, TextBox_Amount.Text, ComboBox_PaidStatus.Text, TextBox_Comments.Text, Form_Main.ComboBox_MonthView_Month.Text & Form_Main.ComboBox_MonthView_Year.Text)

            'close form
            Close()
            'Load and Filter

            Form_Main.Button_MonthView_Filter.PerformClick()

        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        End Try
    End Sub
End Class