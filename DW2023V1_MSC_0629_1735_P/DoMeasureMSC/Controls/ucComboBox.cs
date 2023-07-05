using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoOneControl
{
    public partial class UserCtrlComboBox : ComboBox
    {
        public UserCtrlComboBox()
        {
            InitializeComponent();
            DrawMode = DrawMode.OwnerDrawFixed;
            ReSize(150);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        private const Int32 CB_SETITEMHEIGHT = 0x153;

        private void SetComboBoxHeight(IntPtr comboBoxHandle, Int32 comboBoxDesiredHeight)
        {
            SendMessage(comboBoxHandle, CB_SETITEMHEIGHT, -1, comboBoxDesiredHeight);
        }

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        const int GWL_STYLE = -16;
        //const int ES_LEFT = 0x0000;
        //const int ES_CENTER = 0x0001;
        //const int ES_RIGHT = 0x0002;
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public int Width { get { return Right - Left; } }
            public int Height { get { return Bottom - Top; } }
        }
        [DllImport("user32.dll")]
        public static extern bool GetComboBoxInfo(IntPtr hWnd, ref COMBOBOXINFO pcbi);

        [StructLayout(LayoutKind.Sequential)]
        public struct COMBOBOXINFO
        {
            public int cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public int stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndEdit;
            public IntPtr hwndList;
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetupEdit();
        }
        //private readonly int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        private void SetupEdit()
        {
            var info = new COMBOBOXINFO();
            info.cbSize = Marshal.SizeOf(info);
            GetComboBoxInfo(this.Handle, ref info);
            var style = GetWindowLong(info.hwndEdit, GWL_STYLE);
            style |= 1;
            SetWindowLong(info.hwndEdit, GWL_STYLE, style);
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();
            var txt = "";
            if (e.Index >= 0)
                txt = GetItemText(Items[e.Index]);
            TextRenderer.DrawText(e.Graphics, txt, Font, e.Bounds,
                ForeColor, TextFormatFlags.Left | TextFormatFlags.HorizontalCenter);
        }

        public void ReSize(int height)
        {
            SetComboBoxHeight(this.Handle, height);
            this.Refresh();
        }
    }
}
