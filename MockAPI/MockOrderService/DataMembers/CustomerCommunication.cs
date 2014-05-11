using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MockOrderService.DataMembers
{
    [DataContract]
    public class CustomerCommunication
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int	ID	{get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime CommunicationTime 	{get; set;}

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string CommunicationDetail	{get; set;}

    }
}