using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using MockTransportAPI.Entities;
using System.IO;
using MockTransportAPI.Enums;
using System.Xml;
using System.Configuration;

namespace MockTransportAPI.Repository
{
    public class XMLProcess
    {
        public TripDetailResult GetVanTripDetails(string vanTripId, string StoreId)
        {
            TripDetailResult result = ReadXML();

            result.resultSubSet = (from item in result.resultSubSet 
                                    where item.tripId.ToLower() == vanTripId.ToLower() && item.locationId.ToLower() == StoreId.ToLower() 
                                    select item).ToList<TripDetail>();

            result.totalMatchedCount = result.resultSubSet.Count;
            return result; 
        }

        private TripDetailResult ReadXML()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(TripDetailResult));
                TripDetailResult tripdetail;
                using (XmlReader reader = XmlReader.Create(GetXMlFile()))
                {
                    tripdetail = (TripDetailResult)ser.Deserialize(reader);
                }

                return tripdetail;
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
                return HttpContext.Current.Server.MapPath("~/App_Data/" + fileName);
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

        public void CreateXMLFile()
        {
            TripDetailResult trpObj = CreateObject();
            XmlSerializer serializer = new XmlSerializer(typeof(TripDetailResult));
            serializer.Serialize(File.Create("D:\\file.xml"), trpObj);
        }

        public TripDetailResult CreateObject()
        {
            List<Shipment> shpment = new List<Shipment>();
            shpment.Add(new Shipment
            {
                bookingReferenceID = "265619",
                plannedArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                plannedDepartureTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                estimatedArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                actualArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                deliveryStatus = DeliveryStatus.PENDING_DELIVERY,
                lastUpdatedTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                slotDelay = DateTime.Parse("2013-04-18 06:00:00.000"),
            });

            shpment.Add(new Shipment
            {
                bookingReferenceID = "265619",
                plannedArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                plannedDepartureTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                estimatedArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                actualArrivalTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                deliveryStatus = DeliveryStatus.PENDING_DELIVERY,
                lastUpdatedTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                slotDelay = DateTime.Parse("2013-04-18 06:00:00.000"),
            });
            List<TripDetail> trp = new List<TripDetail>();
            trp.Add(new TripDetail {
                actualEndTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                actualStartTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                departureDelay = DateTime.Parse("2013-04-18 06:00:00.000"),
                driverBadgeId = "9876",
                driverContactNumber ="7209817659",
                driverName = "Nicol Smith",
                locationId = "IB2",
                plannedEndTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                plannedStartTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                serviceType = ServiceType.DOTCOM_VAN_DELIVERY,
                shipments = shpment,
                trackingNotes = " Test tracking note",
                tripDataConfidence =  DataConfidence.MEDIUM,
                tripId = "1A",
                tripName = "1B",
                tripStatus = TripStatus.STARTED,
                vanRegNo ="UK 2010 CT"
            });
            trp.Add(new TripDetail
            {
                actualEndTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                actualStartTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                departureDelay = DateTime.Parse("2013-04-18 06:00:00.000"),
                driverBadgeId = "9876",
                driverContactNumber = "7209817659",
                driverName = "Nicol Smith",
                locationId = "IB2",
                plannedEndTime = DateTime.Parse("2013-04-18 08:00:00.000"),
                plannedStartTime = DateTime.Parse("2013-04-18 06:00:00.000"),
                serviceType = ServiceType.DOTCOM_VAN_DELIVERY,
                shipments = new List<Shipment>(),
                trackingNotes = " Test tracking note",
                tripDataConfidence = DataConfidence.MEDIUM,
                tripId = "1A",
                tripName = "1B",
                tripStatus = TripStatus.STARTED,
                vanRegNo = "UK 2010 CT"
            });
           
            return new TripDetailResult
            {
                resultSubSet = trp,
                totalMatchedCount = 2

            };
        }
    }
}