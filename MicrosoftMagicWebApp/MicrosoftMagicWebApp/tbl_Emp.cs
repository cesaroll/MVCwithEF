//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicrosoftMagicWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Emp
    {
        public int Eid { get; set; }
        public string EName { get; set; }
        public double ESal { get; set; }
        public string EGen { get; set; }
        public System.DateTime EDOB { get; set; }
        public Nullable<int> Did { get; set; }
    
        public virtual tbl_Dept tbl_Dept { get; set; }
    }
}
