using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Tools;
using Core.UM;

namespace SMR.Manager
{
    public partial class AdminPage : Models.AdminMasterBase
    {
        List<Permissions> PList;
        protected void Page_Load(object sender, EventArgs e)
        {
            var Pr = new PermissionsRepository();
            LoadPlugins();
            PList = Pr.ListPermissions().Where(w => w.CodeName == "2" && w.IsVisible == true).ToList();
            rptManu.DataSource = PList.Where(w => w.Level == 1).ToList();
            rptManu.DataBind();


        }

       protected void LoadPlugins() 
       { 
           var IncludePlugins= new StringBuilder();
           IncludePlugins.Append(Plugins.bootstrapCSS());
           IncludePlugins.Append(Plugins.normalizeCSS());
           IncludePlugins.Append(Plugins.jqueryJS());
           IncludePlugins.Append(Plugins.modernizrJS());
           IncludePlugins.Append(Plugins.bootstrapJS());
           IncludePlugins.Append(Plugins.jssorJS());
           litPlugins.Text = IncludePlugins.ToString();
       }
       protected void btnLang_Click(object sender, EventArgs e)
       {
           LanguageHandler.ChangLang(sender, e);
       }

       protected void rptManu_ItemDataBound(object sender, RepeaterItemEventArgs e)
       {
           if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType==ListItemType.AlternatingItem)
           {
               var Item = (Permissions)e.Item.DataItem;
               var SubRtp = (Repeater)e.Item.FindControl("rptSubManu");
               var Items = PList.Where(w => w.ParentID == Item.PermissionID).ToList();
               if (Items.Any())
               {
                   SubRtp.DataSource = Items;
                   SubRtp.DataBind();
               }
              
           }
       }
    }
}