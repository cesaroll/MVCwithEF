//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Section06_L19
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public int DepId { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual SalaryInfo SalaryInfo { get; set; }
    }
}
