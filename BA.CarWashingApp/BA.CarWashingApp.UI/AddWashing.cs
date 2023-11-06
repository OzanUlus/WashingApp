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
    public partial class AddWashing : Form
    {
        SystemUserManager sum = new SystemUserManager(new Uow(new AppDbContext()));
        WashingManager washingManager = new WashingManager(new Uow(new AppDbContext()));



        public AddWashing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Washing washing = new Washing();
                washing.Status = comboBox1.Text;
                washing.WashingRecipeId = Convert.ToInt32(textBox1.Text);
                washing.VehicleId = Convert.ToInt32(textBox2.Text);
                var dsid = Convert.ToInt32(tbdsid.Text);
                var vtid = Convert.ToInt32(tbvti.Text);
                var wtid = Convert.ToInt32(tbwti.Text);
                var wrid = Convert.ToInt32(tbwri.Text);
                washing.TotalPrice = sum.SetPrice(dsid, vtid, wrid, wtid);
                washing.RemainingTime = (int)sum.SetDuration(vtid, dsid, wtid);
                washingManager.Add(washing);
                textBox1.Clear();
                textBox2.Clear();
                tbdsid.Clear();
                tbvti.Clear();
                tbwti.Clear();
                tbwri.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
            }

        }

        private void AddWashing_Load(object sender, EventArgs e)
        {

        }
    }
}
