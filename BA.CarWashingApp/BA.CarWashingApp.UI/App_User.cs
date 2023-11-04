using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Context;
using BA.CarWashingApp.DAL.Uow;
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
    public partial class App_User : Form
    {
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
            SystemUser user = new SystemUser();
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.Role = (RoleType)cbRole.SelectedItem;
            SystemUserManager systemUserManager = new SystemUserManager(new Uow(new AppDbContext()));
            systemUserManager.Add(user);

        }
    }
}
