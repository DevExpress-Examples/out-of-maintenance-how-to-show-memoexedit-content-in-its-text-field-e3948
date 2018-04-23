using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using System.Drawing;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyMemoExEditPainter : BlobBaseEditPainter
    {

        public MyMemoExEditPainter()
        {

        }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            base.DrawContent(info);
        }

        protected override void DrawGlyph(ControlGraphicsInfoArgs info)
        {
            //base.DrawGlyph(info);
        }

        protected override void DrawText(ControlGraphicsInfoArgs info)
        {
            MemoEditViewInfo vi = GetViewInfo(info);
            ControlGraphicsInfoArgs args = new ControlGraphicsInfoArgs(vi,info.Cache,vi.Bounds);
            vi.Painter.Draw(args);
            //info.Graphics.FillRectangle(Brushes.Red, vi.Bounds);
            //RichTextEditPainter.DrawRTF(GetViewInfo(info), info.Cache);
        }
        private MemoEditViewInfo GetViewInfo(ControlGraphicsInfoArgs info)
        {
            RepositoryItemMyMemoExEdit ri = (info.ViewInfo as ButtonEditViewInfo).Item as RepositoryItemMyMemoExEdit;
            MemoEditViewInfo vi = new MemoEditViewInfo(ri.Memo);
            Rectangle rec = info.ViewInfo.ContentRect;
           //rec.Offset(0, -2);
           // rec.Inflate(0,2);
            vi.Bounds = rec;
            vi.EditValue = info.ViewInfo.DisplayText;
            vi.DefaultBorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            vi.CalcViewInfo(info.Graphics);
            //vi.Item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //vi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            return vi;

        }
    }

}
