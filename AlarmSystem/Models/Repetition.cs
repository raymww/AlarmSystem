using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystem.Models
{
    class Repetition
    {
        public List<int> pattern { get; set;}

        // the way it works is it's a list of numbers that signify the days between repetition
        // and therefore you can have the alarm repeating in custom ways

        public Repetition()
        {

        }

        public Repetition(List<int> pattern)
        {
            this.pattern = pattern;
        }

    }
}
