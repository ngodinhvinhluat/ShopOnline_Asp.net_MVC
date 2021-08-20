namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Xunit;
    using Xunit.Sdk;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }
        //validation attribute MVC
        [StringLength(15, ErrorMessage="Số kí tự tối đa là 15")]
        [Required(ErrorMessage ="Bạn chưa nhập tên danh mục")]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tiêu đề")]
        [StringLength(50)]
        [DisplayName("Tiêu đề")]

        public string Alias { get; set; }
        [DisplayName("Danh mục cha")]
        [Required(ErrorMessage = "Bạn chưa chọn danh mục cha")]
        public int? ParentID { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }
        [DisplayName("Thứ tự")]
        public int? Order { get; set; }
        [DisplayName("Trạng thái")]
        [Required(ErrorMessage = "Bạn chưa chọn trạng thái")]
        public bool? Status { get; set; }
    }
}
