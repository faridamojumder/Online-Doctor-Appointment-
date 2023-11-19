using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorAppointmentSystem.ViewModels
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }

        public List<Menu> Get()
        {
            List<Menu> listMenu = new List<Menu>()
            {
                new Menu() { MenuId = 1, MenuName = "Specialist"},
                new Menu() { MenuId = 2, MenuName = "Doctor"}
            };

            return listMenu;
        }
    }
}