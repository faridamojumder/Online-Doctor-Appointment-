using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.Admin
{
    public partial class Add : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Session["System"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                var oUser = Session["User"] == null ? new User() : (User)Session["User"];
                loggedUser.Text = oUser.Username;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}