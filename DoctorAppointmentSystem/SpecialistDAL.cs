using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoctorAppointmentSystem
{
    public class SpecialistDAL
    {
        public DataTable GetSpecialist()
        {
            string constr = "Data Source=DESKTOP-9QLAIUL;Initial Catalog=DoctorAppointment; Integrated Security=True;";
            string query = "Select SpecialistID, SpecialistName from Specialist";
            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public void AddSpecialist(SpecialistClass s)
        {
            string constr = "Data Source=DESKTOP-9QLAIUL;Initial Catalog=DoctorAppointment; Integrated Security=True;";
            string query = "Insert into Specialist(SpecialistName) values (@SpecialistName)";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand com = new SqlCommand(query, con);

            com.Parameters.AddWithValue("@SpecialistName", s.SpecialistName);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}