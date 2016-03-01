using System.ComponentModel.DataAnnotations;

namespace S15_L61_EDMValidation.Controllers.Meta
{
    public class DepartmentMeta
    {
        [Required]
        public string Name { get; set; }
 
    }


    public partial class Department
    {
        
    }

}