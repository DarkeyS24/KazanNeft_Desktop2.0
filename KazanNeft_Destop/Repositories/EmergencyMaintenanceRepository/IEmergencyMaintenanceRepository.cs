using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KazanNeft_Desktop.Views.MainUserForm;

namespace KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository
{
    public interface IEmergencyMaintenanceRepository
    {
        public IList<EmergencyDataTable> getTableData(int id);
    }
}
