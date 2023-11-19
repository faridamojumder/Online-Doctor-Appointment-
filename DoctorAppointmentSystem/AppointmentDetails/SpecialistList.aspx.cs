using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.AppointmentDetails
{
    public partial class SpecialistList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // authorization code
            //var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
            //var oRolePermission = (from o in listRolePermission where o.MenuName == "Specialist" && o.IsSelect == true select o).FirstOrDefault();
            //if (oRolePermission == null)
            //{
            //    Response.Redirect("~/AppointmentDetails/Home.aspx");
            //}

            //if (!IsPostBack)
            //{
            //    GetSalesTerritory();
            //}
        }
        //private void GetSalesTerritory()
        //{
        //    var obj = new Model1();
        //    var list = (from o in obj.Specialists
        //                select
        //                new
        //                {
        //                    id = o.SpecialistID,
        //                    name = o.SpecialistName,
        //                    numberOfSalesForce = obj.Doctors.Where(x => x.SpecialistID == o.SpecialistID).Count()
        //                }).ToList();
        //    GridView1.DataSource = list;
        //    GridView1.DataBind();
        //}
    }
}