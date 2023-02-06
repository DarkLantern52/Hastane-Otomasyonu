namespace HospitalAutomation.EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        public int PatientID { get; set; }

        [StringLength(50)]
        public string PatientName { get; set; }

        [StringLength(50)]
        public string PatientSurname { get; set; }

        [StringLength(15)]
        public string PatientTelephone { get; set; }
    }
}
