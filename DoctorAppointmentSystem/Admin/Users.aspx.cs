using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.Admin
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetUsers();
            }
        }
        private void GetUsers()
        {
            var obj = new Model1();
            var list = (from u in obj.Users
                        join r in obj.Roles on u.RoleId equals r.RoleId
                        select new
                        {
                            u.UserId,
                            u.Username,
                            r.RoleName
                        }
                        ).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SetPermission")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                var UserId = selectedRow.Cells[0].Text.Trim();
                //Response.Redirect("~/permissions?id=" + UserId);
                Response.Redirect("~/Admin/RolePermissions.aspx?id=" + UserId);
            }
        }
    }
}