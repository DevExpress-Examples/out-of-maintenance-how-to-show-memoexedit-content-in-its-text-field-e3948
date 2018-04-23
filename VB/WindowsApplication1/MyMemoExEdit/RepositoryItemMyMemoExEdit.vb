Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1
	<UserRepositoryItem("Register"), System.ComponentModel.DesignerCategory("")> _
	Public Class RepositoryItemMyMemoExEdit
		Inherits RepositoryItemMemoExEdit
		Private _Memo As New RepositoryItemMemoEdit()
		Public Property Memo() As RepositoryItemMemoEdit
			Get
				Return _Memo
			End Get
			Set(ByVal value As RepositoryItemMemoEdit)
				_Memo = value
			End Set
		End Property

		Private _isHeightAdaptable As Boolean
		Public Property IsHeightAdaptable() As Boolean
			Get
				Return _isHeightAdaptable
			End Get
			Set(ByVal value As Boolean)
				_isHeightAdaptable = value
			End Set

		End Property

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			IsHeightAdaptable = True
			Memo.BorderStyle = BorderStyles.NoBorder
		End Sub

		Friend Const EditorName As String = "MyMemoExEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyMemoExEdit), GetType(RepositoryItemMyMemoExEdit), GetType(MyMemoExEditViewInfo), New MyMemoExEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property


		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Memo.Assign((TryCast(item, RepositoryItemMyMemoExEdit)).Memo)
		End Sub


	End Class
End Namespace
