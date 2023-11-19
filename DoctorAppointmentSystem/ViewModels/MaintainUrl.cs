using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorAppointmentSystem.ViewModels
{
    public class MaintainUrl
    {
        public int RoleId { get; set; }
        public int PageId { get; set; }
        public string Page_Name { get; set; }
        public string Page_Handler { get; set; }
        public string Page_Url { get; set; }

        public List<MaintainUrl> Get()
        {
            List<MaintainUrl> urls = new List<MaintainUrl>()
            {
                new MaintainUrl() { RoleId = 1, PageId = 1, Page_Name = "Home", Page_Handler = "/Admin/Home.aspx", Page_Url = "/admin/home"},
                new MaintainUrl() { RoleId = 1, PageId = 2, Page_Name = "Role List", Page_Handler = "/Admin/Roles.aspx", Page_Url = "/roles"},
                new MaintainUrl() { RoleId = 1, PageId = 3, Page_Name = "User List", Page_Handler = "/Admin/Users.aspx", Page_Url = "/users"},
                new MaintainUrl() { RoleId = 1, PageId = 4, Page_Name = "Rele Permission List", Page_Handler = "/Admin/RolePermissions.aspx", Page_Url = "/permissions"},

                new MaintainUrl() { RoleId = 2, PageId = 11, Page_Name = "Doctor List", Page_Handler = "/AppointmentDetails/DoctorList.aspx", Page_Url = "/Doctors"},
                new MaintainUrl() { RoleId = 2, PageId = 12, Page_Name = "Doctor Insert", Page_Handler = "/AppointmentDetails/DoctorInsert.aspx", Page_Url = "/Doctor"},
                new MaintainUrl() { RoleId = 2, PageId = 13, Page_Name = "Specialist List", Page_Handler = "/AppointmentDetails/SpecialistList.aspx", Page_Url = "/SpecialistList"},
                //new MaintainUrl() { RoleId = 2, PageId = 14, Page_Name = "Specialist", Page_Handler = "/AppointmentDetails/SpecialistList.aspx", Page_Url = "/Specialist"},
                new MaintainUrl() { RoleId = 2, PageId = 15, Page_Name = "Home", Page_Handler = "/AppointmentDetails/Home.aspx", Page_Url = "/AppointmentDetails/home"},
                new MaintainUrl() { RoleId = 2, PageId = 16, Page_Name = "Login", Page_Handler = "Login.aspx", Page_Url = "/login"},
                new MaintainUrl() { RoleId = 2, PageId = 16, Page_Name = "Login", Page_Handler = "Login.aspx", Page_Url = "/"}
            };

            return urls;
        }
    }
}