using BusinessEntity;
using dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV1.UserControls
{
    public partial class MakeGroupUserControl : UserControl
    {

        List<person> selectedPersons = new List<person>();
        List<person> pList = new List<person>();
        public MakeGroupUserControl()
        {
            InitializeComponent();
        }
        void register(group g)
        {
            phbContext db1 = new phbContext();
            if (g.groupName.Length >= 2 && search(g) != true)
            {
                db1.groups.Add(new group { groupName = g.groupName, persons = g.persons });

                db1.SaveChanges();
                MessageBox.Show("ثبت شد" + GroupNamebunifuMaterialTextbox1.Text + "گروه");

                NewGroupMemberlistBox1.ClearSelected();

            }
            else
            {
                MessageBox.Show("امکان ثبت  وجود ندارد");
            }
        }
        bool search(group g)
        {
            phbContext phb = new phbContext();
            return phb.groups.Any(i => i.groupName.Contains(g.groupName));
        }
        private void MakeGroupUserControl_Load(object sender, EventArgs e)
        {
            // p100 = new person_Bll().ReadAll();
            List<person> pList = new List<person>();
            phbContext db = new phbContext();
            pList = db.persons.ToList();
        }

        private void GroupListbutton1_Click(object sender, EventArgs e)
        {
            GroupListUserControl gl1 = new GroupListUserControl();
            ((DashboardForm)Application.OpenForms["DashboardForm"]).Master.Controls.Clear();
            ((DashboardForm)Application.OpenForms["DashboardForm"]).Master.Controls.Add(gl1);

        }

        private void NewGroupMemberlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewGroupMemberlistBox1_Click(object sender, EventArgs e)
        {
            var pg1 = (person)NewGroupMemberlistBox1.SelectedItem;

            MemberslistBox1.DataSource = new List<person>();
            pList.Add(pg1);
            MemberslistBox1.DataSource = pList;
            selectedPersons = selectedPersons.Where(w => w.Id != pg1.Id).ToList();
            NewGroupMemberlistBox1.DataSource = selectedPersons;
        }

        private void SubmitGroupbutton2_Click(object sender, EventArgs e)
        {
            register(
            new group
            {
                groupName = GroupNamebunifuMaterialTextbox1.Text,
                persons = string.Join(",", selectedPersons.Select(s => s.Id.ToString()).ToArray())

            }

        ); ;
        }

        private void MemberslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pg = (person)MemberslistBox1.SelectedItem;
            NewGroupMemberlistBox1.DataSource = new List<person>();

            selectedPersons.Add(pg);
            NewGroupMemberlistBox1.DataSource = selectedPersons;
            pList = pList.Where(w => w.Id != pg.Id).ToList();
            MemberslistBox1.DataSource = pList;
        }
    }
}
