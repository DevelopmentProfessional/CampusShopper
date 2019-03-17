namespace MVc_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string InvoiceID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
