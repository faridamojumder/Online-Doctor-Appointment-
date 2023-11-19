namespace DoctorAppointmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int DoctorID { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Fee { get; set; }

        [StringLength(50)]
        public string ServiceType { get; set; }

        public DateTime? ScheduleDate { get; set; }

        [StringLength(500)]
        public string Prescription { get; set; }

        public int? SpecialistID { get; set; }

        public virtual Specialist Specialist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
