using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.DepartmentRepository
{
    public interface IDepartmentRepository
    {
        public Department GetDepartmentById(int id);
    }
}
