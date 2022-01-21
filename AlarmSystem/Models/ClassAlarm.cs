using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystem
{
    public class ClassAlarm
    {
        public string date{get; set;}
        public string time{get; set;}
        public string alarmName{get; set;}

        public ClassAlarm()
        {

        }

        public ClassAlarm(string date, string time, string alarmName)
        {
            this.date = date;
            this.time = time;
            this.alarmName = alarmName;
        }
    }
}
