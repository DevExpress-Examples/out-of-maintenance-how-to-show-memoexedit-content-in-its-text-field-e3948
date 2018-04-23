using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{

    public class MyMemoExEdit : MemoExEdit
    {
        static MyMemoExEdit()
        {
            RepositoryItemMyMemoExEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemMyMemoExEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyMemoExEdit Properties
        {
            get { return base.Properties as RepositoryItemMyMemoExEdit; }
        }
    }
}
