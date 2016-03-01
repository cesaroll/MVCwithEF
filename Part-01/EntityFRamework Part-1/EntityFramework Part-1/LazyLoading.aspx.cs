using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_Part_1
{
    public partial class LazyLoading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrganizationEntities oe = new OrganizationEntities();

                var result = oe.tbl_Dept.ToList();
                
                grdDept.DataSource = result;
                grdDept.DataBind();
            
            }


        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            OrganizationEntities oe = new OrganizationEntities();

            //Lazy Loading
            //var result = oe.tbl_Dept.Where(x => x.Active == cbActive.Checked).ToList();

            //Eager Loading
            var result = oe.tbl_Dept.Include("tbl_Emp").Where(x => x.Active == cbActive.Checked).ToList();


            foreach (var dept in result)
            {
                Response.Write(dept.DName + "<br>");

                foreach (var emp in dept.tbl_Emp)
                {
                    Response.Write("&nbsp;&nbsp;&nbsp;&nbsp;" + emp.EName +"<br>");
                }
            }

        }
    }
}