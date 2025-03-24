using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.DepartmentLocationRepository
{
    public interface IDepartmentLocationRepository
    {
        public DepartmentLocation GetDepartmentById(int id);
    }
}
