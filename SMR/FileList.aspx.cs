using Core.CM;
using Core.Files;
using SMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMR
{
    public partial class FileList : PageBase
    {
        List<Files> ListFiles = new List<Files>();
        protected void Page_Load(object sender, EventArgs e)
        {
             int _ID;
             if (int.TryParse(Request.QueryString["ID"], out _ID))
             {
                 var N = new PagesRepository();
                 var F= new  FilesRepository();
                 var SinglePage = N.ListPages(_ID).SingleOrDefault();
                 if (SinglePage != null)
                 {
                     ltrTitle.Text = SinglePage.Title;
                     ListFiles = F.ListGalleryFiles(SinglePage.GalleryID);
                     rptFileGroups.DataSource = ListFiles.GroupBy(g => g.FileName).Select(s => new Files { FileName=s.Key}); 
                     rptFileGroups.DataBind();
                 }
             }
        }

        protected void rptFileGroups_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var GroupName = ((Files)e.Item.DataItem).FileName;
                var SubList = ListFiles.Where(w => w.FileName == GroupName);
                if (SubList.Any())
                {
                    var rpt = (Repeater)e.Item.FindControl("rptFiles");
                    rpt.DataSource = SubList;
                    rpt.DataBind();

                }
            }
        }
    }
}