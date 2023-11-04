using BA.CarWashingApp.BLL.Managers;
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
    public partial class FormLoginMenu : Form
    {

        public FormMainMenu FormMainMenu;



        public FormLoginMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            

            string username = "emp";
            string password = "emp";
            if (tboxUserName.Text != "Admin")
            {
                FormMainMenu formMainMenu = new FormMainMenu();
                
                Employees empform = new Employees();
                empform.Hide();
            }
            if (tboxUserName.Text == username )
            {
                if (tboxPassword.Text == password)
                {
                    FormMainMenu frmMain = new FormMainMenu();                
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Username!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }



        private void FormLoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void tboxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
