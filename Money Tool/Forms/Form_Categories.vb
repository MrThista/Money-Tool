Public Class Form_Categories
    Private Sub Form_Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.DatabaseDataSet.Categories)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Categories.CellContentClick

    End Sub

    Private Sub DataGridView_Categories_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Categories.CellValueChanged
        Try
            'save changes
            Me.Validate()
            Me.CategoriesBindingSource.EndEdit()
            Me.CategoriesTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Form_Categories_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call Form_Main.Form_Main_Load("", Nothing)

    End Sub
End Class