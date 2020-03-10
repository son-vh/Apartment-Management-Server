namespace NinePoint.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Support")]
    public partial class Support
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SupportType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SupportDate { get; set; }

        [StringLength(100)]
        public string SupportAddress { get; set; }

        [StringLength(100)]
        public string SupportImage { get; set; }

        public int? ResidentId { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
