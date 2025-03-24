using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft_Desktop.Views;

namespace KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository
{
    public interface IEmergencyMaintenanceRepository
    {
        public IList<MainUserForm.EmergencyDataTable> getTableData(int id);
        public IList<MainUserForm.EmergencyDataTable> getAllTableData();
    }
}
