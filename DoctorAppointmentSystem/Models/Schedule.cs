namespace DoctorAppointmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        public int ScheduleID { get; set; }

        public DateTime? ScheduleDate { get; set; }

        public int? SerialNo { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public int? DoctorID { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
