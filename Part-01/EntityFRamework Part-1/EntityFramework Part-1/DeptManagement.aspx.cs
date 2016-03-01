using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_Part_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllDept();
            }
           
        }

        private void GetAllDept()
        {
            OrganizationEntities OE = new OrganizationEntities();

            GridDept.DataSource = OE.tbl_Dept.ToList();
            GridDept.DataBind();
        }

        private tbl_Dept GetDeptByID(OrganizationEntities OE)
        {
            int deptId;
            tbl_Dept dept = null;

            if (int.TryParse(txtDeptId.Text, out deptId))
                dept = OE.tbl_Dept.ToList().FirstOrDefault(x => x.Did == deptId);

            return dept;

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            OrganizationEntities OE = new OrganizationEntities();

            tbl_Dept dept = new tbl_Dept();
            dept.DName = txtDepName.Text;
            dept.HOD = txtHod.Text;
            dept.Active = cbIsActive.Checked;

            OE.tbl_Dept.Add(dept);

            OE.SaveChanges();

            GetAllDept();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            OrganizationEntities OE = new OrganizationEntities();

            txtDepName.Text = string.Empty;
            txtHod.Text = string.Empty;
            cbIsActive.Checked = false;

            tbl_Dept dept = GetDeptByID(OE);

            if (dept != null)
            {
                txtDepName.Text = dept.DName;
                txtHod.Text = dept.HOD;
                cbIsActive.Checked = dept.Active.Value;
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            OrganizationEntities OE = new OrganizationEntities();

            tbl_Dept dept = GetDeptByID(OE);

            if (dept != null)
            {
                dept.DName = txtDepName.Text;
                dept.HOD = txtHod.Text;
                dept.Active = cbIsActive.Checked;

                OE.SaveChanges();

            }

            GetAllDept();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            OrganizationEntities OE = new OrganizationEntities();

            tbl_Dept dept = GetDeptByID(OE);

            if (dept != null)
            {
                OE.tbl_Dept.Remove(dept);
                OE.SaveChanges();
            }

            GetAllDept();

        }
    }
}