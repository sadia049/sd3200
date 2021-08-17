using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoapp.Models
{
    public class product
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int productId { get; set; }

        [Required(ErrorMessage ="Product Name is required")]
        [StringLength(100, MinimumLength =3)]
        public string productName { get; set; }

        [Display(Name ="Category")]
        public  int categoryId { get; set; }

        [ForeignKey("categoryId")]
        public virtual Category Categories { get; set; }
        public bool isActive { get; set; }
        public bool isdelete { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        [Required(ErrorMessage ="Description is required")]
        public string description { get; set; }
        public bool isFeatured { get; set; }
        public string image { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage ="Invalid Quantity")]
        public int quanity { get; set; }

        public int price { get; set; }
    }
}