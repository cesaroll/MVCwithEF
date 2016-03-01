using System;
using System.Dynamic;
using System.Web.Mvc.Html;

namespace Section14.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HOD { get; set; }
        public string Gender { get; set; }
    }
}