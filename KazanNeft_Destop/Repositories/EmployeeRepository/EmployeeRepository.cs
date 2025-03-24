using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace KazanNeft_Desktop.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DBContext db;
        public EmployeeRepository()
        {
            db = new DBContext();
        }
        public Employee IsEmployee(string user, string password)
        {
            return db.Employees
                .Where(a => a.Username == user && a.Password == password)
                .FirstOrDefault();

            //return db.Employees.FromSql($"Select * from employees where Username = {user} and Password = {password};").FirstOrDefault();
        }
    }
}
