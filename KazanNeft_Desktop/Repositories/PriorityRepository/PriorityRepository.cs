using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft.Models;

namespace KazanNeft_Desktop.Repositories.PriorityRepository
{
    public class PriorityRepository : IPriorityRepository
    {
        private DBContext db;
        public PriorityRepository()
        {
            db = new();
        }

        public IList<Priority> GetAllPriorities()
        {
           return db.Priorities.ToList();
        }
    }
}
