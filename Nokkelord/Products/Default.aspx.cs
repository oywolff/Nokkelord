using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Nokkelord.Models;

namespace Nokkelord.Products
{
    public partial class Default : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Product entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<Nokkelord.Models.Product> GetData()
        {
            return _db.Products.Include(m => m.Category);
        }
    }
}

