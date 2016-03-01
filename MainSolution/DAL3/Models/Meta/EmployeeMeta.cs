using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DAL3.Repository;

namespace DAL3.Models
{
    [MetadataType(typeof(EmployeeMeta))]
    public partial class Employee
    {

    }

    public class EmployeeMeta
    {
        [UniqueName]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Gender { get; set; }
        [DisplayName("Date of Birth")]
        [Required]
        public System.DateTime DOB { get; set; }
        [Required]
        public int DepId { get; set; }
         
    }
   

    #region Custom Validations

    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (EmployeeRepository.GetInstance().ExistsByName(value.ToString()))
                return new ValidationResult("Name Already Exists");
            else
                return ValidationResult.Success;
        }

    }

    #endregion

}