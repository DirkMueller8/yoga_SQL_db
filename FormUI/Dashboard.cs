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
        List<Session> session = new List<Session>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            lstSessionsFound.DataSource = session;
            lstSessionsFound.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            session = db.GetSessions(txtDateQuery.Text);
            UpdateBinding();
        }

        //private void insertRecordButton_Click(object sender, EventArgs e)
        //{
        //    DataAccess db = new DataAccess();
        //    bool b_1_1 = txtS_1_1.Text == "1";
        //    db.Yoga_Insert(Convert.ToDateTime(txtDateDisplay.Text), txtS_1_2.Text, txtS_1_2.Text,
        //        txtS_1_3.Text, txtS_2_1.Text, txtS_2_2.Text, txtS_2_3.Text);
        //    txtDateDisplay.Text = "";
        //    txtS_1_1.Text = "";
        //    txtS_1_2.Text = "";
        //    txtS_1_3.Text = "";
        //}

        private void insertRecordButton_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            //bool b_1_1 = txtS_1_1.Text == "1";
            db.Yoga_Insert(Convert.ToDateTime(txtDateDisplay.Text), txtS_1_2.Text, txtS_1_2.Text,
                txtS_1_3.Text, txtS_2_1.Text, txtS_2_2.Text, txtS_2_3.Text);
            txtDateDisplay.Text = "";
            txtS_1_1.Text = "";
            txtS_1_2.Text = "";
            txtS_1_3.Text = "";
            txtS_2_1.Text = "";
            txtS_2_2.Text = "";
            txtS_2_3.Text = "";
        }
    }
}
