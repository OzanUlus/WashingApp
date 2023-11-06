using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Context;
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
    public partial class Wash_Status : Form
    {
        WashingManager washingManager = new WashingManager(new Uow(new AppDbContext()));
        public Wash_Status()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Wash_Status_Load(object sender, EventArgs e)
        {
            var data = washingManager.ListProcess();


            foreach (var process in data)
            {
                ListViewItem item1 = new ListViewItem(Convert.ToString(process.Vehicle.OrderNo));
                item1.SubItems.Add(process.Vehicle.LicensePlate);
                item1.SubItems.Add(process.Vehicle.Brand);
                item1.SubItems.Add(process.Vehicle.Model);
                item1.SubItems.Add(process.RemainingTime.ToString());
                item1.SubItems.Add(process.Employee.Name);
                listView1.Items.Add(item1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Columns.Clear();
            listView2.Clear();
            listView2.Columns.Add("Lisance Plate", 150);
            listView2.Columns.Add("Customer", 150);
            listView2.Columns.Add("Dirt Status", 150);
            listView2.Columns.Add("Vehicle Type", 150);
            var id = Convert.ToInt32(textBox1.Text);
            var data = washingManager.ListVehicleDetail(id);

            foreach (var process in data)
            {
                ListViewItem item1 = new ListViewItem(process.Vehicle.LicensePlate);
                item1.SubItems.Add(process.Vehicle.Customer.Name);
                item1.SubItems.Add(process.Vehicle.DirtStatus.StatusName);
                item1.SubItems.Add(process.Vehicle.VehicleType.TypeName);
                listView2.Items.Add(item1);
            }

        }

        private void btnWashStatusDetail_Click(object sender, EventArgs e)
        {

            listView2.Columns.Clear();
            listView2.Clear();
            listView2.Columns.Add("Employee", 150);
            listView2.Columns.Add("Position", 150);
            listView2.Columns.Add("Recipe Material", 150);
            listView2.Columns.Add("Recipe Amount", 150);
            var id = Convert.ToInt32(textBox1.Text);
            var data = washingManager.ListDetail(id);

            foreach (var process in data)
            {
                ListViewItem item1 = new ListViewItem(process.Employee.Name);
                item1.SubItems.Add(process.Employee.Position);
                item1.SubItems.Add(process.WashingRecipe.MaterialName);
                item1.SubItems.Add(process.WashingRecipe.Amount.ToString());
                listView2.Items.Add(item1);
            }
        }



    }
}
