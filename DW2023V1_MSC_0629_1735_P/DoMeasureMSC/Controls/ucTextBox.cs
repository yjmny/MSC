using System;
using System.Windows.Forms;

namespace DoOneControl
{
    public partial class ucTextBox : UserControl
    {
        public ucTextBox()
        {
            InitializeComponent();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            textbox.Focus();
        }

        private void UcTextBox_Resize(object sender, EventArgs e)
        {
            if (this.Height >1)
            {
                panel.Margin = new System.Windows.Forms.Padding(left: 3, top: (int)(this.Height / 2), right: 3, bottom: 3);
            }
            else
            {
                panel.Margin = new System.Windows.Forms.Padding(left: 3, top: 0, right: 3, bottom: 3);
            }
        }
  
    }
}
