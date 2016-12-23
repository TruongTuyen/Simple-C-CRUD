namespace CRUD.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhomsp")]
    public partial class nhomsp
    {
        [Key]
        public int manhom { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name ="Tên nhóm")]
        public string tennhom { get; set; }

        [StringLength(250)]
        public string anh { get; set; }
    }
}
