using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Label = System.Reflection.Emit.Label;

namespace WebPartSitiosWeb.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : WebPart
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            var sitio = SPContext.Current.Site;
            Label1.Text = sitio.Url;
            lstSitios.Items.Clear();

            foreach (SPWeb web in sitio.AllWebs)
            {
                lstSitios.Items.Add(new ListItem(web.Title,web.ID.ToString()));
            }
        }
        
        }
    }

