namespace NinePoint.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobInfo")]
    public partial class JobInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? LastExcutionDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
