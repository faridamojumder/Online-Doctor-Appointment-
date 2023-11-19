using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.AppointmentDetails
{
    public partial class DoctorInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // authorization code
            var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
            var oRolePermission = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsInsert == true select o).FirstOrDefault();
            if (oRolePermission == null)
            {
                Response.Redirect("~/AppointmentDetails/DoctorList.aspx");
            }

            if (!IsPostBack)
            {
                GetSpecialist();
            }
        }
        protected void GetSpecialist()
        {
            var obj = new Model1();
            var list = (from o in obj.Specialists select o).ToList();
            foreach (var s in obj.Specialists)
            {
                DropDownList1.Items.Insert(0, new ListItem
                    (s.SpecialistName, s.SpecialistID.ToString()));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Service = string.Empty;
            if (RadioOnline.Checked)
            {
                Service = "Online";
            }
            else
            {
                Service = "Offline";
            }

            string picPath = "";
            if (FileUpload1.HasFile)
            {
                var extension = Path.GetExtension(FileUpload1.FileName);
                var newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;
                picPath = "~/Images/" + newFileName;
                if (File.Exists(Server.MapPath("//Images//" + FileUpload1.FileName)))
                {
                    File.Delete(Server.MapPath("//Images//" + FileUpload1.FileName));
                }

                FileUpload1.SaveAs(Server.MapPath("//Images//" + newFileName));
                Label1.Text = "Image Uploaded";
                Label1.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                Label1.Text = "Please Select your file";
                Label1.ForeColor = System.Drawing.Color.Red;
                picPath = "~/Images/images.jpg";
            }
            var obj = new Model1();
            var oDoctor = new Doctor();
            oDoctor.DoctorName= txtDoctorName.Text.Trim();
            oDoctor.Email = txtEmail.Text.Trim();
            oDoctor.Fee = Convert.ToInt32(txtFee.Text.Trim());
            oDoctor.ServiceType = Service;
            oDoctor.ScheduleDate = Calendar1.SelectedDate;
            oDoctor.Prescription = picPath;
            oDoctor.SpecialistID = Convert.ToInt32(DropDownList1.SelectedValue);

            obj.Doctors.Add(oDoctor);
            obj.SaveChanges();

            Response.Redirect("DoctorList.aspx");
        }
    }
}