using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    class MyMemoExEditViewInfo : MemoExEditViewInfo
    {
        public MyMemoExEditViewInfo(RepositoryItem item) : base(item) { }
    }
}
