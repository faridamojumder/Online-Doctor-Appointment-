namespace DoctorAppointmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePermission")]
    public partial class RolePermission
    {
        public long RolePermissionId { get; set; }

        public int? RoleId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        public bool? IsSelect { get; set; }

        public bool? IsInsert { get; set; }

        public bool? IsUpdate { get; set; }

        public bool? IsDelete { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
