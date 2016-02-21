'
' Criado por SharpDevelop.
' Usuário: isaac.lopes
' Data: 11/03/2013
' Hora: 22:13
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Partial Class frmBv
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	

	
	Sub FrmBvLoad(sender As Object, e As EventArgs)
		
		lblAviso.Text = "Insira o numero da PA, esse numero será associado ao nome do computador"
		lblComputadorT.Text = splash.Computador
		lblUsuarioT.Text = splash.User
		
		
	End Sub
	
	
End Class
