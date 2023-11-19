using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.AppointmentDetails
{
    public partial class DoctorList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // authorization code
            var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
            var oRolePermission = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsSelect == true select o).FirstOrDefault();
            if (oRolePermission == null)
            {
                Response.Redirect("~/AppointmentDetails/Home.aspx");
            }

            if (!IsPostBack)
            {
                GetDoctor();
            }
        }
        private void GetDoctor()
        {
            var obj = new Model1();
            var list = (from D in obj.Doctors
                        join S in obj.Specialists on D.SpecialistID equals S.SpecialistID
                        select new
                        {
                            D.DoctorID,
                            D.DoctorName,
                            D.Email,
                            D.Fee,
                            D.ServiceType,
                            D.ScheduleDate,
                            D.Prescription,
                            D.SpecialistID,

                        }
                        ).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                // authorization code
                var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
                var oRolePermission = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsUpdate == true select o).FirstOrDefault();
                if (oRolePermission == null)
                {
                    Response.Redirect("~/AppointmentDetails/DoctorList.aspx");
                }
                else
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GridView1.Rows[index];
                    var DoctorID = selectedRow.Cells[0].Text.Trim();
                    Response.Redirect("DoctorEdit.aspx?id=" + DoctorID);
                }
            }

            if (e.CommandName == "Remove")
            {
                // authorization code
                var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
                var oRolePermission = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsDelete == true select o).FirstOrDefault();
                if (oRolePermission == null)
                {
                    Response.Redirect("~/AppointmentDetails/DoctorList.aspx");
                }
                else
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow selectedRow = GridView1.Rows[index];
                    var DoctorID = selectedRow.Cells[0].Text.Trim();
                    var nDoctorID = Convert.ToInt32(DoctorID);
                    Delete(nDoctorID);
                }
            }
        }
        private void Delete(int doctorID)
        {
            var obj = new Model1();
            var oDoctor = obj.Doctors.Where(x => x.DoctorID == doctorID).FirstOrDefault();
            obj.Doctors.Remove(oDoctor);
            if (File.Exists(Server.MapPath(oDoctor.Prescription)))
            {
                File.Delete(Server.MapPath(oDoctor.Prescription));
            }
            obj.SaveChanges();
            GetDoctor();
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-9QLAIUL;Initial Catalog=DoctorAppointment;Integrated Security=True;";
            string query = "select * from Doctor";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            ReportDocument crp = new ReportDocument();
            //crp.Load(Server.MapPath("CrystalReport1.rpt"));
            crp.Load(Server.MapPath("CrystalReport1.rpt"));
            crp.SetDataSource(ds.Tables["table"]);
            //CrystalReportViewer1.ReportSource = crp;
            crp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Doctor Infoemation");
            Response.Redirect("AppointmentDetails/Report.aspx");
        }

    }
}