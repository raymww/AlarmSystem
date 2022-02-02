using System;
using AlarmSystem.Events;
using AlarmSystem.Models;
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

        public Boolean repeat { get; set; }

        public List<int> repetition { get; set;}

        public ClassAlarm()
        {
            repeat = false;
        }

        public ClassAlarm(string date, string time, string alarmName)
        {
            this.date = date;
            this.time = time;
            this.alarmName = alarmName;
            repeat = false;
        }

        public static List<ClassAlarm> GetAlarms()
        {
            return new List<ClassAlarm>
            {
               new ClassAlarm("2-2-22", "12:00", "test1"),
            };
        }
    }
}
