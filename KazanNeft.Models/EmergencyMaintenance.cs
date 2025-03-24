using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanNeft.Models
{
    [Table("emergencymaintenances")]
    public class EmergencyMaintenance
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int PriorityId { get; set; }
        public string DescriptionEmergency { get; set; } = string.Empty;
        public string OtherConsiderations { get; set; } = string.Empty;
        public DateOnly? EMReportDate { get; set; }
        public DateOnly? EMStartDate { get; set; }
        public DateOnly? EMEndDate { get; set; }
        public string TechnicianNote { get; set; } = string.Empty;

    }
}
