using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{
    [UserRepositoryItem("Register")]

    [System.ComponentModel.DesignerCategory("")]
    public class RepositoryItemMyMemoExEdit : RepositoryItemMemoExEdit
    {
        private RepositoryItemMemoEdit _Memo = new RepositoryItemMemoEdit();
        public RepositoryItemMemoEdit Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        private bool _isHeightAdaptable;
        public bool IsHeightAdaptable {
            get { return _isHeightAdaptable; }
            set { _isHeightAdaptable = value; }

        }

        static RepositoryItemMyMemoExEdit()
        {
            Register();
        }
        public RepositoryItemMyMemoExEdit() { 
            IsHeightAdaptable = true;
            Memo.BorderStyle = BorderStyles.NoBorder;
        }

        internal const string EditorName = "MyMemoExEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyMemoExEdit),
                typeof(RepositoryItemMyMemoExEdit), typeof(MyMemoExEditViewInfo),
                new MyMemoExEditPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }


        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            Memo.Assign((item as RepositoryItemMyMemoExEdit).Memo);
        }


    }
}
