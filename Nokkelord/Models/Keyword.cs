using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nokkelord.Models
{
    public class Keyword
    {
        [ScaffoldColumn(false)]
        public int KeywordID { get; set; }

        [Required, StringLength(100), Display(Name = "Nøkkelord")]
        public string KeywordName { get; set; }

        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

        public virtual ICollection<ItemKeyword> IItemKeyword { get; set; }
    }
}