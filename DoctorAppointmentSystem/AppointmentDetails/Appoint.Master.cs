using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.AppointmentDetails
{
    public partial class Appoint : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Session["AppointmentDetails"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                var oUser = Session["User"] == null ? new User() : (User)Session["User"];
                loggedUser.Text = oUser.Username;

                // menu show hide
                var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
                var ST = (from o in listRolePermission where o.MenuName == "Specialist" && o.IsSelect == true select o).FirstOrDefault();
                var SF = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsSelect == true select o).FirstOrDefault();
                st.Visible = ST == null ? false : true;
                sf.Visible = SF == null ? false : true;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}