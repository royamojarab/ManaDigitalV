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
    public partial class SearchUserControl : UserControl
    {
        List<person> p100 = new List<person>();
        List<person> pList = new List<person>();
        person selectedPerson = new person();
        personPhone selectedPersonPhone = new personPhone();
        personDetail selectedPersonDetail = new personDetail();

        public SearchUserControl()
        {
            InitializeComponent();
        }
        bool search(person p)
        {
            phbContext phb = new phbContext();
            return phb.persons.Any(i => i.fullName.Contains(p.fullName));
        }
        void register()
        {
            phbContext phb = new phbContext();

        }

        private void SearchUserControl_Load(object sender, EventArgs e)
        {


            // p100 = new person_Bll().ReadAll();
            //List<person> pList = new List<person>();
            //phbContext db = new phbContext();
            //pList = db.persons.ToList();
            //SearchlistBox1.DataSource = pList;
        }

        private void NamebunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {


        }

        private void SearchbunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            List<person> searchList = new List<person>();
            phbContext db1 = new phbContext();

            var q = from item in db1.persons where item.fullName.Contains(SearchbunifuMaterialTextbox1.Text) select item;
            SearchlistBox1.DataSource = q.ToList();
            //bunifuCustomDataGrid1.DataSource = null;
            //bunifuCustomDataGrid1.DataSource = q.ToList();
        }

        private void SearchlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamebunifuMaterialTextbox1.DataBindings.Clear();
            RelationbunifuMaterialTextbox1.DataBindings.Clear();
            parametercomboBox1.DataBindings.Clear();
            PhonebunifuMaterialTextbox1.DataBindings.Clear();
            AddressbunifuMaterialTextbox1.DataBindings.Clear();
            AgenumericUpDown1.DataBindings.Clear();

            phbContext ph = new phbContext();



            selectedPerson = (person)SearchlistBox1.SelectedItem;
            selectedPersonPhone = ph.phopersonPhones.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();
            selectedPersonDetail = ph.personDetails.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();

            NamebunifuMaterialTextbox1.DataBindings.Add("Text", selectedPerson, "fullName");
            AgenumericUpDown1.DataBindings.Add("Text", selectedPerson, "age");
            parametercomboBox1.DataBindings.Add("Text", selectedPerson, "relation");
            RelationbunifuMaterialTextbox1.DataBindings.Add("Text", selectedPersonDetail, "parameter");
            PhonebunifuMaterialTextbox1.DataBindings.Add("Text", selectedPersonPhone, "phoneNumber");
            AddressbunifuMaterialTextbox1.DataBindings.Add("Text", selectedPersonDetail, "address");

        }

        private void SaveEditbutton2_Click(object sender, EventArgs e)
        {
            phbContext phb = new phbContext();
            phb.persons.Attach(selectedPerson);
            phb.Entry(selectedPerson).State = System.Data.Entity.EntityState.Modified;
            var result = phb.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("تغییرات اعمال شد");
            }
            else
                MessageBox.Show("ثبت تغییرات با مشکل مواجه شد");
        }

        private void ChooseCVbutton2_Click(object sender, EventArgs e)
        {

        }

        private void CVbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
