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
    public partial class Edit : System.Web.UI.Page
    {
		protected Nokkelord.Models.NokkelContext _db = new Nokkelord.Models.NokkelContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // This is the Update methd to update the selected ItemKeyword item
        // USAGE: <asp:FormView UpdateMethod="UpdateItem">
        public void UpdateItem(int  ItemKeywordID)
        {
            using (_db)
            {
                var item = _db.ItemKeywords.Find(ItemKeywordID);

                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", ItemKeywordID));
                    return;
                }

                TryUpdateModel(item);

                if (ModelState.IsValid)
                {
                    // Save changes here
                    _db.SaveChanges();
                    Response.Redirect("../Default");
                }
            }
        }

        // This is the Select method to selects a single ItemKeyword item with the id
        // USAGE: <asp:FormView SelectMethod="GetItem">
        public Nokkelord.Models.ItemKeyword GetItem([FriendlyUrlSegmentsAttribute(0)]int? ItemKeywordID)
        {
            if (ItemKeywordID == null)
            {
                return null;
            }

            using (_db)
            {
                return _db.ItemKeywords.Find(ItemKeywordID);
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
