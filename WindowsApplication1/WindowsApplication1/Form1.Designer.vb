<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BiliotecaDataSet = New WindowsApplication1.BiliotecaDataSet()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosTableAdapter = New WindowsApplication1.BiliotecaDataSetTableAdapters.LibrosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BiliotecaDataSetTableAdapters.TableAdapterManager()
        Me.LibrosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.cmbOperaciones = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.BiliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BiliotecaDataSet
        '
        Me.BiliotecaDataSet.DataSetName = "BiliotecaDataSet"
        Me.BiliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.BiliotecaDataSet
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LibrosTableAdapter = Me.LibrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.BiliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibrosDataGridView
        '
        Me.LibrosDataGridView.AutoGenerateColumns = False
        Me.LibrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibrosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        Me.LibrosDataGridView.DataSource = Me.LibrosBindingSource
        Me.LibrosDataGridView.Location = New System.Drawing.Point(278, 83)
        Me.LibrosDataGridView.Name = "LibrosDataGridView"
        Me.LibrosDataGridView.Size = New System.Drawing.Size(546, 330)
        Me.LibrosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Editorial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Editorial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Disponible"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Disponible"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(805, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "La Flipante Biblioteca Virtual ¡Ostia Chaval! ¡Que pasada!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Location = New System.Drawing.Point(24, 251)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 3
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'cmbOperaciones
        '
        Me.cmbOperaciones.FormattingEnabled = True
        Me.cmbOperaciones.Location = New System.Drawing.Point(114, 200)
        Me.cmbOperaciones.Name = "cmbOperaciones"
        Me.cmbOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cmbOperaciones.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Editorial"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(114, 115)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtAutor.TabIndex = 9
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(112, 158)
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(100, 20)
        Me.txtEditorial.TabIndex = 10
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(24, 222)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Evaluación del Tercer Corte"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ing. De Computación"
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ricardo Faría C.I: 31.124.008"
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Algoritmos y Programación III"
        '
        'Label9
        '
        Me.Label9.AutoEllipsis = True
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sección: IC0611"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Acciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 441)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtEditorial)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbOperaciones)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LibrosDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BiliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BiliotecaDataSet As WindowsApplication1.BiliotecaDataSet
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrosTableAdapter As WindowsApplication1.BiliotecaDataSetTableAdapters.LibrosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BiliotecaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibrosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents cmbOperaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtEditorial As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
