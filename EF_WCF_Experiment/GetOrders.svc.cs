using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EF_WCF_Experiment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IGetOrders
    {
        private Messages_TestEntities db = new Messages_TestEntities();
        public Order GetData(int value)
        {
            return db.Orders.Single(o => o.OrderId == value);
        }

        public string SetData(string orderMessage)
        {
            string success;
            Order newOrder = new Order();
            newOrder.MessageContent = orderMessage;
            try {
                db.Orders.Add(newOrder);
                db.SaveChanges();
                success = "Your order saved.";
            }
            catch(Exception e)
            {
                success = "Your order save failed. " + e.ToString();
            }
            return success;
        }
    }
}
