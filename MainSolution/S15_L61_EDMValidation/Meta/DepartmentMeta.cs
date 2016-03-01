using System.ComponentModel.DataAnnotations;

namespace S15_L61_EDMValidation
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