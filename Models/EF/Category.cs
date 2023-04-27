﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaHangHaiSan.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category() 
        {
            this.News=new HashSet<News>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set;}
        public string Description { get; set;}
        public string SeoTitle { get; set;}
        public string SeoDescription { get; set;}
        public string SeoKeyWords { get; set;}
        public int Position { get; set;}
        public ICollection<News> News { get; set;}
        public ICollection<Posts> Posts { get; set; }

    }
}