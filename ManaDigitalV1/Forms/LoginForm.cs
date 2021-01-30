using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV1
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        public LoginForm()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            con.Open();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=royadb;Integrated Security=true";
            con.Open();
            string userid = UserbunifuMaterialTextbox1.Text;
            string password = PassbunifuMaterialTextbox2.Text;
            SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + UserbunifuMaterialTextbox1.Text + "'and password='" + PassbunifuMaterialTextbox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("کاربر" + UserbunifuMaterialTextbox1.Text + "شما با موفقیت وارد شدید");
                DashboardForm df1 = new DashboardForm();

                df1.Show();
                this.Hide();


              
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }
    }
}
