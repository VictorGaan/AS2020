namespace AtomSkills
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolesUser")]
    public partial class RolesUser
    {
        public int ID { get; set; }

        public int IDUser { get; set; }

        public int IDRole { get; set; }

        public virtual Roles Roles { get; set; }

        public virtual Users Users { get; set; }
    }
}
