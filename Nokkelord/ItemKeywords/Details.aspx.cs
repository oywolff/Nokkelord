﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using Nokkelord.Models;

namespace Nokkelord.ItemKeywords
{
    public partial class Details : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // This is the Select methd to selects a single ItemKeyword item with the id
        // USAGE: <asp:FormView SelectMethod="GetItem">
        public Nokkelord.Models.ItemKeyword GetItem([FriendlyUrlSegmentsAttribute(0)]int? ItemKeywordID)
        {
            if (ItemKeywordID == null)
            {
                return null;
            }

            using (_db)
            {
	            return _db.ItemKeywords.Where(m => m.ItemKeywordID == ItemKeywordID).Include(m => m.Keyword).FirstOrDefault();
            }
        }

        protected void ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Cancel", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("../Default");
            }
        }
    }
}

