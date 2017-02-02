namespace CodFirst.DBCom
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kayitno { get; set; }

        [StringLength(20)]
        public string Adisoyadi { get; set; }

        public int? Sure { get; set; }

        public int? Ucret { get; set; }
    }
}
