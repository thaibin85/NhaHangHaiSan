using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhaHangHaiSan.Models
{
    public abstract class CommonAbstract
    {
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifidedBy { get; set; }
    }
}