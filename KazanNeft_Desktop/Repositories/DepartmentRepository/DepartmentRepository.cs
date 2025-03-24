using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.DepartmentRepository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private DBContext db;
        public DepartmentRepository()
        {
            db = new();
        }

        public Department GetDepartmentById(int id)
        {
            return db.Departments.Find(id);
        }
    }
}
