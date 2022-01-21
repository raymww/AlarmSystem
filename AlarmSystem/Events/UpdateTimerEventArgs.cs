using AlarmSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystem.Events
{
    class UpdateTimerEventArgs : EventArgs
    {
        //ArrayList
        private List<ClassAlarm> timers = new List<ClassAlarm>();

        public UpdateTimerEventArgs(List<ClassAlarm> c)
        {
            timers = c;
        }

        public List<ClassAlarm> GetTimers
        {
            get
            {
                return timers;
            }
        }

    }
}
