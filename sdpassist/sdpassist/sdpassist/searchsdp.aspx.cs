using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sdpassist
{
    public partial class searchsdp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SDPOPSService.SDPOPSServiceClient client = new SDPOPSService.SDPOPSServiceClient();
            SDPOPSService.Sdp[] lst = client.searchSdpbyName("uat", "test");
            grdsdpsearch.DataSource = lst;
            grdsdpsearch.DataBind();

        }
    }
}