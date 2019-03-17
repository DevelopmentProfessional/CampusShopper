namespace MVc_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Snack")]
    public partial class Snack
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public double? Price { get; set; }
    }
}
