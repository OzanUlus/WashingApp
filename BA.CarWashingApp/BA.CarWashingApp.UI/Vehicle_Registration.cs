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
    public partial class Vehicle_Registration : Form
    {
        public Vehicle_Registration()
        {
            InitializeComponent();
        }

        private void Vehicle_Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string saved_lisance_plate = tbPlateSearch.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lisance_plate = tbLisancePlate.Text;
            string brand = tbBrand.Text;
            string model = tbModel.Text;
            string car_color = tbColor.Text;
            string car_owner_name_surname = tbCoName.Text;
            string car_owner_mobile_number = tbCoPhoneNumber.Text;
            string car_owner_mail = tbCoEmail.Text;
        }
    }
}
