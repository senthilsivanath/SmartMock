using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MockOrderService.DataMembers
{
    [DataContract]
    public class Order
    {

        /// <summary>
        /// Order Number.
        /// </summary>
        [DataMember]
        public int CustomerOrderId { get; set; }

        
        /// <summary>
        /// Order Number.
        /// </summary>
        [DataMember]
        public string CustomerOrderReference { get; set; }

        /// <summary>
        /// Order Number.
        /// </summary>
        [DataMember]
        public int	ShortOrderNumber {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime	WindowStart {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime	WindowEnd {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string	GridReference {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime	ScheduledArrival {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	AmbientTrayCount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	ChilledTrayCount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	FrozenTrayCount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	WineTrayCount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	DirectParcelCount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Customer	Customer {get; set;}

        /// <summary>
        /// DeliveryInstructions
        /// </summary>
        [DataMember]
        public string DeliveryNotes {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string DeliverySlot {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool DeliveryWithoutBags {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public OrderLines[] Orderlines {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool	CustomerDeliveryStatus {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	DropSequence {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime	DropTime {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	TotalItems {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public double	SubTotalAmount {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public double	Discounts {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	TotalSubstitutedItems {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int TotalOffsaledItems {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string StoreMessage {get; set;}

    }
}