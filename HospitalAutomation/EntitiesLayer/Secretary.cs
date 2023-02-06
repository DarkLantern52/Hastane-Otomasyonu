namespace HospitalAutomation.EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Secretary")]
    public partial class Secretary
    {
        public int SecretaryID { get; set; }

        [StringLength(50)]
        public string SecretaryName { get; set; }

        [StringLength(50)]
        public string SecretarySurname { get; set; }
    }
}
