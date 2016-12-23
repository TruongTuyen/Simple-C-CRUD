namespace CRUD.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string tensp { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string mota { get; set; }

        public double gia { get; set; }

        public int soluong { get; set; }

        public int id_nhom { get; set; }
    }
}
