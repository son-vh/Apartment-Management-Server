namespace NinePoint.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipment")]
    public partial class Equipment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EquipmentName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }

        public int? WarrantyPeriod { get; set; }

        [StringLength(100)]
        public string EquipmentImage { get; set; }

        public int? ResidentId { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
