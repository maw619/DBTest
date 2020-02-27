using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> persons;

        public Dashboard()
        {
            InitializeComponent();
            peopleFoundListBox.DataSource = persons;
            peopleFoundListBox.DisplayMember = "toString";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            persons = new List<Person>();
            DataAccess db = new DataAccess();
            persons =  db.GetPeople(lastNameText.Text);
            peopleFoundListBox.DataSource = persons;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
    }
}
