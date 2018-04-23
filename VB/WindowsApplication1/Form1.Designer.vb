Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.repositoryItemRichTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
            Me.repositoryItemRichTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
            Me.myMemoExEdit1 = New WindowsApplication1.MyMemoExEdit
            CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myMemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'repositoryItemRichTextEdit2
            '
            Me.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html
            Me.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2"
            Me.repositoryItemRichTextEdit2.ShowCaretInReadOnly = False
            '
            'repositoryItemRichTextEdit3
            '
            Me.repositoryItemRichTextEdit3.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html
            Me.repositoryItemRichTextEdit3.Name = "repositoryItemRichTextEdit3"
            Me.repositoryItemRichTextEdit3.ShowCaretInReadOnly = False
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'myMemoExEdit1
            '
            Me.myMemoExEdit1.EditValue = resources.GetString("myMemoExEdit1.EditValue")
            Me.myMemoExEdit1.Location = New System.Drawing.Point(12, 12)
            Me.myMemoExEdit1.Name = "myMemoExEdit1"
            Me.myMemoExEdit1.Properties.AutoHeight = False
            Me.myMemoExEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.myMemoExEdit1.Properties.IsHeightAdaptable = True
            Me.myMemoExEdit1.Properties.Memo = Me.repositoryItemMemoEdit1
            Me.myMemoExEdit1.Size = New System.Drawing.Size(155, 34)
            Me.myMemoExEdit1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(579, 420)
            Me.Controls.Add(Me.myMemoExEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myMemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private repositoryItemRichTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private repositoryItemRichTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private myMemoExEdit1 As MyMemoExEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
	End Class
End Namespace

