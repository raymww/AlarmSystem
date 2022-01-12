using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystem
{
    class ClassAlarm
    {
        public string date;
        public string time;

        public ClassAlarm()
        {
            date = "";
            time = "";
        }

        public ClassAlarm(string date, string time)
        {
            this.date = date;
            this.time = time;
        }

        public string getDate()
        {
            return date;
        }

        public string getTime()
        {
            return time;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public void setTime(string time)
        {
            this.time = time;
        }
    }
}
