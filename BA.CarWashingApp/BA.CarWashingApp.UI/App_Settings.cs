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
    public partial class App_Settings : Form
    {
        VehicleTypeManager vehicleTypeManager = new VehicleTypeManager(new Uow(new AppDbContext()));
        DirtStatusManager dirtStatusManager = new DirtStatusManager(new Uow(new AppDbContext()));
        WashingTypeManager washingTypeManager = new WashingTypeManager(new Uow(new AppDbContext()));
        WashingRecipeManager washingRecipeManager = new WashingRecipeManager(new Uow(new AppDbContext()));
        SystemUserManager sum = new SystemUserManager(new Uow(new AppDbContext()));



        public App_Settings()
        {
            InitializeComponent();
        }

        private void btnVTAdd_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleType vehicleType = new VehicleType();
                vehicleType.TypeName = CbVTTypeName.Text;
                vehicleType.TimeFactor = Convert.ToDecimal(tbVTTimeFact.Text);
                vehicleType.PriceFactor = Convert.ToDecimal(tbVTPriceFact.Text);
                vehicleType.MaterialFactor = Convert.ToDecimal(tbVTMaterialFact.Text);
                vehicleTypeManager.Add(vehicleType);
            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }
        }

        private void btnDSAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DirtStatus dirtStatus = new DirtStatus();
                dirtStatus.StatusName = cbDSStatusName.Text;
                dirtStatus.TimeFactor = Convert.ToDecimal(tbDSTimeFact.Text);
                dirtStatus.PriceFactor = Convert.ToDecimal(tbDSPriceFact.Text);
                dirtStatus.MaterialFactor = Convert.ToDecimal(tbDSMaterialFact.Text);
                dirtStatusManager.Add(dirtStatus);
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
            }

        }

        private void btnWTAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WashingType washingType = new WashingType();
                washingType.TypeName = cbWTTypeName.Text;
                washingType.TypeTime = Convert.ToInt32(tbWTTimeFact.Text);
                washingType.TypePrice = Convert.ToDecimal(tbWTPriceFact.Text);
                washingType.MaterialFactor = Convert.ToDecimal(tbWTPriceFact.Text);
                washingTypeManager.Add(washingType);
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
            }

        }

        private void btnWRAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WashingRecipe washingRecipe = new WashingRecipe();
                washingRecipe.MaterialName = tbWRMaterialName.Text;
                washingRecipe.PriceFactor = Convert.ToDecimal(tbWRPriceFact.Text);
                var wtid = Convert.ToInt32(tbWTID.Text);
                var vtid = Convert.ToInt32(tbVTID.Text);
                var dsid = Convert.ToInt32(tbDSID.Text);
                var mid = Convert.ToInt32(tbMID.Text);
                washingRecipe.Amount = sum.SetAmount(wtid, vtid, dsid, mid);
                washingRecipeManager.Add(washingRecipe);
                tbWRMaterialName.Clear();
                tbWRPriceFact.Clear();
                tbVTID.Clear();
                tbDSID.Clear();
                tbMID.Clear();
                tbWTID.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void App_Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
