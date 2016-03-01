using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_Part_1
{
    public partial class NavigationProperties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            OrganizationEntities oe = new OrganizationEntities();

//            int did = oe.tbl_Dept.ToList().Where(x => x.DName == txtDeptName.Text).FirstOrDefault().Did;
//            var emps = oe.tbl_Emp.ToList().Where(x => x.Did == did);

            var emps = oe.tbl_Dept.Where(x => x.DName == txtDeptName.Text).FirstOrDefault().tbl_Emp;

            grdEmps.DataSource = emps;
            grdEmps.DataBind();

        }
    }
}