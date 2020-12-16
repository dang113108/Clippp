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

namespace Clippp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void ClipboardListener_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            var lastCopy = copyHistory.Items[0];
            Console.WriteLine(lastCopy);
            var copyText = Clipboard.GetText();
            if (!lastCopy.Equals(copyText))
            {
                copyHistory.Items.Insert(0, Clipboard.GetText());
            }
        }

        private void copyHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(copyHistory.SelectedItem.ToString());
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
                            //QuickMenuForm form = new QuickMenuForm();
                            //form.Show();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.Alt, Keys.V);
        }
    }
}
