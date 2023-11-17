﻿using static NuGet.Packaging.PackagingConstants;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab08.Areas.Admin.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Price { get; set; }
        // Khóa ngoại tới Orders
        public Orders Order { get; set; }
        // Khóa ngoại tới Product
        public Product Product { get; set; }
    }
}
