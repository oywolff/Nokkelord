using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nokkelord.Models;
using System.Web.ModelBinding;

namespace Nokkelord
{
    public partial class ItemKeywordDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<ItemKeyword> GetItemKeyword([QueryString("ItemKeywordID")] int? ItemKeywordId)
        {
            var _db = new Nokkelord.Models.NokkelContext();
            IQueryable<ItemKeyword> query = _db.ItemKeywords;
            if (ItemKeywordId.HasValue && ItemKeywordId > 0)
            {
                query = query.Where(p => p.ItemKeywordID == ItemKeywordId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}