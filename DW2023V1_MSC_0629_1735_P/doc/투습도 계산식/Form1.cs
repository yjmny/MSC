using KSK0594_20210701;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfKSK0594_20210701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Console.WriteLine(CircleArea(70));

            //while (true)
            //{
                //Console.WriteLine(P(0.1, 0.05, 70));
                Console.WriteLine(WVPClass.CalcTest(43, 34, 70));
            //}
        }

        
    }
}
