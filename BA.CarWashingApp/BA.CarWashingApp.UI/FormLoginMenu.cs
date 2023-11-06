using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Context;
using BA.CarWashingApp.DAL.Uow;
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
        SystemUserManager sum = new SystemUserManager(new Uow(new AppDbContext()));
        int tempid = 0;
        

        public FormMainMenu FormMainMenu;



        public FormLoginMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var control = sum.IsAccountTrue(tboxUserName.Text, tboxPassword.Text);
                if (control == -1)
                {
                    MessageBox.Show("Giriş Bilgileri Hatalı! Tekrar Girin!");
                }
                else
                {
                    tempid = control;
                    FormMainMenu frmMain = new FormMainMenu(tempid);
                    

                    frmMain.Show();
                    this.Hide();
                }

               /* if (tboxUserName.Text != "Admin")
                {
                    FormMainMenu formMainMenu = new FormMainMenu();

                    Employees empform = new Employees();
                    empform.Hide();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
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
