using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockOrderService.DataMembers;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Configuration;

namespace MockOrderService.Repository
{
    public class XMLProcess
    {

        public List<Order> GetOrders(List<string> OrderId)
        {
            List<Order> result =  ReadXML();
            List<Order> returnval = new List<Order>();
            foreach (var ids in OrderId)
            {
                returnval.Add(result.Where(m => m.CustomerOrderReference.ToLower() == ids.ToLower()).FirstOrDefault());
            }
            return returnval;
        }

        private List<Order> ReadXML()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Order>));
                List<Order> orders;
                using (XmlReader reader = XmlReader.Create(GetXMlFile()))
                {
                    orders = (List<Order>)ser.Deserialize(reader);
                }

                return orders;
            }
            catch (XmlException exx)
            {
                throw new Exception(exx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private string GetXMlFile()
        {
            try
            {
                string fileName = ConfigurationManager.AppSettings["XMlFileName"];
                return System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/" + fileName);
            }
            catch (FileNotFoundException e)
            {
                throw new Exception(e.Message);
            }
            catch (FileLoadException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception exx)
            {
                throw new Exception(exx.Message);
            }

        }
    }
}