using BA.CarWashingApp.Entity.Entities;
using BA.CarWashingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA.CarWashingApp.UI
{
    public partial class FormMainMenu : Form
    {
        SystemUser su = new SystemUser();


        public FormMainMenu()
        {
            InitializeComponent();
        }



        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if (su.Role == RoleType.Employee)
            {
                btnEmployees.Visible = false;
                btnAppUser.Visible = false;
            }

        }

        private void btnVR_Click(object sender, EventArgs e)
        {
            Vehicle_Registration vehicle_Registration = new Vehicle_Registration();
            vehicle_Registration.Show();
        }

        private void btnWashStatus_Click(object sender, EventArgs e)
        {
            Wash_Status wash_Status = new Wash_Status();
            wash_Status.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void btnAppUser_Click(object sender, EventArgs e)
        {
            App_User app_user = new App_User();
            app_user.Show();

        }

        private void btnAppSettings_Click(object sender, EventArgs e)
        {
            App_Settings app_settings = new App_Settings();
            app_settings.Show();
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
