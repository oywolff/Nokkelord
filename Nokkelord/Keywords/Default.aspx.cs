using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Nokkelord.Models;

namespace Nokkelord.Keywords
{
    public partial class Default : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Keyword entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<Nokkelord.Models.Keyword> GetData()
        {
            return _db.Keywords;
        }
    }
}

