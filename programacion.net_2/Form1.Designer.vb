<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.producto = New System.Windows.Forms.Label()
        Me.valor = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.Label()
        Me.neto = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtneto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'producto
        '
        Me.producto.AutoSize = True
        Me.producto.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.producto.Location = New System.Drawing.Point(37, 53)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(60, 15)
        Me.producto.TabIndex = 0
        Me.producto.Text = "producto"
        '
        'valor
        '
        Me.valor.AutoSize = True
        Me.valor.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.valor.Location = New System.Drawing.Point(58, 86)
        Me.valor.Name = "valor"
        Me.valor.Size = New System.Drawing.Size(39, 15)
        Me.valor.TabIndex = 1
        Me.valor.Text = "valor"
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(38, 123)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(59, 15)
        Me.cantidad.TabIndex = 2
        Me.cantidad.Text = "cantidad"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Location = New System.Drawing.Point(40, 160)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(57, 15)
        Me.subtotal.TabIndex = 3
        Me.subtotal.Text = "subtotal"
        '
        'descuento
        '
        Me.descuento.AutoSize = True
        Me.descuento.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descuento.Location = New System.Drawing.Point(31, 198)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(66, 15)
        Me.descuento.TabIndex = 4
        Me.descuento.Text = "descuento"
        '
        'neto
        '
        Me.neto.AutoSize = True
        Me.neto.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.neto.Location = New System.Drawing.Point(58, 231)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(33, 15)
        Me.neto.TabIndex = 5
        Me.neto.Text = "neto"
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(131, 51)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(97, 20)
        Me.txtproducto.TabIndex = 6
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(131, 86)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(97, 20)
        Me.txtvalor.TabIndex = 7
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(131, 123)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(97, 20)
        Me.txtcantidad.TabIndex = 8
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(131, 160)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(97, 20)
        Me.txtsubtotal.TabIndex = 9
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(131, 196)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.ReadOnly = True
        Me.txtdescuento.Size = New System.Drawing.Size(97, 20)
        Me.txtdescuento.TabIndex = 10
        '
        'txtneto
        '
        Me.txtneto.Location = New System.Drawing.Point(131, 229)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.ReadOnly = True
        Me.txtneto.Size = New System.Drawing.Size(97, 20)
        Me.txtneto.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(288, 308)
        Me.Controls.Add(Me.txtneto)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.neto)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.valor)
        Me.Controls.Add(Me.producto)
        Me.Name = "Form1"
        Me.Text = "calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents producto As Label
    Friend WithEvents valor As Label
    Friend WithEvents cantidad As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents descuento As Label
    Friend WithEvents neto As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtneto As TextBox
End Class
