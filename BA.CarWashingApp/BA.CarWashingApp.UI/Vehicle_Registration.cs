using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;
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

        VehicleManager vehicleManager = new VehicleManager(new Uow(new DAL.Context.AppDbContext()));
        CustomerManager customerManager = new CustomerManager(new Uow(new DAL.Context.AppDbContext()));


        public Vehicle_Registration()
        {
            InitializeComponent();
        }

        private void Vehicle_Registration_Load(object sender, EventArgs e)
        {

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.LicensePlate = tbLisancePlate.Text;
            vehicle.Brand = tbBrand.Text;
            vehicle.Model = tbModel.Text;
            vehicle.Color = tbColor.Text;
            vehicle.OrderNo = Convert.ToInt32(tbOrderNo.Text);
            vehicle.VehicleTypeId = Convert.ToInt32(tbVehicleTypeID.Text);
            vehicle.DirtStatusId = Convert.ToInt32(tbDirtStatusID.Text);
            vehicle.CustomerId = Convert.ToInt32(tbCustomeID.Text);
            Customer customer = new Customer();
            customer.Name = tbCoName.Text;
            customer.SurName = tbCoSurname.Text;
            customer.PhoneNumber = tbCoPhoneNumber.Text;
            customer.Email = tbCoEmail.Text;
            vehicleManager.Add(vehicle);
            customerManager.Add(customer);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var data = vehicleManager.GetVehiclewithCustomer();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id + " " + "License Plate: " + item.LicensePlate + " " + "Brand: " + item.Brand + " " + "Model: " + item.Model + " " + "Color: " + item.Color + " " + "Customer Name / SurName" + item.Customer.Name + "" + item.Customer.SurName + "" + "Customer Phone Num.: " + item.Customer.PhoneNumber + "" + "Customer eMail: " + item.Customer.Email + " " + "OrderNo: " + item.OrderNo + " " + "Vehicle Type ID: " + item.VehicleTypeId + " " + " Dirt Status ID: " + item.DirtStatusId + " " + "Customer ID: " + item.CustomerId);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = listBox1.SelectedItem.ToString();
            var id = Convert.ToInt32(data.Split(' ')[0]);
            var entity = vehicleManager.GetById(id);
            vehicleManager.Delete(entity);
            listBox1.Items.Remove(data);
        }

        
    }
}
