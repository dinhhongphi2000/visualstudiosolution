namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int ID { get; set; }

        [StringLength(50,ErrorMessage ="Tên không được vượt quá 50 kí tự")]
        [Required(ErrorMessage ="Bạn chưa nhập tên Sản phẩm")]
        [Display(Name="Tên sản phẩm")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name="Tên nặc danh")]
        public string Alias { get; set; }
        [Display(Name="Nhánh cha")]
        public int? ParentID { get; set; }
        [Display(Name="Ngày tạo")]
        public DateTime? CreateDate { get; set; }

        public int? Order { get; set; }

        public bool? Status { get; set; }
    }
}
