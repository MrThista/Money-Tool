<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Categories
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView_Categories = New System.Windows.Forms.DataGridView()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Money_Tool.DatabaseDataSet()
        Me.CategoriesTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.CategoriesTableAdapter()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_Categories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Categories
        '
        Me.DataGridView_Categories.AllowUserToResizeRows = False
        Me.DataGridView_Categories.AutoGenerateColumns = False
        Me.DataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Categories.ColumnHeadersVisible = False
        Me.DataGridView_Categories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView_Categories.DataSource = Me.CategoriesBindingSource
        Me.DataGridView_Categories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Categories.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Categories.Name = "DataGridView_Categories"
        Me.DataGridView_Categories.RowHeadersVisible = False
        Me.DataGridView_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Categories.Size = New System.Drawing.Size(184, 311)
        Me.DataGridView_Categories.TabIndex = 0
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
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 180
        '
        'Form_Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 311)
        Me.Controls.Add(Me.DataGridView_Categories)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(200, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 350)
        Me.Name = "Form_Categories"
        Me.Text = "Categories"
        CType(Me.DataGridView_Categories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_Categories As DataGridView
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As DatabaseDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
