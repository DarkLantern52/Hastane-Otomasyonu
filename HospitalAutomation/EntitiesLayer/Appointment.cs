namespace HospitalAutomation.EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int AppointmentID { get; set; }

        public int? PatientID { get; set; }

        public int? DoctorID { get; set; }

        [Column(TypeName = "text")]
        public string Opinion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
