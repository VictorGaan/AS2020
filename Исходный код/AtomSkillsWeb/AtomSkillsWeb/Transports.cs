namespace AtomSkillsWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transports()
        {
            Orders = new HashSet<Orders>();
            TransportImages = new HashSet<TransportImages>();
        }

        public int ID { get; set; }

        public int IDBrand { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public long Year { get; set; }

        [Required]
        [StringLength(50)]
        public string Number { get; set; }

        public DateTime Date { get; set; }

        public DateTime? DateOff { get; set; }

        public virtual Brands Brands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportImages> TransportImages { get; set; }
    }
}
