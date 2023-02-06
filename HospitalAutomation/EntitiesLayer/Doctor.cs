namespace HospitalAutomation.EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        public int DoctorID { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string DoctorSurname { get; set; }

        [StringLength(15)]
        public string DoctorTelephone { get; set; }

        [StringLength(50)]
        public string DoctorBranch { get; set; }
    }
}
