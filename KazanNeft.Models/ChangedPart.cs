using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanNeft.Models
{
    [Table("changedparts")]
    public class ChangedPart
    {
        public int Id { get; set; }
        public int EmergencyMaintenanceId { get; set; }
        public int PartId { get; set; }
        public decimal Amount { get; set; }
    }
}
