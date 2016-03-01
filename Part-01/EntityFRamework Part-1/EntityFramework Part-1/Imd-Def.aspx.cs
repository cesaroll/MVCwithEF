using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_Part_1
{
    public partial class Imd_Def : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrganizationEntities oe = new OrganizationEntities();

            using (TransactionScope ts = new TransactionScope())
            {
                tbl_Dept dept = new tbl_Dept();
                dept.DName = "PDG";
                dept.HOD = "Jill";
                dept.Active = true;

                oe.tbl_Dept.Add(dept);

                tbl_Emp emp = new tbl_Emp();
                emp.EName = "Fari";
                emp.ESal = 68520;
                emp.EGen = "M";
                emp.EDOB = new DateTime(1984, 11, 06);
                emp.Did = dept.Did;

                oe.tbl_Emp.Add(emp);

                oe.SaveChanges();

                ts.Complete();
            }
            

        }
    }
}