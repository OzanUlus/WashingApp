using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Context;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;
using BA.CarWashingApp.Entity.Enums;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class App_User : Form
    {
        SystemUserManager systemUserManager = new SystemUserManager(new Uow(new AppDbContext()));
        public App_User()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void App_User_Load(object sender, EventArgs e)
        {
            cbRole.DataSource = Enum.GetValues(typeof(RoleType));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                SystemUser user = new SystemUser();
                user.UserName = tbUserName.Text;
                user.Password = tbPassword.Text;
                user.Role = (RoleType)cbRole.SelectedItem;
                systemUserManager.Add(user);
            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                var data = systemUserManager.GetAll();
                foreach (var item in data)
                {
                    listBox1.Items.Add(item.Id + " " + "UserName: " + item.UserName + " " + "Password: " + item.Password + " " + " Role: " + item.Role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var data = listBox1.SelectedItem.ToString();
                var id = Convert.ToInt32(data.Split(' ')[0]);
                var entity = systemUserManager.GetById(id);
                systemUserManager.Delete(entity);
                listBox1.Items.Remove(data);
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
            }
           
        }

        

        
    }
}
