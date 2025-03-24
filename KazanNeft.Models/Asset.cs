using System.ComponentModel.DataAnnotations.Schema;

namespace KazanNeft.Models
{
    [Table("assets")]
    public class Asset
    {
        public int Id { get; set; }
        public string AssetSN { get; set; } = string.Empty;
        public string AssetName { get; set; } = string.Empty;
        public int DepartmentLocationId { get; set; }
        public int EmployeeId { get; set; }
        public int AssetGroupId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateOnly WarrantyDate { get; set; }
    }
}
