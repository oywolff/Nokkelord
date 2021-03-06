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

namespace Nokkelord.Keywords
{
    public partial class Delete : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // This is the Delete methd to delete the selected Keyword item
        // USAGE: <asp:FormView DeleteMethod="DeleteItem">
        public void DeleteItem(int KeywordID)
        {
            using (_db)
            {
                var item = _db.Keywords.Find(KeywordID);

                if (item != null)
                {
                    _db.Keywords.Remove(item);
                    _db.SaveChanges();
                }
            }
            Response.Redirect("../Default");
        }

        // This is the Select methd to selects a single Keyword item with the id
        // USAGE: <asp:FormView SelectMethod="GetItem">
        public Nokkelord.Models.Keyword GetItem([FriendlyUrlSegmentsAttribute(0)]int? KeywordID)
        {
            if (KeywordID == null)
            {
                return null;
            }

            using (_db)
            {
	            return _db.Keywords.Where(m => m.KeywordID == KeywordID).FirstOrDefault();
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

