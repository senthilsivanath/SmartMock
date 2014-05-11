using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MockTransportAPI.Repository;
using MockTransportAPI.Entities;
using MockTransportAPI.Enums;
using MockTransportAPI.Helper;
using System.Web.Http.ModelBinding;


namespace MockTransportAPI.Controllers
{
    public class TransportController : ApiController
    {   
        [HttpGet]
        public TripDetailResult getSchedule(DateTime scheduleDate, string locationId, TripStatus? tripStatus = null,
            DateTime? slotStartTime = null, DateTime? slotEndTime = null, ServiceType? serviceType = null,
            ScheduleType? scheduleType = null, string filter = "",
            string sortBy = "", int limit = 0, int offset = 0, [ModelBinder] List<string> fields = null)
        {
            XMLProcess pro = new XMLProcess();
            TripDetailResult result = pro.GetVanTripDetails(Util.GetFilterValue(filter, "VanTripId"), locationId);
            return result;
        }

    }
}
