'
' Criado por SharpDevelop.
' Usuário: isaac.lopes
' Data: 11/03/2013
' Hora: 22:13
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class frmBv
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
		Me.txtPa = New System.Windows.Forms.TextBox
		Me.btConfirmar = New System.Windows.Forms.Button
		Me.btEditar = New System.Windows.Forms.Button
		Me.lblPa = New System.Windows.Forms.Label
		Me.lblComputador = New System.Windows.Forms.Label
		Me.lblUsuario = New System.Windows.Forms.Label
		Me.lblUsuarioT = New System.Windows.Forms.Label
		Me.lblComputadorT = New System.Windows.Forms.Label
		Me.grpBv = New System.Windows.Forms.GroupBox
		Me.lblAviso = New System.Windows.Forms.Label
		Me.grpBv.SuspendLayout
		Me.SuspendLayout
		'
		'txtPa
		'
		Me.txtPa.Location = New System.Drawing.Point(120, 139)
		Me.txtPa.Name = "txtPa"
		Me.txtPa.Size = New System.Drawing.Size(140, 20)
		Me.txtPa.TabIndex = 0
		Me.txtPa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'btConfirmar
		'
		Me.btConfirmar.Location = New System.Drawing.Point(126, 183)
		Me.btConfirmar.Name = "btConfirmar"
		Me.btConfirmar.Size = New System.Drawing.Size(107, 23)
		Me.btConfirmar.TabIndex = 1
		Me.btConfirmar.Text = "Confirmar"
		Me.btConfirmar.UseVisualStyleBackColor = true
		'
		'btEditar
		'
		Me.btEditar.Location = New System.Drawing.Point(61, 183)
		Me.btEditar.Name = "btEditar"
		Me.btEditar.Size = New System.Drawing.Size(59, 23)
		Me.btEditar.TabIndex = 2
		Me.btEditar.Text = "Editar"
		Me.btEditar.UseVisualStyleBackColor = true
		'
		'lblPa
		'
		Me.lblPa.Location = New System.Drawing.Point(0, 139)
		Me.lblPa.Name = "lblPa"
		Me.lblPa.Size = New System.Drawing.Size(100, 20)
		Me.lblPa.TabIndex = 3
		Me.lblPa.Text = "Número do PA"
		Me.lblPa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblComputador
		'
		Me.lblComputador.Location = New System.Drawing.Point(0, 116)
		Me.lblComputador.Name = "lblComputador"
		Me.lblComputador.Size = New System.Drawing.Size(100, 22)
		Me.lblComputador.TabIndex = 4
		Me.lblComputador.Text = "Computador"
		Me.lblComputador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblUsuario
		'
		Me.lblUsuario.Location = New System.Drawing.Point(0, 95)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(100, 22)
		Me.lblUsuario.TabIndex = 5
		Me.lblUsuario.Text = "Usuário"
		Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblUsuarioT
		'
		Me.lblUsuarioT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblUsuarioT.Location = New System.Drawing.Point(106, 95)
		Me.lblUsuarioT.Name = "lblUsuarioT"
		Me.lblUsuarioT.Size = New System.Drawing.Size(154, 22)
		Me.lblUsuarioT.TabIndex = 6
		Me.lblUsuarioT.Text = "label4"
		Me.lblUsuarioT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblComputadorT
		'
		Me.lblComputadorT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblComputadorT.Location = New System.Drawing.Point(106, 116)
		Me.lblComputadorT.Name = "lblComputadorT"
		Me.lblComputadorT.Size = New System.Drawing.Size(154, 22)
		Me.lblComputadorT.TabIndex = 7
		Me.lblComputadorT.Text = "label5"
		Me.lblComputadorT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'grpBv
		'
		Me.grpBv.Controls.Add(Me.lblAviso)
		Me.grpBv.Location = New System.Drawing.Point(12, 12)
		Me.grpBv.Name = "grpBv"
		Me.grpBv.Size = New System.Drawing.Size(268, 80)
		Me.grpBv.TabIndex = 8
		Me.grpBv.TabStop = false
		Me.grpBv.Text = "Seja Bem Vindo"
		'
		'lblAviso
		'
		Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblAviso.Location = New System.Drawing.Point(8, 16)
		Me.lblAviso.Name = "lblAviso"
		Me.lblAviso.Size = New System.Drawing.Size(254, 61)
		Me.lblAviso.TabIndex = 9
		Me.lblAviso.Text = "label6"
		Me.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'frmBv
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(292, 223)
		Me.Controls.Add(Me.grpBv)
		Me.Controls.Add(Me.lblComputadorT)
		Me.Controls.Add(Me.lblUsuarioT)
		Me.Controls.Add(Me.lblUsuario)
		Me.Controls.Add(Me.lblComputador)
		Me.Controls.Add(Me.lblPa)
		Me.Controls.Add(Me.btEditar)
		Me.Controls.Add(Me.btConfirmar)
		Me.Controls.Add(Me.txtPa)
		Me.MaximizeBox = false
		Me.MaximumSize = New System.Drawing.Size(308, 259)
		Me.MinimizeBox = false
		Me.MinimumSize = New System.Drawing.Size(308, 259)
		Me.Name = "frmBv"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Identificação - Registrator"
		AddHandler Load, AddressOf Me.FrmBvLoad
		Me.grpBv.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtPa As System.Windows.Forms.TextBox
	Private btConfirmar As System.Windows.Forms.Button
	Private btEditar As System.Windows.Forms.Button
	Private lblPa As System.Windows.Forms.Label
	Private lblComputador As System.Windows.Forms.Label
	Private lblUsuario As System.Windows.Forms.Label
	Private lblUsuarioT As System.Windows.Forms.Label
	Private lblComputadorT As System.Windows.Forms.Label
	Private grpBv As System.Windows.Forms.GroupBox
	Private lblAviso As System.Windows.Forms.Label
End Class
