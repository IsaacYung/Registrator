'
' Criado por SharpDevelop.
' Usuário: Isaac
' Data: 13/03/2013
' Hora: 0:43
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class frmPrincipal
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.textBox1 = New System.Windows.Forms.TextBox
		Me.textBox2 = New System.Windows.Forms.TextBox
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(61, 77)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(156, 20)
		Me.textBox1.TabIndex = 0
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(61, 103)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(156, 20)
		Me.textBox2.TabIndex = 1
		'
		'frmPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 659)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Name = "frmPrincipal"
		Me.Text = "frmPrincipal"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
End Class
