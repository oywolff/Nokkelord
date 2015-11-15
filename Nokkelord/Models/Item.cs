using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nokkelord.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }
        public int No_ { get; set; }
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

    }
}