using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaHangHaiSan.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory : CommonAbstract
    {
        public ProductCategory() 
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Icon { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWords { get; set; }
        public int Position { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}