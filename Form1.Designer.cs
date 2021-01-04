
namespace Clippp
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClipboardListener = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
            this.quickPasteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folderSelector = new System.Windows.Forms.ListBox();
            this.itemSelector = new System.Windows.Forms.ListBox();
            this.copyTextEditor = new System.Windows.Forms.TextBox();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeFolderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.copyHistory = new System.Windows.Forms.ListBox();
            this.renameFolderButton = new System.Windows.Forms.Button();
            this.renameItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClipboardListener
            // 
            this.ClipboardListener.MonitorClipboard = true;
            this.ClipboardListener.ObservableFormats.All = false;
            this.ClipboardListener.ObservableFormats.Files = false;
            this.ClipboardListener.ObservableFormats.Images = false;
            this.ClipboardListener.ObservableFormats.Others = false;
            this.ClipboardListener.ObservableFormats.Texts = true;
            this.ClipboardListener.ObserveLastEntry = true;
            this.ClipboardListener.Tag = null;
            this.ClipboardListener.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.ClipboardListener_ClipboardChanged);
            // 
            // quickPasteMenu
            // 
            this.quickPasteMenu.Name = "quickPasteMenu";
            this.quickPasteMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // folderSelector
            // 
            this.folderSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderSelector.FormattingEnabled = true;
            this.folderSelector.ItemHeight = 16;
            this.folderSelector.Location = new System.Drawing.Point(12, 12);
            this.folderSelector.Name = "folderSelector";
            this.folderSelector.Size = new System.Drawing.Size(120, 400);
            this.folderSelector.TabIndex = 1;
            this.folderSelector.SelectedIndexChanged += new System.EventHandler(this.folderSelector_SelectedIndexChanged);
            // 
            // itemSelector
            // 
            this.itemSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemSelector.FormattingEnabled = true;
            this.itemSelector.ItemHeight = 16;
            this.itemSelector.Location = new System.Drawing.Point(138, 12);
            this.itemSelector.Name = "itemSelector";
            this.itemSelector.Size = new System.Drawing.Size(149, 400);
            this.itemSelector.TabIndex = 2;
            this.itemSelector.SelectedIndexChanged += new System.EventHandler(this.itemSelector_SelectedIndexChanged);
            // 
            // copyTextEditor
            // 
            this.copyTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyTextEditor.Location = new System.Drawing.Point(293, 12);
            this.copyTextEditor.Multiline = true;
            this.copyTextEditor.Name = "copyTextEditor";
            this.copyTextEditor.Size = new System.Drawing.Size(415, 400);
            this.copyTextEditor.TabIndex = 3;
            this.copyTextEditor.Leave += new System.EventHandler(this.copyTextEditor_FocusLeave);
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(12, 422);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(30, 23);
            this.addFolderButton.TabIndex = 4;
            this.addFolderButton.Text = " +";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Enabled = false;
            this.addItemButton.Location = new System.Drawing.Point(138, 422);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(30, 23);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeFolderButton
            // 
            this.removeFolderButton.Enabled = false;
            this.removeFolderButton.Location = new System.Drawing.Point(48, 422);
            this.removeFolderButton.Name = "removeFolderButton";
            this.removeFolderButton.Size = new System.Drawing.Size(30, 23);
            this.removeFolderButton.TabIndex = 6;
            this.removeFolderButton.Text = " -";
            this.removeFolderButton.UseVisualStyleBackColor = true;
            this.removeFolderButton.Click += new System.EventHandler(this.removeFolderButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Location = new System.Drawing.Point(174, 422);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(30, 23);
            this.removeItemButton.TabIndex = 7;
            this.removeItemButton.Text = "-";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // copyHistory
            // 
            this.copyHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyHistory.FormattingEnabled = true;
            this.copyHistory.ItemHeight = 16;
            this.copyHistory.Items.AddRange(new object[] {
            "Your copy history"});
            this.copyHistory.Location = new System.Drawing.Point(723, 12);
            this.copyHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyHistory.Name = "copyHistory";
            this.copyHistory.Size = new System.Drawing.Size(229, 400);
            this.copyHistory.TabIndex = 0;
            this.copyHistory.SelectedIndexChanged += new System.EventHandler(this.copyHistory_SelectedIndexChanged);
            // 
            // renameFolderButton
            // 
            this.renameFolderButton.Enabled = false;
            this.renameFolderButton.Location = new System.Drawing.Point(84, 422);
            this.renameFolderButton.Name = "renameFolderButton";
            this.renameFolderButton.Size = new System.Drawing.Size(30, 23);
            this.renameFolderButton.TabIndex = 8;
            this.renameFolderButton.Text = " R";
            this.renameFolderButton.UseVisualStyleBackColor = true;
            // 
            // renameItemButton
            // 
            this.renameItemButton.Enabled = false;
            this.renameItemButton.Location = new System.Drawing.Point(210, 422);
            this.renameItemButton.Name = "renameItemButton";
            this.renameItemButton.Size = new System.Drawing.Size(30, 23);
            this.renameItemButton.TabIndex = 9;
            this.renameItemButton.Text = "R";
            this.renameItemButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.renameItemButton);
            this.Controls.Add(this.renameFolderButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.removeFolderButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addFolderButton);
            this.Controls.Add(this.copyTextEditor);
            this.Controls.Add(this.itemSelector);
            this.Controls.Add(this.folderSelector);
            this.Controls.Add(this.copyHistory);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Clippp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WK.Libraries.SharpClipboardNS.SharpClipboard ClipboardListener;
        private System.Windows.Forms.ContextMenuStrip quickPasteMenu;
        private System.Windows.Forms.ListBox folderSelector;
        private System.Windows.Forms.ListBox itemSelector;
        private System.Windows.Forms.TextBox copyTextEditor;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeFolderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.ListBox copyHistory;
        private System.Windows.Forms.Button renameFolderButton;
        private System.Windows.Forms.Button renameItemButton;
    }
}

