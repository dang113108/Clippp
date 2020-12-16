
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
            this.copyHistory = new System.Windows.Forms.ListBox();
            this.quickPasteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.測試ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.測試111ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.這也是測試ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickPasteMenu.SuspendLayout();
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
            // copyHistory
            // 
            this.copyHistory.FormattingEnabled = true;
            this.copyHistory.ItemHeight = 12;
            this.copyHistory.Items.AddRange(new object[] {
            "Your copy history"});
            this.copyHistory.Location = new System.Drawing.Point(12, 12);
            this.copyHistory.Name = "copyHistory";
            this.copyHistory.Size = new System.Drawing.Size(776, 424);
            this.copyHistory.TabIndex = 0;
            this.copyHistory.SelectedIndexChanged += new System.EventHandler(this.copyHistory_SelectedIndexChanged);
            // 
            // quickPasteMenu
            // 
            this.quickPasteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.測試ToolStripMenuItem,
            this.這也是測試ToolStripMenuItem});
            this.quickPasteMenu.Name = "quickPasteMenu";
            this.quickPasteMenu.Size = new System.Drawing.Size(135, 48);
            // 
            // 測試ToolStripMenuItem
            // 
            this.測試ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.測試111ToolStripMenuItem});
            this.測試ToolStripMenuItem.Name = "測試ToolStripMenuItem";
            this.測試ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.測試ToolStripMenuItem.Text = "測試";
            // 
            // 測試111ToolStripMenuItem
            // 
            this.測試111ToolStripMenuItem.Name = "測試111ToolStripMenuItem";
            this.測試111ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.測試111ToolStripMenuItem.Text = "測試111";
            // 
            // 這也是測試ToolStripMenuItem
            // 
            this.這也是測試ToolStripMenuItem.Name = "這也是測試ToolStripMenuItem";
            this.這也是測試ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.這也是測試ToolStripMenuItem.Text = "這也是測試";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyHistory);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.quickPasteMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WK.Libraries.SharpClipboardNS.SharpClipboard ClipboardListener;
        private System.Windows.Forms.ListBox copyHistory;
        private System.Windows.Forms.ContextMenuStrip quickPasteMenu;
        private System.Windows.Forms.ToolStripMenuItem 測試ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 測試111ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 這也是測試ToolStripMenuItem;
    }
}

