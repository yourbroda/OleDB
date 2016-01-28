<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirJ
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbTitulo = New System.Windows.Forms.TextBox()
        Me.tbEstudio = New System.Windows.Forms.TextBox()
        Me.tbTipo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Titulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(117, 10)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(136, 20)
        Me.tbCodigo.TabIndex = 4
        '
        'tbTitulo
        '
        Me.tbTitulo.Location = New System.Drawing.Point(116, 49)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(136, 20)
        Me.tbTitulo.TabIndex = 5
        '
        'tbEstudio
        '
        Me.tbEstudio.Location = New System.Drawing.Point(116, 88)
        Me.tbEstudio.Name = "tbEstudio"
        Me.tbEstudio.Size = New System.Drawing.Size(136, 20)
        Me.tbEstudio.TabIndex = 6
        '
        'tbTipo
        '
        Me.tbTipo.Location = New System.Drawing.Point(116, 140)
        Me.tbTipo.Name = "tbTipo"
        Me.tbTipo.Size = New System.Drawing.Size(136, 20)
        Me.tbTipo.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 46)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 189)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'AñadirJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 228)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbTipo)
        Me.Controls.Add(Me.tbEstudio)
        Me.Controls.Add(Me.tbTitulo)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AñadirJ"
        Me.Text = "AñadirJ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents tbEstudio As TextBox
    Friend WithEvents tbTipo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
