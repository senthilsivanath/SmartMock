using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MockTransportAPI.Enums;
using MockTransportAPI.Entities;
using MockTransportAPI.Repository;

namespace MockTransportAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public TripDetailResult GetSchedule([FromUri]DateTime scheduleDate, string locationId,
            TripStatus tripStatus, DateTime slotStartTime, DateTime slotEndTime, ServiceType serviceType,
            ScheduleType scheduleType, string filter, string sortBy, int limit, int offset, List<string> fields)
        {
            XMLProcess pro = new XMLProcess();
           // pro.CreateFile();

            return new TripDetailResult();

        }

        [HttpGet]
        public TripDetailResult GetSchedule()
        {

            XMLProcess pro = new XMLProcess();
       
            return new TripDetailResult();

        }
    }
}