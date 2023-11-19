using DoctorAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoctorAppointmentSystem.Admin
{
    public partial class RolePermissions : System.Web.UI.Page
    {
        Model1 obj = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            int nUserId = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                //You can write here the code, which you want to execute in the first time when the page is loaded.
                SetMenu(nUserId);
            }
        }
        private void SetMenu(int nUserId)
        {
            obj = new Model1();
            var oUser = (from u in obj.Users where u.UserId == nUserId select u).FirstOrDefault();
            lblUsername.Text = oUser == null ? "" : oUser.Username;
            var oRole = (from r in obj.Roles where r.RoleId == oUser.RoleId select r).FirstOrDefault();
            lblRole.Text = oRole == null ? "" : oRole.RoleName;
            roleId.Value = oUser.RoleId.ToString();
            userId.Value = oUser.UserId.ToString();

            var listRolePermissions = obj.RolePermissions.Where(x => x.UserId == nUserId).ToList();
            var oSpecialist = listRolePermissions.Where(x => x.MenuName == "Specialist").FirstOrDefault();
            if (oSpecialist != null)
            {
                sMenuName.Value = oSpecialist.MenuName;
                sSelect.Checked = oSpecialist.IsSelect == true ? true : false;
                sInsert.Checked = oSpecialist.IsInsert == true ? true : false;
                sUpdate.Checked = oSpecialist.IsUpdate == true ? true : false;
                sDelete.Checked = oSpecialist.IsDelete == true ? true : false;
            }
            var oDoctor = listRolePermissions.Where(x => x.MenuName == "Doctor").FirstOrDefault();
            if (oDoctor != null)
            {
                dMenuName.Value = oDoctor.MenuName;
                dSelect.Checked = oDoctor.IsSelect == true ? true : false;
                dInsert.Checked = oDoctor.IsInsert == true ? true : false;
                dUpdate.Checked = oDoctor.IsUpdate == true ? true : false;
                dDelete.Checked = oDoctor.IsDelete == true ? true : false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            obj = new Model1();
            var nUserId = Convert.ToInt32(userId.Value);
            var listRolePermissions = obj.RolePermissions.Where(x => x.UserId == nUserId).ToList();
            obj.RolePermissions.RemoveRange(listRolePermissions);

            var oUser = obj.Users.Where(x => x.UserId == nUserId).FirstOrDefault();

            var newList = new List<RolePermission>();

            var oSpecialist = new RolePermission();
            oSpecialist.UserId = oUser.UserId;
            oSpecialist.RoleId = oUser.RoleId;
            oSpecialist.MenuName = sMenuName.Value;
            oSpecialist.IsSelect = sSelect.Checked;
            oSpecialist.IsInsert = sInsert.Checked;
            oSpecialist.IsUpdate = sUpdate.Checked;
            oSpecialist.IsDelete = sDelete.Checked;
            newList.Add(oSpecialist);

            var oDoctor = new RolePermission();
            oDoctor.UserId = oUser.UserId;
            oDoctor.RoleId = oUser.RoleId;
            oDoctor.MenuName = dMenuName.Value;
            oDoctor.IsSelect = dSelect.Checked;
            oDoctor.IsInsert = dInsert.Checked;
            oDoctor.IsUpdate = dUpdate.Checked;
            oDoctor.IsDelete = dDelete.Checked;
            newList.Add(oDoctor);

            obj.RolePermissions.AddRange(newList);
            obj.SaveChanges();

            Response.Redirect("~/Admin/Users.aspx");
        }
    }
}