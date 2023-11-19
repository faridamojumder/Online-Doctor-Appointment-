using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                txtUserNameMsg.Text = "Username cannot be empty.";
            }
            if (txtUserPass.Text.Trim() == "")
            {
                txtUserPassMsg.Text = "Password cannot be empty.";
            }

            if (txtUserName.Text.Trim() != "" && txtUserPass.Text.Trim() != "")
            {
                var obj = new Model1();
                var oUser = (from u in obj.Users
                             where u.Username == txtUserName.Text.Trim() && u.Password == txtUserPass.Text.Trim()
                             join r in obj.Roles on u.RoleId equals r.RoleId
                             select u).FirstOrDefault();
                if (oUser == null)
                {

                    errorMsg.Text = "Username or Password cannot matched.";
                }
                else
                {
                    Session["User"] = oUser;
                    Session["RolePermission"] = obj.RolePermissions.Where(x => x.UserId == oUser.UserId).ToList();
                    if (oUser.RoleId == 1)
                    {
                        Session["System"] = oUser.RoleId;
                        Response.Redirect("~/Admin/Home.aspx");
                    }
                    else if (oUser.RoleId == 2)
                    {
                        Session["AppointmentDetails"] = oUser.RoleId;
                        Response.Redirect("~/AppointmentDetails/Home.aspx");
                    }
                }
            }
        }
    }
}