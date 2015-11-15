using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Nokkelord.Models;

namespace Nokkelord.Categories
{
    public partial class Default : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Category entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<Nokkelord.Models.Category> GetData()
        {
            return _db.Categories;
        }
    }
}

