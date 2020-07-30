namespace AtomSkills
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roles()
        {
            FunctionsRole = new HashSet<FunctionsRole>();
            RolesUser = new HashSet<RolesUser>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SystemName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateFinish { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FunctionsRole> FunctionsRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolesUser> RolesUser { get; set; }
    }
}
