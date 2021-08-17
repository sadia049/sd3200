using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DAL.Entity.products
{
    public class category
    {

       



        
        [Key]
        public int categoryId { get; set; }
        [Required(ErrorMessage = "Category Name Required")]
        [StringLength(100, MinimumLength = 3)]
        public string categoryName { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }



    }
}
