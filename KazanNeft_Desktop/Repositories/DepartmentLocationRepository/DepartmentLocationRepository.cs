using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.DepartmentLocationRepository
{
    public class DepartmentLocationRepository : IDepartmentLocationRepository
    {
        public DBContext db;
        public DepartmentLocationRepository()
        {
            db = new();
        }

        public DepartmentLocation GetDepartmentById(int id)
        {
            return db.DepartmentLocations.Where(a => a.DepartmentId == id).FirstOrDefault();
        }
    }
}
