namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemRichTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.myMemoExEdit1 = new WindowsApplication1.MyMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoExEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.ShowCaretInReadOnly = false;
            // 
            // repositoryItemRichTextEdit3
            // 
            this.repositoryItemRichTextEdit3.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit3.Name = "repositoryItemRichTextEdit3";
            this.repositoryItemRichTextEdit3.ShowCaretInReadOnly = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // myMemoExEdit1
            // 
            this.myMemoExEdit1.EditValue = resources.GetString("myMemoExEdit1.EditValue");
            this.myMemoExEdit1.Location = new System.Drawing.Point(12, 12);
            this.myMemoExEdit1.Name = "myMemoExEdit1";
            this.myMemoExEdit1.Properties.AutoHeight = false;
            this.myMemoExEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myMemoExEdit1.Properties.IsHeightAdaptable = true;
            this.myMemoExEdit1.Properties.Memo = this.repositoryItemMemoEdit1;
            this.myMemoExEdit1.Size = new System.Drawing.Size(155, 32);
            this.myMemoExEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 420);
            this.Controls.Add(this.myMemoExEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoExEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit3;
        private MyMemoExEdit myMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}

