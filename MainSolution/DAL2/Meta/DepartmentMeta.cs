using System.ComponentModel.DataAnnotations;

namespace DAL2
{
    public class DepartmentMeta
    {
        [Required]
        public string Name { get; set; }
    }

    [MetadataType(typeof(DepartmentMeta))]
    public partial class Department
    {

    }
}