using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace codedecode
{
    class NistTime
    {
        private string URL = "http://www.hko.gov.hk/cgi-bin/gts/time5a.pr?a=2";
        public DateTime GetNowTime()
        {
            htmlget h = new htmlget(URL);
            Regex regex = new Regex(@"0=(?<timestamp>\d{10})\d+");
            Match match = regex.Match(h.Html);
            if (match.Success)
            {
                return GetTime(match.Groups["timestamp"].Value);
            }
            return DateTime.Now;
        }

        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name=”timeStamp”></param>
        /// <returns></returns>
        private DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime); return dtStart.Add(toNow);
        }
    }
}
