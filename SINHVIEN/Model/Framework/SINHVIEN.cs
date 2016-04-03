namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [Key]
        [StringLength(8)]
        public string MSSV { get; set; }

        [StringLength(40)]
        public string HOTEN { get; set; }

        public DateTime NAMSINH { get; set; }
    }
}
