using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockTransportAPI.Enums;

namespace MockTransportAPI.Entities
{
    /// <summary>
    /// shipment (eg { get; set; } grocery web order) detailsRepository to be stored for delivery tracking. 
    /// </summary>
    public class Shipment
    {
        /// <summary>
        /// booking reference number (eg. UID, web orderID).
        /// </summary>
        public string bookingReferenceID { get; set; }
 
        /// <summary>
        /// planned time of delivery departure for shipment.
        /// </summary>
        public DateTime plannedArrivalTime { get; set; }
 
        /// <summary>
        /// planned time of delivery arrival for shipment.
        /// </summary>
        public DateTime plannedDepartureTime { get; set; }

        /// <summary>
        /// Latest estimated time of arrival for shipment.
        /// </summary>
        public DateTime estimatedArrivalTime { get; set; }

        /// <summary>
        /// Actual time of arrival for shipment
        /// </summary>
        public DateTime actualArrivalTime { get; set; }

        /// <summary>
        /// Delivery status for the shipment 
        /// </summary>
        public DeliveryStatus deliveryStatus { get; set; }

        /// <summary>
        /// Last updated time for this shipment.
        /// </summary>
        public DateTime lastUpdatedTime { get; set; }

        /// <summary>
        ///Calculated slot delay time interval in hh:mm:ss. 
        /// </summary>
        public DateTime slotDelay { get; set; }
    }
}