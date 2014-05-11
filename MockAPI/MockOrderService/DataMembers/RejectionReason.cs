using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MockOrderService.DataMembers
{
    [DataContract]
    public enum RejectionReason
    {
        [EnumMember]
        Broken,
        [EnumMember]
        NotInGoodShape,
    }
}