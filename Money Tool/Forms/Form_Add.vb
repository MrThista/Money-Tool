Public Class Form_Add
    Private Sub Form_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.DatabaseDataSet.Transactions)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.DatabaseDataSet.Categories)

        TextBox_Amount.Text = FormatCurrency(TransactionsTableAdapter.Get_Amount_From_Name(ComboBox_Name.Text), 2)
        ComboBox_Category.Text = TransactionsTableAdapter.Get_Category_From_Name(ComboBox_Name.Text)

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
            Transaction_ListTableAdapter.Insert(ComboBox_Name.Text, TextBox_Amount.Text, ComboBox_Category.Text, ComboBox_PaidStatus.Text, TextBox_Comments.Text, Form_Main.ComboBox_MonthView_Month.Text & Form_Main.ComboBox_MonthView_Year.Text)

            'close form
            Close()
            'Load and Filter

            Form_Main.Button_MonthView_Filter.PerformClick()

        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Name.SelectedIndexChanged
        Try
            TextBox_Amount.Text = FormatCurrency(TransactionsTableAdapter.Get_Amount_From_Name(ComboBox_Name.Text), 2)
            ComboBox_Category.Text = TransactionsTableAdapter.Get_Category_From_Name(ComboBox_Name.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox_Name_ValueMemberChanged(sender As Object, e As EventArgs) Handles ComboBox_Name.ValueMemberChanged

    End Sub
End Class