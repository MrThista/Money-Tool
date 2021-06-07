Public Class Form_Main
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Income' table. You can move, or remove it, as needed.
        Me.IncomeTableAdapter.Fill(Me.DatabaseDataSet.Income)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.DatabaseDataSet.Accounts)

        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView_MonthView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_Accounts_Save.Click
        Try
            Me.Validate()
            Me.AccountsBindingSource.EndEdit()
            Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.IncomeBindingSource.EndEdit()
            Me.IncomeTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
