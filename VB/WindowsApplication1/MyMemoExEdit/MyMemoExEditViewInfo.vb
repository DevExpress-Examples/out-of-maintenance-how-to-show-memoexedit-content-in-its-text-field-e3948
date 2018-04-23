Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Friend Class MyMemoExEditViewInfo
		Inherits MemoExEditViewInfo
		Implements IHeightAdaptable
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub
		Public Function CalcHeight(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal width As Integer) As Integer Implements IHeightAdaptable.CalcHeight
			'RepositoryItemMyMemoExEdit ri = (Item as RepositoryItemMyMemoExEdit);
			'if (!ri.IsHeightAdaptable) return 0;
			'MemoEditViewInfo vi = new MemoEditViewInfo(ri.Memo);
			'vi.EditValue = this.EditValue;
			'return vi.CalcMinHeight(width) + 6;
			Return 0
		End Function
	End Class
End Namespace
