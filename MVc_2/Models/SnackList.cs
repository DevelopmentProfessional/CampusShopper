namespace MVc_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SnackList")]
    public partial class SnackList
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SnackID { get; set; }

        [StringLength(50)]
        public string AccountID { get; set; }

        [StringLength(50)]
        public string InvoiceID { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? price { get; set; }
    }
}
