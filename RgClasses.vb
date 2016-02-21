'
' Criado por SharpDevelop.
' Usuário: isaac.lopes
' Data: 11/03/2013
' Hora: 22:45
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'


Public Partial Class RgDados

	'DECLARAÇÃO DAS PROPRIEDADES DA CLASSE
	'Propriedade PA do posto de atendimento atual, Dados de entrada e saida
	Public Dim m_pa As String
	Public Property Pa() As String
		Get
			Return m_pa
		End Get
		Set
			m_pa = value
		End Set
	End Property
	
	
	'Propriedade Computador do atual sendo utilizado, Dados de entrada e saida
	Public Dim m_computador As String
	Public Property Computador() As String
		Get
			Return m_computador
		End Get
		Set
			m_computador = value
		End Set
	End Property
	
	
	'Propriedade USER do usuario "Logado", Dados de entrada e saida
	Public Dim m_user As String
	Public Property User() As String
		Get
			Return m_user
		End Get
		Set
			m_user = value
		End Set
	End Property
	'Propriedade USER
	
	
End Class
