using System.Collections.Generic;
using System.Data.Entity;

namespace Nokkelord.Models
{
    public class NokkelOrdDatabaseInitializer : DropCreateDatabaseIfModelChanges<NokkelContext>
    {
        protected override void Seed(NokkelContext context)
        {
            GetKeywords().ForEach(c => context.Keywords.Add(c));
            GetItemKeywords().ForEach(p => context.ItemKeywords.Add(p));
        }

        public static List<Keyword> GetKeywords()
        {
            var keywords = new List<Keyword> {
                new Keyword
                {
                    KeywordID=1,
                    KeywordName="Sukker",
                    Description="SukkerKeyword"
                },
                    new Keyword
                {
                    KeywordID=2,
                    KeywordName="Salt",
                    Description="saltkeyword"
                }
            };
            return keywords;
        }



        public static List<ItemKeyword> GetItemKeywords()
        {
            var itemkeywords = new List<ItemKeyword> {
                new ItemKeyword
                {
                    ItemKeywordID=1,
                    ItemKeywordName="SukkerVare",
                    ItemNo=105007983,
                    Description="D3",
                    KeywordID=1
                },
               new ItemKeyword
                {
                    ItemKeywordID=2,
                    ItemKeywordName="SaltVare",
                    ItemNo=105007980,
                    Description="D3",
                    KeywordID=2
                }
            };
            return itemkeywords;
        }

















    }
}