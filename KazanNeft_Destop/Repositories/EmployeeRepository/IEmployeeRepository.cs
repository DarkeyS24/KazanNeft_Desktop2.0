using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        public Employee IsEmployee(string user, string password);
    }
}
