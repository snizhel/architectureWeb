using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploySite
{
    class EmployDAO
    {
        
        MyDBDataContext db=new MyDBDataContext(ConfigurationManager.ConnectionStrings["strcon"].ConnectionString);
        public List<Employee> SelectAll()
        {
           
            db.ObjectTrackingEnabled = false;
            List<Employee> employees =db.Employees.ToList();
            return employees;
        }
        public List<Employee> SelectByKeyword(String keyword)
        {
            
            List<Employee> employees=db.Employees.Where(x=>x.Name.Contains(keyword)).ToList();
            return employees;
        }
         public Employee SelectByCode(int ID)
        {
           
            Employee employee = db.Employees.SingleOrDefault(x => x.ID == ID);
            return employee;
        }
        public bool Insert(Employee emp)
        {
           
            try { 
                db.Employees.InsertOnSubmit(emp);
                db.SubmitChanges();
                return true;
            } catch
            {
                return false;
            }
        }
        public bool Update(Employee emp)
        {
           
            Employee employee=db.Employees.SingleOrDefault(x=>x.ID == emp.ID);
            if (employee != null)
            {
                try
                {
                    employee.Name = emp.Name;
                    employee.Salary = emp.Salary;
                    employee.Address = emp.Address;
                    employee.Age = emp.Age;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
               
            }
            return false;
        }
        public bool Delete(int id)
        {
           
            Employee employee = db.Employees.SingleOrDefault(x => x.ID == id);
            if(employee != null)
            {
                try
                {
                    db.Employees.DeleteOnSubmit(employee);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
