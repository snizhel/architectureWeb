using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmploySite
{
    public partial class EmployForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee>employees=new EmployBUS().GetAll();
            gvEmps.DataSource = employees;
            gvEmps.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword=txtKeyword.Text.Trim();
            List<Employee> employees = new EmployBUS().Search(keyword);
            gvEmps.DataSource = employees;
            gvEmps.DataBind();

        }

        protected void gvEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(gvEmps.SelectedRow.Cells[1].Text.Trim());
            Employee emp=new EmployBUS().GetEmployee(id);
            if (emp != null)
            {
                txtID.Text = emp.ID.ToString();
                txtName.Text = emp.Name;
                txtAddress.Text = emp.Address;
                txtAge.Text =  emp.Age.ToString();
                txtSalary.Text = emp.Salary.ToString();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                ID = 0,
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Age = int.Parse(txtAge.Text.Trim()),
                Salary = int.Parse(txtSalary.Text.Trim()),
            };
            bool result = new EmployBUS().Add(emp);
            if (result)
            {
                List<Employee> employees = new EmployBUS().GetAll();
                gvEmps.DataSource = employees;
                gvEmps.DataBind();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee()
            {
                ID = int.Parse(txtID.Text.Trim()),
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Age = int.Parse(txtAge.Text.Trim()),
                Salary = int.Parse(txtSalary.Text.Trim()),
            };
            bool result = new EmployBUS().Update(emp);
            if (result)
            {
                List<Employee> employees = new EmployBUS().GetAll();
                gvEmps.DataSource = employees;
                gvEmps.DataBind();
            }
           
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text.Trim());
            bool result = new EmployBUS().Delete(id);
            if (result)
            {
                List<Employee> employees = new EmployBUS().GetAll();
                gvEmps.DataSource = employees;
                gvEmps.DataBind();
            }
        }
    }
}