using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            Userpanel.Controls.Clear();
            Userpanel.Controls.Add(registerUserControl1);

            //Slidepanel1.Top = Registerbutton.Top;
            //Slidepanel1.Height = Registerbutton.Height;

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Slidepanel1.Top = Searchbutton.Top;
            Slidepanel1.Height = Searchbutton.Height;
            searchUserControl1.Show();
        }

        private void Groupsbutton_Click(object sender, EventArgs e)
        {
            Slidepanel1.Top = Groupsbutton.Top;
            Slidepanel1.Height = Groupsbutton.Height;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
