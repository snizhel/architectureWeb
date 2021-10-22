using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploySite
{
    class EmployBUS
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = new EmployDAO().SelectAll();
            return employees;
        }
        public List<Employee> Search(string keyword)
        {
            List<Employee> employees = new EmployDAO().SelectByKeyword(keyword);
            return employees;
        }
        public Employee GetEmployee(int ID)
        {
            Employee employee = new EmployDAO().SelectByCode(ID); 
            return employee;
        }
        public bool Add(Employee employee)
        {
            bool res=new EmployDAO().Insert(employee);
            return res;
        }
        public bool Update(Employee employee)
        {
            bool res = new EmployDAO().Update(employee);
            return res;
        }
        public bool Delete(int ID)
        {
            bool res = new EmployDAO().Delete(ID);
            return res;
        }

       
    }
}
