using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

                // Function and Action
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; 
                string url = "https://services.odata.org/TripPinRESTierService/ResetDataSource";
                string strResult = string.Empty;
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "POST";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();


                string url1 = "https://services.odata.org/TripPinRESTierService/GetNearestAirport(lat = 33, lon = -118)";
                string strResult1 = string.Empty;
                HttpWebRequest webrequest1 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse1 = (HttpWebResponse)webrequest.GetResponse();

                //Querying Data
                string url2 = "https://services.odata.org/TripPinRESTierService/Me/Friends?$filter=Friends/any(f:f/FirstName eq 'Scott')";
                string strResult2 = string.Empty;
                HttpWebRequest webrequest2 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse2 = (HttpWebResponse)webrequest.GetResponse();

                //Querying Data
                string url3 = "https://services.odata.org/TripPinRESTierService/Airports?$filter=contains(Location/Address, 'San Francisco')";
                string strResult3 = string.Empty;
                HttpWebRequest webrequest3 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse3 = (HttpWebResponse)webrequest.GetResponse();

                //Request Etag
                string url4 = "https://services.odata.org/TripPinRESTierService/Airlines";
                string strResult4 = string.Empty;
                HttpWebRequest webrequest4 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse4 = (HttpWebResponse)webrequest.GetResponse();

                //Delete Data
                string url5 = "https://services.odata.org/TripPinRESTierService/People('russellwhyte')";
                string strResult5 = string.Empty;
                HttpWebRequest webrequest5 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "DELETE";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse5 = (HttpWebResponse)webrequest.GetResponse();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}