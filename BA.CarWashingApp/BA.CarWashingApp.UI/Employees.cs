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
using BA.CarWashingApp.BLL.Managers;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.DAL.Context;

namespace BA.CarWashingApp.UI
{
    public partial class Employees : Form
    {
        EmployeeManager em = new EmployeeManager(new Uow(new AppDbContext()));
        SystemUserManager sum = new SystemUserManager(new Uow(new AppDbContext()));



        public Employees()
        {
            InitializeComponent();
        }

        public Button btnAddEmployee
        {
            get { return btnAdd_Employee; }
        }




        private void btnAdd_Employee_Click(object sender, EventArgs e)
        {
            try
            {


                Employee employee = new Employee();
                employee.Name = tbEmployeeName.Text;
                employee.SurName = tbEmployeeSurname.Text;
                employee.Status = cbEmpStatus.Checked;
                employee.Position = cbEmployeePosition.Text;
                employee.ShiftStartTime = mcShiftBegin.SelectionStart;
                employee.ShiftEndTime = mcShiftEnd.SelectionEnd;
                employee.Salary = Convert.ToDecimal(tbEmployeeSalary.Text);
                employee.TotalLeave = Convert.ToInt32(tbTotalLeave.Text);
                employee.UsedLeave = Convert.ToInt32(tbUsedLeave.Text);
                employee.RemainingLeave = Convert.ToInt32(tbRemainingLeave.Text);
                employee.WashingId = Convert.ToInt32(tbWashingID.Text);
                employee.SystemUserId = Convert.ToInt32(tbAddUserID.Text);
                em.Add(employee);
            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }


        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            try
            {


                var empıd = Convert.ToInt32(tbEmpID.Text);
                var request = Convert.ToInt32(tbLeaveRequest.Text);
                var per = sum.Permission(empıd, request);
                if (per == true)
                {
                    MessageBox.Show("Leave Approved.");

                }
                else
                {
                    MessageBox.Show("Leave Denied.");

                }

            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }

            }



        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                var data = em.GetAll();
                foreach (var item in data)
                {
                    listBox1.Items.Add(item.Id + " " + "Employee Name: " + item.Name + " " + "Employee Surname: " + item.SurName + " " + "Employee Salary: " + item.Salary + "Employee Position: " + item.Position + " " + "Employee Shift Begin: " + item.ShiftStartTime + " " + "Employee Shift End: " + item.ShiftEndTime + " " + "Employee Remaining Leave: " + item.RemainingLeave);

                }
            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }
            
           



        }

        private void btn_Delete_Emp_Click(object sender, EventArgs e)
        {
            try
            {
                var data = listBox1.SelectedItem.ToString();
                var id = Convert.ToInt32(data.Split(' ')[0]);
                var entity = em.GetById(id);
                em.Delete(entity);
                listBox1.Items.Remove(data);
            }
            catch (Exception ex) { MessageBox.Show(" Lütfen bilgileri doğru giriniz!"); }
           
           
        }

        private void btn_Update_emp_Click(object sender, EventArgs e)
        {
            try
            {
                var data = listBox1.SelectedItem.ToString();
                var id = Convert.ToInt32(data.Split(' ')[0]);
                var entity = em.GetById(id);
                listBox1.Items.Remove(data);
                entity.Name = tbEmployeeName.Text;
                entity.SurName = tbEmployeeSurname.Text;
                entity.Status = cbEmpStatus.Checked;
                entity.Position = cbEmployeePosition.Text;
                entity.ShiftStartTime = mcShiftBegin.SelectionStart;
                entity.ShiftEndTime = mcShiftEnd.SelectionEnd;
                entity.Salary = Convert.ToDecimal(tbEmployeeSalary.Text);
                entity.TotalLeave = Convert.ToInt32(tbTotalLeave.Text);
                entity.UsedLeave = Convert.ToInt32(tbUsedLeave.Text);
                entity.RemainingLeave = Convert.ToInt32(tbRemainingLeave.Text);
                entity.WashingId = Convert.ToInt32(tbWashingID.Text);
                entity.SystemUserId = Convert.ToInt32(tbAddUserID.Text);
                em.Update(entity);

                listBox1.Items.Add(entity.Id + " " + "Employee Name: " + entity.Name + " " + "Employee Surname: " + entity.SurName + " " + "Employee Salary: " + entity.Salary + "Employee Position: " + entity.Position + " " + "Employee Shift Begin: " + entity.ShiftStartTime + " " + "Employee Shift End: " + entity.ShiftEndTime + " " + "Employee Remaining Leave: " + entity.RemainingLeave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lütfen bilgileri doğru giriniz!");

            }
            
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
    }
}
