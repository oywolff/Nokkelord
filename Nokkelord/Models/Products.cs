using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Nokkelord.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        // The CategoryId property is scaffolded. It's what
        // gets set in the DropDownList.
        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        // The Category property is the navigation property.
        // This property is not scaffolded but it creates the 
        // association between products and categories.
        public Category Category { get; set; }
    }
}