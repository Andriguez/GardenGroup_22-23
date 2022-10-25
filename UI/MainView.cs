using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MongoDB.Driver;
using Model;
using Logic;


namespace UI
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }
        
        private void ShowPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                UserManagement_pnl.Hide();

                Dashboard_pnl.Dock = DockStyle.Fill;
                Dashboard_pnl.Show();

            } else if (panelName == "UserManagement")
            {
                Dashboard_pnl.Hide();

                UserManagement_pnl.Dock = DockStyle.Fill;
                UserManagement_pnl.Show();

                Databases dbs = new Databases();
                foreach (var db in dbs.Get_All_Databases())
                    User_lstView.Items.Add(db.name);
            }
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("UserManagement");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void AddUser_bttn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
