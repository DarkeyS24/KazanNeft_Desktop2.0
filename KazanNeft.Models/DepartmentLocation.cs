using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanNeft.Models
{
    [Table("departmentlocations")]
    public class DepartmentLocation
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int LocationId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
