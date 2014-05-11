using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MockTransportAPI.Helper
{
    public static class Util 
    {
        public static string GetFilterValue(string filter, string key)
        {
            string[] filterKeyValue = filter.Split('|');
            Dictionary<string, string> filteritems = new Dictionary<string, string>();
            foreach (var item in filterKeyValue)
            {
                string[] splititem = item.Split(':');
                filteritems.Add(splititem[0], splititem[1]);
            }
            string result;
            filteritems.TryGetValue(key, out result);
            return result;
        }
    }
}
