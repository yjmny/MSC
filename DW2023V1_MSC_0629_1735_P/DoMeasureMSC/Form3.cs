using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoMeasureMSC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            ucTextBox2.panel.BackColor = Color.White;
            ucTextBox2.textbox.BackColor= Color.Red;

            ucTextBox2.Size = new System.Drawing.Size(100, 200);
        }

        private void ucTextBox2_Load(object sender, EventArgs e)
        {

        }
    }
}
