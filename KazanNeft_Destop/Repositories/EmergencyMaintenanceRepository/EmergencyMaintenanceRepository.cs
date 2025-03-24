using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KazanNeft.Database;
using KazanNeft_Desktop.Views;

namespace KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository
{
    public class EmergencyMaintenanceRepository : IEmergencyMaintenanceRepository
    {
        private DBContext db;
        public EmergencyMaintenanceRepository()
        {
            db = new();
        }
        public IList<MainUserForm.EmergencyDataTable> getTableData(int id)
        {
             return (
                from em in db.EmergencyMaintenances
                join a in db.Assets on em.AssetId equals a.Id
                join e in db.Employees on a.EmployeeId equals e.Id
                where a.EmployeeId == id
                select new MainUserForm.EmergencyDataTable 
                {
                    AssetSN = a.AssetSN,
                    AssetName = a.AssetName,
                    LastClosedEM = em.EMEndDate,
                    NumberOfEMs = db.EmergencyMaintenances
                        .Where(em => em.AssetId == a.Id)
                        .Count()
                }
                ).ToList();
        }
        
        public IList<MainUserForm.EmergencyDataTable> getAllTableData()
        {
             return (
                from em in db.EmergencyMaintenances
                join a in db.Assets on em.AssetId equals a.Id
                select new MainUserForm.EmergencyDataTable 
                {
                    AssetSN = a.AssetSN,
                    AssetName = a.AssetName,
                    LastClosedEM = em.EMEndDate,
                    NumberOfEMs = db.EmergencyMaintenances
                        .Where(em => em.AssetId == a.Id)
                        .Count()
                }
                ).ToList();
        }
    }
}
