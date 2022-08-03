using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting40
{
    public partial class WCFCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client wcfServiceClient = new ServiceReference1.Service1Client();
                var data = wcfServiceClient.GetData(10001);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}