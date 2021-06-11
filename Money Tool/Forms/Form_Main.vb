Imports System.IO

Public Class Form_Main
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Transactions_Grouped' table. You can move, or remove it, as needed.
        Me.Transactions_GroupedTableAdapter.Fill(Me.DatabaseDataSet.Transactions_Grouped)
        Try
            'fill datatables from dataset
            Me.Transaction_ListTableAdapter.Fill(Me.DatabaseDataSet.Transaction_List)
            Me.TransactionsTableAdapter.Fill(Me.DatabaseDataSet.Transactions)
            Me.IncomeTableAdapter.Fill(Me.DatabaseDataSet.Income)
            Me.AccountsTableAdapter.Fill(Me.DatabaseDataSet.Accounts)

            'fill comboboxes with default current info
            ComboBox_MonthView_Month.SelectedIndex = Month(Now) - 1
            ComboBox_MonthView_Year.Text = Year(Now)

            'Auto Filter
            Button_MonthView_Filter.PerformClick()

            'status

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.Transaction_ListBindingSource.EndEdit()
            Me.Transaction_ListTableAdapter.Update(Me.DatabaseDataSet)

            'refresh
            Call Button_MonthView_Refresh.PerformClick()

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

    Private Sub Button_MonthView_Filter_Click(sender As Object, e As EventArgs) Handles Button_MonthView_Filter.Click
        Try
            Dim Month As String = ComboBox_MonthView_Month.Text
            Dim Year As String = ComboBox_MonthView_Year.Text
            Dim mCode As String = Month & Year



            Dim Filter As String = ""

            If ComboBox_MonthView_PaidStatus.Text = "All" Then Filter = "MonthID = '" & mCode & "'"
            If ComboBox_MonthView_PaidStatus.Text = "Paid" Then Filter = "MonthID = '" & mCode & "'" & " AND Status = 'Paid'"
            If ComboBox_MonthView_PaidStatus.Text = "Not Paid" Then Filter = "MonthID = '" & mCode & "'" & " AND Status = 'Not Paid'"


            Me.Transaction_ListTableAdapter.Fill(Me.DatabaseDataSet.Transaction_List)
            Transaction_ListBindingSource.Filter = Filter
            Transaction_ListDataGridView.DataSource = Nothing
            Transaction_ListDataGridView.DataSource = Transaction_ListBindingSource

            'refresh button click
            Button_MonthView_Refresh.PerformClick()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click
        Try
            Me.Validate()

            Me.AccountsBindingSource.EndEdit()
            Me.IncomeBindingSource.EndEdit()
            Me.TransactionsBindingSource.EndEdit()
            Me.Transaction_ListBindingSource.EndEdit()

            Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)
            Me.IncomeTableAdapter.Update(Me.DatabaseDataSet)
            Me.TransactionsTableAdapter.Update(Me.DatabaseDataSet)
            Me.Transaction_ListTableAdapter.Update(Me.DatabaseDataSet)

            MsgBox("Data Saved", vbOKOnly)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            'getting error: database file is in use so cannot be copied,

            Dim xfile As String = Application.StartupPath & "\database.mdf"
            Dim FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()

            Dim NewFolder As String = FolderBrowserDialog.ShowDialog()

            File.Copy(xfile, NewFolder & "\database.mdf")

            Debug.Print(xfile)
            Debug.Print(NewFolder & "\database.mdf")

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Button_MonthView_Refresh_Click(sender As Object, e As EventArgs) Handles Button_MonthView_Refresh.Click

        Dim MonthID As String = ComboBox_MonthView_Month.Text & ComboBox_MonthView_Year.Text

        On Error Resume Next

        'month income
        TextBox_MonthView_MonthIncome.Text = "0"
        TextBox_MonthView_MonthIncome.Text = IncomeTableAdapter.Get_FiltersMonthID_NetPay(MonthID)

        'month total
        TextBox_MonthView_MonthTotal.Text = "0"
        TextBox_MonthView_MonthTotal.Text = Transaction_ListTableAdapter.Get_MonthTotal(MonthID)

        'month paid
        TextBox_MonthView_MonthPaid.Text = "0"
        TextBox_MonthView_MonthPaid.Text = Transaction_ListTableAdapter.Get_Paid_or_Unpaid(MonthID, "Paid")

        'month not paid
        TextBox_MonthView_MonthNotPaid.Text = "0"
        TextBox_MonthView_MonthNotPaid.Text = Transaction_ListTableAdapter.Get_Paid_or_Unpaid(MonthID, "Not Paid")

        'main account funds
        TextBox_MonthView_MainAccountFunds.Text = "0"
        TextBox_MonthView_MainAccountFunds.Text = AccountsTableAdapter.IncomeQuery_Get_MainAccountBalance

        'main account left
        TextBox_MonthView_MainAccountLeft.Text = "0"
        TextBox_MonthView_MainAccountLeft.Text = TextBox_MonthView_MainAccountFunds.Text - TextBox_MonthView_MonthNotPaid.Text

    End Sub

    Private Sub Button_MonthView_AddTransaction_Click(sender As Object, e As EventArgs) Handles Button_MonthView_AddTransaction.Click
        Try
            Form_Add.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Transactions_BulkAdd_Click(sender As Object, e As EventArgs) Handles Button_Transactions_BulkAdd.Click


        'ask if the month is correct
        Dim ans As String = MsgBox("Would you like to add the highlighted transactions to " & ComboBox_MonthView_Month.Text & " " & ComboBox_MonthView_Year.Text, vbOKCancel, "Are you sure?")
        Dim Name As String = ""
        Dim Amount As Object = 0
        Dim Comments As String = ""
        Dim Month As String = ComboBox_MonthView_Month.Text
        Dim Year As String = ComboBox_MonthView_Year.Text
        Dim MonthID As String = Month & Year

        If ans = vbOK Then
            'add each selected row to this months transaction list
            For Each row As DataGridViewRow In TransactionsDataGridView.Rows
                If row.Selected = True Then
                    'Set Veriables

                    If String.IsNullOrWhiteSpace(row.Cells(0).FormattedValue) = False Then Name = row.Cells(0).Value
                    If String.IsNullOrWhiteSpace(row.Cells(4).FormattedValue) = False Then Amount = row.Cells(4).Value
                    If String.IsNullOrWhiteSpace(row.Cells(2).FormattedValue) = False Then Comments = row.Cells(2).Value

                    'add to transaction list table
                    Transaction_ListTableAdapter.Insert(Name, Amount, "Not Paid", Comments, MonthID)

                    Name = Nothing
                    Amount = Nothing
                    Comments = Nothing

                    'Refresh DGV
                    Button_MonthView_Filter.PerformClick()

                    'nav to MonthView
                    TabControl1.SelectTab("TabMonthView")

                End If
            Next

        End If


    End Sub

    Private Sub Button_Transactions_Save_Click(sender As Object, e As EventArgs) Handles Button_Transactions_Save.Click
        Try
            'save changes
            Me.Validate()
            Me.TransactionsBindingSource.EndEdit()
            Me.TransactionsTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Transactions_HighlightRecurring_Click(sender As Object, e As EventArgs) Handles Button_Transactions_HighlightRecurring.Click
        Try
            'go through dgv and select all that have recurring status and active

            For Each row As DataGridViewRow In TransactionsDataGridView.Rows
                If row.Cells(5).Value = "Recurring" And row.Cells(6).FormattedValue.ToString = "True" Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub TransactionsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionsDataGridView.CellContentClick

    End Sub

    Private Sub TransactionsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionsDataGridView.CellValueChanged
        Try
            'refresh stats dgv
            Me.Transactions_GroupedTableAdapter.Fill(Me.DatabaseDataSet.Transactions_Grouped)
            DataGridView_Transactions_Stats.DataSource = Nothing
            DataGridView_Transactions_Stats.DataSource = TransactionsGroupedBindingSource
            'DataGridView_Transactions_Stats.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView_Transactions_Stats_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Transactions_Stats.CellContentClick

    End Sub

    Private Sub DataGridView_Transactions_Stats_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Transactions_Stats.SelectionChanged
        Try
            DataGridView_Transactions_Stats.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransactionsDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionsDataGridView.CellLeave
        'save changes
        Me.Validate()
        Me.TransactionsBindingSource.EndEdit()
        Me.TransactionsTableAdapter.Update(Me.DatabaseDataSet)

        'refresh stats dgv
        Me.Transactions_GroupedTableAdapter.Fill(Me.DatabaseDataSet.Transactions_Grouped)
        DataGridView_Transactions_Stats.DataSource = Nothing
        DataGridView_Transactions_Stats.DataSource = TransactionsGroupedBindingSource
        DataGridView_Transactions_Stats.ClearSelection()

        'Update Total
        Dim Total As Double = 0
        For Each row In DataGridView_Transactions_Stats.Rows
            Total = Total + row.cells(1).formattedvalue
        Next

        TextBox_Transactions_StatsTotal.Text = "£" & Total

    End Sub
End Class