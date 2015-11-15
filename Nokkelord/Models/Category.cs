using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Nokkelord.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display]  // Use the display attribute to indicate the data text field for the DropDownList
        public string Name { get; set; }
    }    
}