using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWDBMS;
using DWDBMS_V1;

namespace DoMeasureMSC
{
    public partial class Form1 : Form
    {
       
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        public Form1()
        {
            InitializeComponent();

        }


        private void SelectPage(Form page)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != page)
                {
                    this.ActiveMdiChild.Close();

                }
                //requesterpage = ShowActiveForm(requesterpage, typeof(Requester)) as Requester;
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Fill;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer2.Panel2.Controls.Add(page);

            }
            else
            {
                //requesterpage = ShowActiveForm(requesterpage, typeof(Requester)) as Requester;
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Fill;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer2.Panel2.Controls.Add(page);
            }
        }

        private void buttonBunifuItachi1_Click(object sender, EventArgs e)
        {
            RequesterManagePage requestermanage = new RequesterManagePage();
            SelectPage(requestermanage);
            ////Requester requesterpage = null;

        }

        private void buttonBunifuItachi2_Click(object sender, EventArgs e)
        {
            RequesterSampleManagePage requestersamplemanage = new RequesterSampleManagePage();

            SelectPage(requestersamplemanage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserManagePage usermanage = new UserManagePage();

            SelectPage(usermanage);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StandardManagePage standardmanage = new StandardManagePage();

            SelectPage(standardmanage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecipeManagePage recipemanage = new RecipeManagePage();

            SelectPage(recipemanage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeasureManagePage measuremanage = new MeasureManagePage();

            SelectPage(measuremanage);
        }
    }
}
