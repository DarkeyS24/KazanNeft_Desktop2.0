using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazanNeft.Models
{
    [Table("parts")]
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int EffectiveLife { get; set; }
            
    }
}
