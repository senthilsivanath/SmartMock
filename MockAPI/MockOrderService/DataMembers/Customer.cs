using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MockOrderService.DataMembers
{
    [DataContract]
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string CustomerTitle	{get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string CustomerSurname {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Address {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Postcode {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneDaytime {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneEvening {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneMobile {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string CustomerFullName {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] SignaturePoints {get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public CustomerCommunication customerCommunication { get; set; }	
    }
}