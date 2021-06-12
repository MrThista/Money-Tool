<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Add
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Category = New System.Windows.Forms.ComboBox()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Money_Tool.DatabaseDataSet()
        Me.ComboBox_PaidStatus = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Name = New System.Windows.Forms.ComboBox()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Comments = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Transaction_ListTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.Transaction_ListTableAdapter()
        Me.CategoriesTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.CategoriesTableAdapter()
        Me.TransactionsTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.TransactionsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Category)
        Me.GroupBox1.Controls.Add(Me.ComboBox_PaidStatus)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_Comments)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_Amount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button_Add)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(286, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 291)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Transaction"
        '
        'ComboBox_Category
        '
        Me.ComboBox_Category.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Category.DataSource = Me.CategoriesBindingSource
        Me.ComboBox_Category.DisplayMember = "Category"
        Me.ComboBox_Category.FormattingEnabled = True
        Me.ComboBox_Category.Location = New System.Drawing.Point(79, 70)
        Me.ComboBox_Category.Name = "ComboBox_Category"
        Me.ComboBox_Category.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox_Category.TabIndex = 3
        Me.ComboBox_Category.ValueMember = "Category"
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox_PaidStatus
        '
        Me.ComboBox_PaidStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_PaidStatus.FormattingEnabled = True
        Me.ComboBox_PaidStatus.Items.AddRange(New Object() {"Not Paid", "Paid"})
        Me.ComboBox_PaidStatus.Location = New System.Drawing.Point(79, 97)
        Me.ComboBox_PaidStatus.Name = "ComboBox_PaidStatus"
        Me.ComboBox_PaidStatus.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox_PaidStatus.TabIndex = 3
        Me.ComboBox_PaidStatus.Text = "Not Paid"
        '
        'ComboBox_Name
        '
        Me.ComboBox_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Name.DataSource = Me.TransactionsBindingSource
        Me.ComboBox_Name.DisplayMember = "Name"
        Me.ComboBox_Name.FormattingEnabled = True
        Me.ComboBox_Name.Location = New System.Drawing.Point(79, 17)
        Me.ComboBox_Name.Name = "ComboBox_Name"
        Me.ComboBox_Name.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox_Name.TabIndex = 3
        Me.ComboBox_Name.Text = " "
        Me.ComboBox_Name.ValueMember = "Name"
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Comments"
        '
        'TextBox_Comments
        '
        Me.TextBox_Comments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Comments.Location = New System.Drawing.Point(79, 124)
        Me.TextBox_Comments.Multiline = True
        Me.TextBox_Comments.Name = "TextBox_Comments"
        Me.TextBox_Comments.Size = New System.Drawing.Size(195, 121)
        Me.TextBox_Comments.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Category"
        '
        'TextBox_Amount
        '
        Me.TextBox_Amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Amount.Location = New System.Drawing.Point(79, 44)
        Me.TextBox_Amount.Name = "TextBox_Amount"
        Me.TextBox_Amount.Size = New System.Drawing.Size(195, 20)
        Me.TextBox_Amount.TabIndex = 2
        Me.TextBox_Amount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Paid Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Button_Add
        '
        Me.Button_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Add.Location = New System.Drawing.Point(199, 262)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 0
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Transaction_ListTableAdapter
        '
        Me.Transaction_ListTableAdapter.ClearBeforeFill = True
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Form_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 291)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Add"
        Me.Text = "Transaction Edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_PaidStatus As ComboBox
    Friend WithEvents ComboBox_Name As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Add As Button
    Friend WithEvents TextBox_Comments As TextBox
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents Transaction_ListTableAdapter As DatabaseDataSetTableAdapters.Transaction_ListTableAdapter
    Friend WithEvents ComboBox_Category As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As DatabaseDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As DatabaseDataSetTableAdapters.TransactionsTableAdapter
End Class
