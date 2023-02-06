namespace HospitalAutomation.EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("viewAppointment")]
    public partial class viewAppointment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppointmentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientID { get; set; }

        [StringLength(50)]
        public string PatientName { get; set; }

        [Column(TypeName = "text")]
        public string Opinion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorID { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string DoctorBranch { get; set; }
    }
}
