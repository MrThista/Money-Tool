<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim AccountLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim Account_TypeLabel As System.Windows.Forms.Label
        Dim Total_Credit_LimitLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim MonthIDLabel As System.Windows.Forms.Label
        Dim Pay_DateLabel As System.Windows.Forms.Label
        Dim Pay_PeriodLabel As System.Windows.Forms.Label
        Dim Tax_CodeLabel As System.Windows.Forms.Label
        Dim Basic_SalaryLabel As System.Windows.Forms.Label
        Dim Other_PayLabel As System.Windows.Forms.Label
        Dim PensionLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim NILabel As System.Windows.Forms.Label
        Dim Net_Pay_Label As System.Windows.Forms.Label
        Dim PredictedLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim SourceLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMonthView = New System.Windows.Forms.TabPage()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TabTransactions = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabIncome = New System.Windows.Forms.TabPage()
        Me.IncomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DatabaseDataSet = New Money_Tool.DatabaseDataSet()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.MonthIDTextBox = New System.Windows.Forms.TextBox()
        Me.Pay_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Pay_PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.Tax_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Basic_SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Other_PayTextBox = New System.Windows.Forms.TextBox()
        Me.PensionTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.NITextBox = New System.Windows.Forms.TextBox()
        Me.Net_Pay_TextBox = New System.Windows.Forms.TextBox()
        Me.PredictedTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabAccounts = New System.Windows.Forms.TabPage()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Account_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Total_Credit_LimitTextBox = New System.Windows.Forms.TextBox()
        Me.AccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Accounts_Save = New System.Windows.Forms.Button()
        Me.AccountsTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.AccountsTableAdapter()
        Me.TableAdapterManager = New Money_Tool.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.IncomeTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.IncomeTableAdapter()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PredictedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        AccountLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        Account_TypeLabel = New System.Windows.Forms.Label()
        Total_Credit_LimitLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        MonthIDLabel = New System.Windows.Forms.Label()
        Pay_DateLabel = New System.Windows.Forms.Label()
        Pay_PeriodLabel = New System.Windows.Forms.Label()
        Tax_CodeLabel = New System.Windows.Forms.Label()
        Basic_SalaryLabel = New System.Windows.Forms.Label()
        Other_PayLabel = New System.Windows.Forms.Label()
        PensionLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        NILabel = New System.Windows.Forms.Label()
        Net_Pay_Label = New System.Windows.Forms.Label()
        PredictedLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        SourceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabMonthView.SuspendLayout()
        Me.TabTransactions.SuspendLayout()
        Me.TabIncome.SuspendLayout()
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAccounts.SuspendLayout()
        CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(8, 9)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 6
        IdLabel.Text = "Id:"
        '
        'AccountLabel
        '
        AccountLabel.AutoSize = True
        AccountLabel.Location = New System.Drawing.Point(8, 35)
        AccountLabel.Name = "AccountLabel"
        AccountLabel.Size = New System.Drawing.Size(50, 13)
        AccountLabel.TabIndex = 8
        AccountLabel.Text = "Account:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(8, 61)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 10
        BalanceLabel.Text = "Balance:"
        '
        'Account_TypeLabel
        '
        Account_TypeLabel.AutoSize = True
        Account_TypeLabel.Location = New System.Drawing.Point(8, 87)
        Account_TypeLabel.Name = "Account_TypeLabel"
        Account_TypeLabel.Size = New System.Drawing.Size(77, 13)
        Account_TypeLabel.TabIndex = 12
        Account_TypeLabel.Text = "Account Type:"
        '
        'Total_Credit_LimitLabel
        '
        Total_Credit_LimitLabel.AutoSize = True
        Total_Credit_LimitLabel.Location = New System.Drawing.Point(8, 113)
        Total_Credit_LimitLabel.Name = "Total_Credit_LimitLabel"
        Total_Credit_LimitLabel.Size = New System.Drawing.Size(88, 13)
        Total_Credit_LimitLabel.TabIndex = 14
        Total_Credit_LimitLabel.Text = "Total Credit Limit:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(8, 13)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 7
        IdLabel1.Text = "Id:"
        '
        'MonthIDLabel
        '
        MonthIDLabel.AutoSize = True
        MonthIDLabel.Location = New System.Drawing.Point(8, 39)
        MonthIDLabel.Name = "MonthIDLabel"
        MonthIDLabel.Size = New System.Drawing.Size(54, 13)
        MonthIDLabel.TabIndex = 9
        MonthIDLabel.Text = "Month ID:"
        '
        'Pay_DateLabel
        '
        Pay_DateLabel.AutoSize = True
        Pay_DateLabel.Location = New System.Drawing.Point(8, 65)
        Pay_DateLabel.Name = "Pay_DateLabel"
        Pay_DateLabel.Size = New System.Drawing.Size(54, 13)
        Pay_DateLabel.TabIndex = 11
        Pay_DateLabel.Text = "Pay Date:"
        '
        'Pay_PeriodLabel
        '
        Pay_PeriodLabel.AutoSize = True
        Pay_PeriodLabel.Location = New System.Drawing.Point(8, 91)
        Pay_PeriodLabel.Name = "Pay_PeriodLabel"
        Pay_PeriodLabel.Size = New System.Drawing.Size(61, 13)
        Pay_PeriodLabel.TabIndex = 13
        Pay_PeriodLabel.Text = "Pay Period:"
        '
        'Tax_CodeLabel
        '
        Tax_CodeLabel.AutoSize = True
        Tax_CodeLabel.Location = New System.Drawing.Point(8, 117)
        Tax_CodeLabel.Name = "Tax_CodeLabel"
        Tax_CodeLabel.Size = New System.Drawing.Size(56, 13)
        Tax_CodeLabel.TabIndex = 15
        Tax_CodeLabel.Text = "Tax Code:"
        '
        'Basic_SalaryLabel
        '
        Basic_SalaryLabel.AutoSize = True
        Basic_SalaryLabel.Location = New System.Drawing.Point(8, 143)
        Basic_SalaryLabel.Name = "Basic_SalaryLabel"
        Basic_SalaryLabel.Size = New System.Drawing.Size(68, 13)
        Basic_SalaryLabel.TabIndex = 17
        Basic_SalaryLabel.Text = "Basic Salary:"
        '
        'Other_PayLabel
        '
        Other_PayLabel.AutoSize = True
        Other_PayLabel.Location = New System.Drawing.Point(8, 169)
        Other_PayLabel.Name = "Other_PayLabel"
        Other_PayLabel.Size = New System.Drawing.Size(57, 13)
        Other_PayLabel.TabIndex = 19
        Other_PayLabel.Text = "Other Pay:"
        '
        'PensionLabel
        '
        PensionLabel.AutoSize = True
        PensionLabel.Location = New System.Drawing.Point(8, 195)
        PensionLabel.Name = "PensionLabel"
        PensionLabel.Size = New System.Drawing.Size(48, 13)
        PensionLabel.TabIndex = 21
        PensionLabel.Text = "Pension:"
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.Location = New System.Drawing.Point(8, 221)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(28, 13)
        TaxLabel.TabIndex = 23
        TaxLabel.Text = "Tax:"
        '
        'NILabel
        '
        NILabel.AutoSize = True
        NILabel.Location = New System.Drawing.Point(8, 247)
        NILabel.Name = "NILabel"
        NILabel.Size = New System.Drawing.Size(21, 13)
        NILabel.TabIndex = 25
        NILabel.Text = "NI:"
        '
        'Net_Pay_Label
        '
        Net_Pay_Label.AutoSize = True
        Net_Pay_Label.Location = New System.Drawing.Point(8, 273)
        Net_Pay_Label.Name = "Net_Pay_Label"
        Net_Pay_Label.Size = New System.Drawing.Size(51, 13)
        Net_Pay_Label.TabIndex = 27
        Net_Pay_Label.Text = "Net Pay :"
        '
        'PredictedLabel
        '
        PredictedLabel.AutoSize = True
        PredictedLabel.Location = New System.Drawing.Point(8, 299)
        PredictedLabel.Name = "PredictedLabel"
        PredictedLabel.Size = New System.Drawing.Size(55, 13)
        PredictedLabel.TabIndex = 29
        PredictedLabel.Text = "Predicted:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(8, 325)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(59, 13)
        CommentsLabel.TabIndex = 31
        CommentsLabel.Text = "Comments:"
        '
        'SourceLabel
        '
        SourceLabel.AutoSize = True
        SourceLabel.Location = New System.Drawing.Point(8, 351)
        SourceLabel.Name = "SourceLabel"
        SourceLabel.Size = New System.Drawing.Size(44, 13)
        SourceLabel.TabIndex = 33
        SourceLabel.Text = "Source:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 8, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMonthView)
        Me.TabControl1.Controls.Add(Me.TabTransactions)
        Me.TabControl1.Controls.Add(Me.TabIncome)
        Me.TabControl1.Controls.Add(Me.TabAccounts)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(846, 489)
        Me.TabControl1.TabIndex = 2
        '
        'TabMonthView
        '
        Me.TabMonthView.Controls.Add(Me.ButtonSave)
        Me.TabMonthView.Location = New System.Drawing.Point(4, 22)
        Me.TabMonthView.Name = "TabMonthView"
        Me.TabMonthView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMonthView.Size = New System.Drawing.Size(838, 463)
        Me.TabMonthView.TabIndex = 0
        Me.TabMonthView.Text = "Month View"
        Me.TabMonthView.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(755, 181)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TabTransactions
        '
        Me.TabTransactions.Controls.Add(Me.Button1)
        Me.TabTransactions.Location = New System.Drawing.Point(4, 22)
        Me.TabTransactions.Name = "TabTransactions"
        Me.TabTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransactions.Size = New System.Drawing.Size(838, 463)
        Me.TabTransactions.TabIndex = 1
        Me.TabTransactions.Text = "Transactions"
        Me.TabTransactions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(755, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabIncome
        '
        Me.TabIncome.AutoScroll = True
        Me.TabIncome.Controls.Add(Me.IncomeDataGridView)
        Me.TabIncome.Controls.Add(IdLabel1)
        Me.TabIncome.Controls.Add(Me.IdTextBox1)
        Me.TabIncome.Controls.Add(MonthIDLabel)
        Me.TabIncome.Controls.Add(Me.MonthIDTextBox)
        Me.TabIncome.Controls.Add(Pay_DateLabel)
        Me.TabIncome.Controls.Add(Me.Pay_DateTextBox)
        Me.TabIncome.Controls.Add(Pay_PeriodLabel)
        Me.TabIncome.Controls.Add(Me.Pay_PeriodTextBox)
        Me.TabIncome.Controls.Add(Tax_CodeLabel)
        Me.TabIncome.Controls.Add(Me.Tax_CodeTextBox)
        Me.TabIncome.Controls.Add(Basic_SalaryLabel)
        Me.TabIncome.Controls.Add(Me.Basic_SalaryTextBox)
        Me.TabIncome.Controls.Add(Other_PayLabel)
        Me.TabIncome.Controls.Add(Me.Other_PayTextBox)
        Me.TabIncome.Controls.Add(PensionLabel)
        Me.TabIncome.Controls.Add(Me.PensionTextBox)
        Me.TabIncome.Controls.Add(TaxLabel)
        Me.TabIncome.Controls.Add(Me.TaxTextBox)
        Me.TabIncome.Controls.Add(NILabel)
        Me.TabIncome.Controls.Add(Me.NITextBox)
        Me.TabIncome.Controls.Add(Net_Pay_Label)
        Me.TabIncome.Controls.Add(Me.Net_Pay_TextBox)
        Me.TabIncome.Controls.Add(PredictedLabel)
        Me.TabIncome.Controls.Add(Me.PredictedTextBox)
        Me.TabIncome.Controls.Add(CommentsLabel)
        Me.TabIncome.Controls.Add(Me.CommentsTextBox)
        Me.TabIncome.Controls.Add(SourceLabel)
        Me.TabIncome.Controls.Add(Me.SourceTextBox)
        Me.TabIncome.Controls.Add(Me.Button2)
        Me.TabIncome.Location = New System.Drawing.Point(4, 22)
        Me.TabIncome.Name = "TabIncome"
        Me.TabIncome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIncome.Size = New System.Drawing.Size(838, 463)
        Me.TabIncome.TabIndex = 4
        Me.TabIncome.Text = "Income"
        Me.TabIncome.UseVisualStyleBackColor = True
        '
        'IncomeDataGridView
        '
        Me.IncomeDataGridView.AutoGenerateColumns = False
        Me.IncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncomeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MonthIDDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn, Me.PayPeriodDataGridViewTextBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.BasicSalaryDataGridViewTextBoxColumn, Me.OtherPayDataGridViewTextBoxColumn, Me.PensionDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.NIDataGridViewTextBoxColumn, Me.NetPayDataGridViewTextBoxColumn, Me.PredictedDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn})
        Me.IncomeDataGridView.DataSource = Me.IncomeBindingSource
        Me.IncomeDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.IncomeDataGridView.Location = New System.Drawing.Point(188, 3)
        Me.IncomeDataGridView.Name = "IncomeDataGridView"
        Me.IncomeDataGridView.Size = New System.Drawing.Size(647, 457)
        Me.IncomeDataGridView.TabIndex = 34
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(82, 10)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox1.TabIndex = 8
        '
        'MonthIDTextBox
        '
        Me.MonthIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "MonthID", True))
        Me.MonthIDTextBox.Location = New System.Drawing.Point(82, 36)
        Me.MonthIDTextBox.Name = "MonthIDTextBox"
        Me.MonthIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthIDTextBox.TabIndex = 10
        '
        'Pay_DateTextBox
        '
        Me.Pay_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pay Date", True))
        Me.Pay_DateTextBox.Location = New System.Drawing.Point(82, 62)
        Me.Pay_DateTextBox.Name = "Pay_DateTextBox"
        Me.Pay_DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pay_DateTextBox.TabIndex = 12
        '
        'Pay_PeriodTextBox
        '
        Me.Pay_PeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pay Period", True))
        Me.Pay_PeriodTextBox.Location = New System.Drawing.Point(82, 88)
        Me.Pay_PeriodTextBox.Name = "Pay_PeriodTextBox"
        Me.Pay_PeriodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pay_PeriodTextBox.TabIndex = 14
        '
        'Tax_CodeTextBox
        '
        Me.Tax_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Tax Code", True))
        Me.Tax_CodeTextBox.Location = New System.Drawing.Point(82, 114)
        Me.Tax_CodeTextBox.Name = "Tax_CodeTextBox"
        Me.Tax_CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tax_CodeTextBox.TabIndex = 16
        '
        'Basic_SalaryTextBox
        '
        Me.Basic_SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Basic Salary", True))
        Me.Basic_SalaryTextBox.Location = New System.Drawing.Point(82, 140)
        Me.Basic_SalaryTextBox.Name = "Basic_SalaryTextBox"
        Me.Basic_SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Basic_SalaryTextBox.TabIndex = 18
        '
        'Other_PayTextBox
        '
        Me.Other_PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Other Pay", True))
        Me.Other_PayTextBox.Location = New System.Drawing.Point(82, 166)
        Me.Other_PayTextBox.Name = "Other_PayTextBox"
        Me.Other_PayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Other_PayTextBox.TabIndex = 20
        '
        'PensionTextBox
        '
        Me.PensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pension", True))
        Me.PensionTextBox.Location = New System.Drawing.Point(82, 192)
        Me.PensionTextBox.Name = "PensionTextBox"
        Me.PensionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PensionTextBox.TabIndex = 22
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Tax", True))
        Me.TaxTextBox.Location = New System.Drawing.Point(82, 218)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxTextBox.TabIndex = 24
        '
        'NITextBox
        '
        Me.NITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "NI", True))
        Me.NITextBox.Location = New System.Drawing.Point(82, 244)
        Me.NITextBox.Name = "NITextBox"
        Me.NITextBox.Size = New System.Drawing.Size(100, 20)
        Me.NITextBox.TabIndex = 26
        '
        'Net_Pay_TextBox
        '
        Me.Net_Pay_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Net Pay ", True))
        Me.Net_Pay_TextBox.Location = New System.Drawing.Point(82, 270)
        Me.Net_Pay_TextBox.Name = "Net_Pay_TextBox"
        Me.Net_Pay_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Net_Pay_TextBox.TabIndex = 28
        '
        'PredictedTextBox
        '
        Me.PredictedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Predicted", True))
        Me.PredictedTextBox.Location = New System.Drawing.Point(82, 296)
        Me.PredictedTextBox.Name = "PredictedTextBox"
        Me.PredictedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PredictedTextBox.TabIndex = 30
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(82, 322)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CommentsTextBox.TabIndex = 32
        '
        'SourceTextBox
        '
        Me.SourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Source", True))
        Me.SourceTextBox.Location = New System.Drawing.Point(82, 348)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SourceTextBox.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabAccounts
        '
        Me.TabAccounts.AutoScroll = True
        Me.TabAccounts.Controls.Add(IdLabel)
        Me.TabAccounts.Controls.Add(Me.IdTextBox)
        Me.TabAccounts.Controls.Add(AccountLabel)
        Me.TabAccounts.Controls.Add(Me.AccountTextBox)
        Me.TabAccounts.Controls.Add(BalanceLabel)
        Me.TabAccounts.Controls.Add(Me.BalanceTextBox)
        Me.TabAccounts.Controls.Add(Account_TypeLabel)
        Me.TabAccounts.Controls.Add(Me.Account_TypeTextBox)
        Me.TabAccounts.Controls.Add(Total_Credit_LimitLabel)
        Me.TabAccounts.Controls.Add(Me.Total_Credit_LimitTextBox)
        Me.TabAccounts.Controls.Add(Me.AccountsDataGridView)
        Me.TabAccounts.Controls.Add(Me.Button_Accounts_Save)
        Me.TabAccounts.Location = New System.Drawing.Point(4, 22)
        Me.TabAccounts.Name = "TabAccounts"
        Me.TabAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAccounts.Size = New System.Drawing.Size(838, 463)
        Me.TabAccounts.TabIndex = 5
        Me.TabAccounts.Text = "Accounts"
        Me.TabAccounts.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(102, 6)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 7
        '
        'AccountTextBox
        '
        Me.AccountTextBox.Location = New System.Drawing.Point(102, 32)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountTextBox.TabIndex = 9
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Location = New System.Drawing.Point(102, 58)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BalanceTextBox.TabIndex = 11
        '
        'Account_TypeTextBox
        '
        Me.Account_TypeTextBox.Location = New System.Drawing.Point(102, 84)
        Me.Account_TypeTextBox.Name = "Account_TypeTextBox"
        Me.Account_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Account_TypeTextBox.TabIndex = 13
        '
        'Total_Credit_LimitTextBox
        '
        Me.Total_Credit_LimitTextBox.Location = New System.Drawing.Point(102, 110)
        Me.Total_Credit_LimitTextBox.Name = "Total_Credit_LimitTextBox"
        Me.Total_Credit_LimitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_Credit_LimitTextBox.TabIndex = 15
        '
        'AccountsDataGridView
        '
        Me.AccountsDataGridView.AutoGenerateColumns = False
        Me.AccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AccountsDataGridView.DataSource = Me.AccountsBindingSource
        Me.AccountsDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.AccountsDataGridView.Location = New System.Drawing.Point(208, 3)
        Me.AccountsDataGridView.Name = "AccountsDataGridView"
        Me.AccountsDataGridView.Size = New System.Drawing.Size(627, 457)
        Me.AccountsDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Account"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Balance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Account Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Account Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total Credit Limit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Credit Limit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button_Accounts_Save
        '
        Me.Button_Accounts_Save.Location = New System.Drawing.Point(127, 434)
        Me.Button_Accounts_Save.Name = "Button_Accounts_Save"
        Me.Button_Accounts_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Accounts_Save.TabIndex = 6
        Me.Button_Accounts_Save.Text = "Save"
        Me.Button_Accounts_Save.UseVisualStyleBackColor = True
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Me.AccountsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IncomeTableAdapter = Me.IncomeTableAdapter
        Me.TableAdapterManager.Transaction_ListTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Money_Tool.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'IncomeTableAdapter
        '
        Me.IncomeTableAdapter.ClearBeforeFill = True
        '
        'IncomeBindingSource
        '
        Me.IncomeBindingSource.DataMember = "Income"
        Me.IncomeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthIDDataGridViewTextBoxColumn
        '
        Me.MonthIDDataGridViewTextBoxColumn.DataPropertyName = "MonthID"
        Me.MonthIDDataGridViewTextBoxColumn.HeaderText = "MonthID"
        Me.MonthIDDataGridViewTextBoxColumn.Name = "MonthIDDataGridViewTextBoxColumn"
        '
        'PayDateDataGridViewTextBoxColumn
        '
        Me.PayDateDataGridViewTextBoxColumn.DataPropertyName = "Pay Date"
        Me.PayDateDataGridViewTextBoxColumn.HeaderText = "Pay Date"
        Me.PayDateDataGridViewTextBoxColumn.Name = "PayDateDataGridViewTextBoxColumn"
        '
        'PayPeriodDataGridViewTextBoxColumn
        '
        Me.PayPeriodDataGridViewTextBoxColumn.DataPropertyName = "Pay Period"
        Me.PayPeriodDataGridViewTextBoxColumn.HeaderText = "Pay Period"
        Me.PayPeriodDataGridViewTextBoxColumn.Name = "PayPeriodDataGridViewTextBoxColumn"
        '
        'TaxCodeDataGridViewTextBoxColumn
        '
        Me.TaxCodeDataGridViewTextBoxColumn.DataPropertyName = "Tax Code"
        Me.TaxCodeDataGridViewTextBoxColumn.HeaderText = "Tax Code"
        Me.TaxCodeDataGridViewTextBoxColumn.Name = "TaxCodeDataGridViewTextBoxColumn"
        '
        'BasicSalaryDataGridViewTextBoxColumn
        '
        Me.BasicSalaryDataGridViewTextBoxColumn.DataPropertyName = "Basic Salary"
        Me.BasicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary"
        Me.BasicSalaryDataGridViewTextBoxColumn.Name = "BasicSalaryDataGridViewTextBoxColumn"
        '
        'OtherPayDataGridViewTextBoxColumn
        '
        Me.OtherPayDataGridViewTextBoxColumn.DataPropertyName = "Other Pay"
        Me.OtherPayDataGridViewTextBoxColumn.HeaderText = "Other Pay"
        Me.OtherPayDataGridViewTextBoxColumn.Name = "OtherPayDataGridViewTextBoxColumn"
        '
        'PensionDataGridViewTextBoxColumn
        '
        Me.PensionDataGridViewTextBoxColumn.DataPropertyName = "Pension"
        Me.PensionDataGridViewTextBoxColumn.HeaderText = "Pension"
        Me.PensionDataGridViewTextBoxColumn.Name = "PensionDataGridViewTextBoxColumn"
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "Tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        '
        'NIDataGridViewTextBoxColumn
        '
        Me.NIDataGridViewTextBoxColumn.DataPropertyName = "NI"
        Me.NIDataGridViewTextBoxColumn.HeaderText = "NI"
        Me.NIDataGridViewTextBoxColumn.Name = "NIDataGridViewTextBoxColumn"
        '
        'NetPayDataGridViewTextBoxColumn
        '
        Me.NetPayDataGridViewTextBoxColumn.DataPropertyName = "Net Pay "
        Me.NetPayDataGridViewTextBoxColumn.HeaderText = "Net Pay "
        Me.NetPayDataGridViewTextBoxColumn.Name = "NetPayDataGridViewTextBoxColumn"
        '
        'PredictedDataGridViewTextBoxColumn
        '
        Me.PredictedDataGridViewTextBoxColumn.DataPropertyName = "Predicted"
        Me.PredictedDataGridViewTextBoxColumn.HeaderText = "Predicted"
        Me.PredictedDataGridViewTextBoxColumn.Name = "PredictedDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 535)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Main"
        Me.Text = "Money Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabMonthView.ResumeLayout(False)
        Me.TabTransactions.ResumeLayout(False)
        Me.TabIncome.ResumeLayout(False)
        Me.TabIncome.PerformLayout()
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAccounts.ResumeLayout(False)
        Me.TabAccounts.PerformLayout()
        CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabMonthView As TabPage
    Friend WithEvents TabTransactions As TabPage
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TabIncome As TabPage
    Friend WithEvents TabAccounts As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_Accounts_Save As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents AccountsTableAdapter As DatabaseDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents AccountTextBox As TextBox
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents Account_TypeTextBox As TextBox
    Friend WithEvents Total_Credit_LimitTextBox As TextBox
    Friend WithEvents IncomeTableAdapter As DatabaseDataSetTableAdapters.IncomeTableAdapter
    Friend WithEvents IncomeDataGridView As DataGridView
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents MonthIDTextBox As TextBox
    Friend WithEvents Pay_DateTextBox As TextBox
    Friend WithEvents Pay_PeriodTextBox As TextBox
    Friend WithEvents Tax_CodeTextBox As TextBox
    Friend WithEvents Basic_SalaryTextBox As TextBox
    Friend WithEvents Other_PayTextBox As TextBox
    Friend WithEvents PensionTextBox As TextBox
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents NITextBox As TextBox
    Friend WithEvents Net_Pay_TextBox As TextBox
    Friend WithEvents PredictedTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayPeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PredictedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeBindingSource As BindingSource
    Friend WithEvents AccountsBindingSource As BindingSource
End Class
