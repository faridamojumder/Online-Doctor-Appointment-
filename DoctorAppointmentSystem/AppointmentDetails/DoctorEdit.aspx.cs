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

    public partial class DoctorEdit : System.Web.UI.Page
    {
        Model1 obj = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            // authorization code
            var listRolePermission = Session["RolePermission"] == null ? new List<RolePermission>() : (List<RolePermission>)Session["RolePermission"];
            var oRolePermission = (from o in listRolePermission where o.MenuName == "Doctor" && o.IsUpdate == true select o).FirstOrDefault();
            if (oRolePermission == null)
            {
                Response.Redirect("~/AppointmentDetails/DoctorList.aspx");
            }

            int nDoctorID = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                //You can write here the code, which you want to execute in the first time when the page is loaded.
                GetSpecialist();
                Edit(nDoctorID);
            }
        }
        private void GetSpecialist()
        {
            var obj = new Model1();
            var list = (from o in obj.Specialists select o).ToList();
            foreach (var oSpecialist in obj.Specialists)
            {
                DropDownList1.Items.Insert(0, new ListItem(oSpecialist.SpecialistName, oSpecialist.SpecialistID.ToString()));
            }

        }
        private void Edit(int nDoctorID)
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
            var obj = new Model1();
            var oDoctor = obj.Doctors.Where(x => x.DoctorID == nDoctorID).FirstOrDefault();
            doctorId.Value = oDoctor.DoctorID.ToString();
            txtDoctorName.Text = oDoctor.DoctorName;
            txtEmail.Text = oDoctor.Email;
            txtFee.Text= oDoctor.DoctorName;
            Service = oDoctor.ServiceType;
            //TextBox1.Text = Convert.ToDateTime(oDoctor.ScheduleDate).ToString("");
            TextBox1.Text = oDoctor.ScheduleDate.ToString();
            //FileUpload1.FileName = oDoctor.Prescription;
            imgSalesForce.ImageUrl = oDoctor.Prescription;
            DropDownList1.SelectedValue = oDoctor.SpecialistID.ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
                Label1.Text = "Please select your file";
                Label1.ForeColor = System.Drawing.Color.Red;
                picPath = "~/Images/images.jpg";
            }
            var nDoctorID = Convert.ToInt32(doctorId.Value);
            var obj = new Model1();
            var oDoctor = obj.Doctors.Where(x => x.DoctorID == nDoctorID).FirstOrDefault();
            oDoctor.DoctorName = txtDoctorName.Text.Trim();
            oDoctor.Email = txtEmail.Text.Trim();
            oDoctor.Fee = Convert.ToInt32(txtFee.Text.Trim());
            oDoctor.ServiceType = Service;
            oDoctor.ScheduleDate = Convert.ToDateTime(TextBox1.Text);
            oDoctor.Prescription = picPath;
            oDoctor.SpecialistID = Convert.ToInt32(DropDownList1.SelectedValue);
            if (picPath != "")
            {
                if (File.Exists(Server.MapPath(oDoctor.Prescription)))
                {
                    File.Delete(Server.MapPath(oDoctor.Prescription));
                }
            }
            oDoctor.Prescription = picPath;
            obj.SaveChanges();

            Response.Redirect("DoctorList.aspx");
        }
    }
}