using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Models
{
    public class Products
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public string ProductCategory { get; set; } = String.Empty;
        public string? Description { get; set; } = String.Empty;
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float? Length { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float? Width { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float? Height { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public float? Price { get; set; }

        public String SEOTags { get; set; } = String.Empty;
    }
}
