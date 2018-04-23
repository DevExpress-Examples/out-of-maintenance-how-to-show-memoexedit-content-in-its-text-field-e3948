Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyMemoExEditPainter
		Inherits BlobBaseEditPainter

		Public Sub New()

		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			MyBase.DrawContent(info)
		End Sub

		Protected Overrides Sub DrawGlyph(ByVal info As ControlGraphicsInfoArgs)
			'base.DrawGlyph(info);
		End Sub

		Protected Overrides Sub DrawText(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As MemoEditViewInfo = GetViewInfo(info)
			Dim args As New ControlGraphicsInfoArgs(vi,info.Cache,vi.Bounds)
			vi.Painter.Draw(args)
			'info.Graphics.FillRectangle(Brushes.Red, vi.Bounds);
			'RichTextEditPainter.DrawRTF(GetViewInfo(info), info.Cache);
		End Sub
		Private Function GetViewInfo(ByVal info As ControlGraphicsInfoArgs) As MemoEditViewInfo
			Dim ri As RepositoryItemMyMemoExEdit = TryCast((TryCast(info.ViewInfo, ButtonEditViewInfo)).Item, RepositoryItemMyMemoExEdit)
			Dim vi As New MemoEditViewInfo(ri.Memo)
			Dim rec As Rectangle = info.ViewInfo.ContentRect
		   'rec.Offset(0, -2);
		   ' rec.Inflate(0,2);
			vi.Bounds = rec
			vi.EditValue = info.ViewInfo.DisplayText
			vi.DefaultBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			vi.CalcViewInfo(info.Graphics)
			'vi.Item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			'vi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			Return vi

		End Function
	End Class

End Namespace
