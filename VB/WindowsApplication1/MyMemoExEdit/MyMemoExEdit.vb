Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1

	Public Class MyMemoExEdit
		Inherits MemoExEdit
        Shared Sub New()
            RepositoryItemMyMemoExEdit.Register()
        End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyMemoExEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyMemoExEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyMemoExEdit)
			End Get
		End Property
    End Class
End Namespace
