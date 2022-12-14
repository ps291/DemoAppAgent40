using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService40
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService40" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFService40.svc or WCFService40.svc.cs at the Solution Explorer and start debugging.
    public class WCFService40 : IWCFService40
    {
        public List<TR_Agent> AgentData()
        {
            AgentDBEntities db = new AgentDBEntities();
            return db.TR_Agent.ToList();
        }

        public string UpdateAgentData(string id)
        {
            AgentDBEntities db = new AgentDBEntities();
            List<TR_Agent> t = db.TR_Agent.ToList();
            t[0].AgentName = "DEMO";
            db.SaveChanges();

            return "Updated Successfully";
        }
    }
}
