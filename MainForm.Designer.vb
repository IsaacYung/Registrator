'
' Criado por SharpDevelop.
' Usuário: isaac.lopes
' Data: 11/03/2013
' Hora: 20:20
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.lblautor = New System.Windows.Forms.Label
		Me.lblversao = New System.Windows.Forms.Label
		Me.lbldireitos = New System.Windows.Forms.Label
		Me.progressBar1 = New System.Windows.Forms.ProgressBar
		Me.lblCompania = New System.Windows.Forms.Label
		Me.SuspendLayout
		'
		'lblautor
		'
		Me.lblautor.BackColor = System.Drawing.Color.Transparent
		Me.lblautor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblautor.ForeColor = System.Drawing.Color.Gray
		Me.lblautor.Location = New System.Drawing.Point(278, 91)
		Me.lblautor.Name = "lblautor"
		Me.lblautor.Size = New System.Drawing.Size(158, 23)
		Me.lblautor.TabIndex = 0
		Me.lblautor.Text = "label1"
		Me.lblautor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		AddHandler Me.lblautor.Click, AddressOf Me.LblautorClick
		'
		'lblversao
		'
		Me.lblversao.BackColor = System.Drawing.Color.Transparent
		Me.lblversao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblversao.ForeColor = System.Drawing.Color.Gray
		Me.lblversao.Location = New System.Drawing.Point(278, 114)
		Me.lblversao.Name = "lblversao"
		Me.lblversao.Size = New System.Drawing.Size(158, 23)
		Me.lblversao.TabIndex = 1
		Me.lblversao.Text = "label2"
		Me.lblversao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		AddHandler Me.lblversao.Click, AddressOf Me.LblversaoClick
		'
		'lbldireitos
		'
		Me.lbldireitos.BackColor = System.Drawing.Color.Transparent
		Me.lbldireitos.ForeColor = System.Drawing.Color.Gray
		Me.lbldireitos.Location = New System.Drawing.Point(55, 207)
		Me.lbldireitos.Name = "lbldireitos"
		Me.lbldireitos.Size = New System.Drawing.Size(381, 31)
		Me.lbldireitos.TabIndex = 3
		Me.lbldireitos.Text = "lbldireitos"
		Me.lbldireitos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'progressBar1
		'
		Me.progressBar1.BackColor = System.Drawing.SystemColors.Control
		Me.progressBar1.Location = New System.Drawing.Point(55, 192)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Size = New System.Drawing.Size(381, 12)
		Me.progressBar1.TabIndex = 4
		Me.progressBar1.Value = 91
		AddHandler Me.progressBar1.Click, AddressOf Me.ProgressBar1Click
		'
		'lblCompania
		'
		Me.lblCompania.BackColor = System.Drawing.Color.Transparent
		Me.lblCompania.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCompania.ForeColor = System.Drawing.Color.Gray
		Me.lblCompania.Location = New System.Drawing.Point(278, 152)
		Me.lblCompania.Name = "lblCompania"
		Me.lblCompania.Size = New System.Drawing.Size(158, 23)
		Me.lblCompania.TabIndex = 5
		Me.lblCompania.Text = "label2"
		Me.lblCompania.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(491, 256)
		Me.Controls.Add(Me.lblCompania)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.lbldireitos)
		Me.Controls.Add(Me.lblversao)
		Me.Controls.Add(Me.lblautor)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Registrator"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
	End Sub
	Private lblCompania As System.Windows.Forms.Label
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private lblautor As System.Windows.Forms.Label
	Private lblversao As System.Windows.Forms.Label
	Private lbldireitos As System.Windows.Forms.Label
End Class
