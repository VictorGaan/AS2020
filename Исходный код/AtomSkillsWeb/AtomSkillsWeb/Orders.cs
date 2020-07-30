namespace AtomSkillsWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int IDSupplier { get; set; }

        [Required]
        [StringLength(50)]
        public string AddressFrom { get; set; }

        [Required]
        [StringLength(50)]
        public string AddressTo { get; set; }

        public int IDStatus { get; set; }

        public int IDTrans { get; set; }

        public int IDOperator { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual Statuses Statuses { get; set; }

        public virtual Transports Transports { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
