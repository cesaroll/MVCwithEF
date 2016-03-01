using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_Part_1
{
    public partial class Emp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrganizationEntities oe = new OrganizationEntities();

            //GridView1.DataSource = oe.SP_GetAllEmployee().ToList();
            //GridView1.DataSource = oe.SP_GetEmployeesByDid(100).ToList();

            ObjectParameter eName = new ObjectParameter("EName", typeof (String));
            ObjectParameter eSal = new ObjectParameter("ESal", typeof (Int64));

            oe.SP_GetEmpNameAndSalaryByEid(1, eName, eSal);

            Response.Write("Employee Name: " + eName.Value);
            Response.Write("<BR>Employee Salary: " + eSal.Value);

            GridView1.DataBind();
        }
    }
}