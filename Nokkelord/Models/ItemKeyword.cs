using System.ComponentModel.DataAnnotations;

namespace Nokkelord.Models
{
    public class ItemKeyword
    {
        [ScaffoldColumn(false)]
        public int ItemKeywordID { get; set; }

        [Required, StringLength(100), Display(Name = "Varenøkkelordnavn")]
        public string ItemKeywordName { get; set; }

        public int ItemNo { get; set; }

        [Required, StringLength(30), Display(Name = "Beskrivelse "), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? KeywordID { get; set; }

        public virtual Keyword Keyword { get; set; }
    }
}