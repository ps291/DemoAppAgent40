using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting40
{
    public partial class MongoDBCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //try
            //{
            //    var dbclient = new MongoClient();

            //    var connectionString = "mongodb://127.0.0.1:27017";
            //    dbclient = new MongoClient(connectionString);

            //    var database = dbclient.GetServer();
            //    var d=database.GetDatabase(connectionString);
            //    // Database List  
            //    //var dbList = dbclient.ListDatabases().ToList();

            //    //Console.WriteLine("The list of databases are :");

            //    //foreach (var item in dbList)
            //    //{
            //    //    Console.WriteLine(item);

            //    //}
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}