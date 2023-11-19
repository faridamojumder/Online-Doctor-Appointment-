using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.Admin
{
    public partial class Roles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetRoles();
            }
        }
        private void GetRoles()
        {
            var obj = new Model1();
            var list = (from r in obj.Roles
                        select r
                        ).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}