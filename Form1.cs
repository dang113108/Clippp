using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Clippp
{
    public partial class mainForm : Form
    {

        ContextMenuStrip menu = new ContextMenuStrip();
        ToolStripMenuItem item, submenu;

        public mainForm()
        {
            InitializeComponent();
        }

        private void ClipboardListener_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            var lastCopy = copyHistory.Items[0];
            var copyText = Clipboard.GetText();

            if (false)
            //if (!lastCopy.Equals(copyText))
            {
                if (copyHistory.Items.Count > 10)
                {
                    quickPasteMenu.Items.RemoveAt(9);
                }
                submenu = new ToolStripMenuItem();
                submenu.Text = copyText;
                submenu.Click += new EventHandler(item_Click);
                copyHistory.Items.Insert(0, copyText);
                quickPasteMenu.Items.Insert(0, submenu);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;
            Clipboard.SetText(clickedItem.Text);
        }

        void subitem_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;
            string categoryText = clickedItem.OwnerItem.Text;
            string itemText = clickedItem.Text;
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string currentItem = Path.Combine(projectPath, $"tmp_folder\\{categoryText}\\{ itemText}.txt");
            string text = File.ReadAllText(currentItem);
            Clipboard.SetText(text);
        }

        private void copyHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (copyHistory.SelectedItem != null)
            {
                Clipboard.SetText(copyHistory.SelectedItem.ToString());
            }
        }

        class HotKey
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

            [Flags()]
            public enum KeyModifiers
            {
                None = 0,
                Alt = 1,
                Ctrl = 2,
                Shift = 4,
                WindowsKey = 8
            }
        }

        private void FrmSale_Leave(object sender, EventArgs e)
        {
            HotKey.UnregisterHotKey(Handle, 100);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            var mouseX = Cursor.Position.X;
                            var mouseY = Cursor.Position.Y;
                            quickPasteMenu.Show(mouseX, mouseY);
                            quickPasteMenu.Focus();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            string categoryName = "Category Name";
            if (InputBox("New Category", "New category name:", ref categoryName) == DialogResult.OK)
            {
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string folderName = Path.Combine(projectPath, "tmp_folder");
                Directory.CreateDirectory(folderName);
                folderName = Path.Combine(folderName, categoryName);
                Directory.CreateDirectory(folderName);
                folderSelector.Items.Add(categoryName);
                quickPasteMenu.Items.Add(categoryName);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Alt, Keys.V);
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string tmpFolder = Path.Combine(projectPath, "tmp_folder");
            Directory.CreateDirectory(tmpFolder);
            string[] categoryFolderList = Directory.GetFileSystemEntries(tmpFolder, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var folder in categoryFolderList)
            {
                FileInfo info = new FileInfo(folder);
                folderSelector.Items.Add(info.Name);
                submenu = new ToolStripMenuItem();
                submenu.Text = info.Name;

                string categoryFolder = Path.Combine(tmpFolder, info.Name);
                string[] itemList = Directory.GetFileSystemEntries(categoryFolder, "*.txt", SearchOption.TopDirectoryOnly);
                foreach (var txtTtem in itemList)
                {
                    FileInfo txt_info = new FileInfo(txtTtem);
                    string txtName = txt_info.Name;
                    int txtLength = txtName.Length;
                    string originName = txtName.Substring(0, txtLength - 4);
                    item = new ToolStripMenuItem();
                    item.Text = originName;
                    item.Click += new EventHandler(subitem_Click);
                    submenu.DropDownItems.Add(item);
                }
                quickPasteMenu.Items.Add(submenu);
            }
        }

        private void folderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (folderSelector.SelectedItem != null)
            {
                addItemButton.Enabled = true;
                itemSelector.Items.Clear();
                copyTextEditor.Clear();
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string currentFolder = Path.Combine(projectPath, "tmp_folder\\" + folderSelector.SelectedItem.ToString());
                string[] txtList = Directory.GetFileSystemEntries(currentFolder, "*.txt", SearchOption.TopDirectoryOnly);
                foreach (var txt in txtList)
                {
                    FileInfo info = new FileInfo(txt);
                    string txtName = info.Name;
                    int txtLength = txtName.Length;
                    itemSelector.Items.Add(txtName.Substring(0, txtLength - 4));
                }
            }
        }

        private void itemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemSelector.SelectedItem != null)
            {
                copyTextEditor.Clear();
                string folderName = folderSelector.SelectedItem.ToString();
                string itemName = itemSelector.SelectedItem.ToString();
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string currentItem = Path.Combine(projectPath, $"tmp_folder\\{folderName}\\{ itemName}.txt");
                string text = File.ReadAllText(currentItem);
                copyTextEditor.Text = text;
            }
         }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string itemName = "Item Name";
            if (InputBox("New Item", "New item name:", ref itemName) == DialogResult.OK)
            {
                string folderName = folderSelector.SelectedItem.ToString();
                string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string itemPath = Path.Combine(projectPath, $"tmp_folder\\{folderName}\\{itemName}.txt");
                File.Create(itemPath);
                itemSelector.Items.Add(itemName);
                foreach (ToolStripMenuItem subitem in quickPasteMenu.Items)
                {
                    if (subitem.Text == folderName)
                    {
                        item = new ToolStripMenuItem();
                        item.Text = itemName;
                        item.Click += new EventHandler(subitem_Click);
                        subitem.DropDownItems.Add(item);
                        quickPasteMenu.Items.Add(submenu);
                        break;
                    }
                }
            }
        }

        private void copyTextEditor_FocusLeave(object sender, EventArgs e)
        {
            string folderName = folderSelector.SelectedItem.ToString();
            string itemName = itemSelector.SelectedItem.ToString();
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string currentItem = Path.Combine(projectPath, $"tmp_folder\\{folderName}\\{ itemName}.txt");
            File.WriteAllText(currentItem, copyTextEditor.Text);
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }

}
