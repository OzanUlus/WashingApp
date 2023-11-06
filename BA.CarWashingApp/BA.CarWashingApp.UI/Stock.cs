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
    public partial class Stock : Form
    {
        MaterialManager mam = new MaterialManager(new Uow(new AppDbContext()));



        public Stock()
        {
            InitializeComponent();
        }

        private void add_stock_Click(object sender, EventArgs e)
        {
            //CustomerManager cm = new CustomerManager();
        }

        private void btnMaterialAdd_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Name = tbMaterialName.Text;
            material.Stock = Convert.ToInt32(tbMaterialStock.Text);
            material.MinStock = Convert.ToInt32(tbMaterialMinStock.Text);
            mam.Add(material);

        }

        private void btnListMaterial_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var data = mam.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id + " " + "Material: " + item.Name + "  Stock: " + item.Stock + " Min.Stock: " + item.MinStock);
            }
        }

        private void btnMaterialDelete_Click(object sender, EventArgs e)
        {
            var data = listBox1.SelectedItem.ToString(); // burada tb.text cnvrt int 
            var id = Convert.ToInt32(data.Split(' ')[0]);
            var entity = mam.GetById(id); // var data gibi verivem id kısmına
            mam.Delete(entity);
            listBox1.Items.Remove(data); // bu yok



        }

        /*private void btnMaterialUpdate_Click(object sender, EventArgs e)
        {
            var data = listBox1.SelectedItem.ToString();
            var id = Convert.ToInt32(data.Split(' ')[0]);
            var entity = mam.GetById(id);
            listBox1.Items.Remove(data);
            entity.Name = tbMaterialName.Text;
            entity.Stock = Convert.ToInt32(tbMaterialStock.Text);
            entity.MinStock = Convert.ToInt32(tbMaterialMinStock.Text);
            mam.Update(entity);
            
            listBox1.Items.Add(entity.Id + " " + "Material: " + entity.Name + "  Stock: " + entity.Stock + " Min.Stock: " + entity.MinStock);
        }
        */
        private void btnControl_Click(object sender, EventArgs e)
        {
            var name = tbcontrol.Text.ToLower();
            var result = mam.QueryMaterial(name);
            MessageBox.Show(result);

        }
    }
}
