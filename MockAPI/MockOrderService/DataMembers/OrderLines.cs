using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MockOrderService.DataMembers
{
    [DataContract]
    public class OrderLines
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int OrderLineId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Barcode {get; set;}
	
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Description {get; set;}
	
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PickedQuantity {get; set;}
	
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool	IsSubstitued {get; set;}
	
        /// <summary>
        ///	e.g. Customer has asked for Amul Butter 250 gm. Due to unavailability picker picked Nandini Butter 250 gm. So this field will have the value Amul Butter 250 gm. 
        /// </summary>
        [DataMember]
        public string SubstitutedFor {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int RejectedQuantity {get; set;}
	
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public RejectionReason	RejectionReason {get; set;}
	
        /// <summary>
        /// Unit Price	Unit Price in case of Item, Price for weighed Items.
        /// </summary>
        [DataMember]
        public double UnitPrice {get; set;}	

    }
}