namespace CodFirst.DBCom
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ogrenci")]
    public partial class Ogrenci
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ogrno { get; set; }

        [StringLength(20)]
        public string Adi { get; set; }

        [StringLength(20)]
        public string Soyadi { get; set; }

        public DateTime? DogumTarihi { get; set; }
    }
}
