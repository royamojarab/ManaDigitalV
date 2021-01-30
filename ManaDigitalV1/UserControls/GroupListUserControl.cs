using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using dataAccess;

namespace ManaDigitalV1.UserControls
{
    public partial class GroupListUserControl : UserControl
    {
        public GroupListUserControl()
        {
            InitializeComponent();
        }
        List<group> g100 = new List<group>();
        group selectedGroup = new group();
        List<person> selectedGroupPersons = new List<person>();

        private void GroupListUserControl_Load(object sender, EventArgs e)
        {
            //List<group> pList = new List<group>();
            //phbContext db = new phbContext();
            //pList = db.groups.ToList();
            //GroupslistBox1.DataSource = pList;
        }

        private void GroupslistBox1_Click(object sender, EventArgs e)
        {
            selectedGroup = (group)GroupslistBox1.SelectedItem;
            List<int> ids = selectedGroup.persons.Split(',').Select(s => Convert.ToInt32(s)).ToList();
            phbContext phb1 = new phbContext();

            selectedGroupPersons = phb1.persons.Where(w => ids.Contains(w.Id)).ToList();
            GroupMemberslistBox2.DataSource = selectedGroupPersons;
        }
    }
}
