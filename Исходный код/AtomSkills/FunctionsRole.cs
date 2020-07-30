namespace AtomSkills
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FunctionsRole")]
    public partial class FunctionsRole
    {
        public int ID { get; set; }

        public int IDRole { get; set; }

        public int IDFunction { get; set; }

        public virtual Functions Functions { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
