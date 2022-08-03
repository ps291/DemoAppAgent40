using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting40
{
    public partial class WebApiCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://gorest.co.in/public/v2/");
                    //HTTP GET
                    var responseTask = client.GetAsync("users");
                    responseTask.Wait();

                    var result = responseTask.Result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}