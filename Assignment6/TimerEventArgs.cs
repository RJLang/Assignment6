using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TimerEventArgs
    {
        private DateTime _curTime = new DateTime();
        public string FormatTime { get { return _curTime.ToString("HH:MM:SS.mmm"); } }

        //contain a constructor that will get the current time from the system and save it in a local variable.
        //It will also have a public read-only property that will format the time into HH:MM:SS.mmm and 
        //return this new format as a string.

        public TimerEventArgs()
        {
            _curTime = DateTime.Now;
            //CultureInfo.CreateSpecificCulture("en-US");
            //Console.WriteLine(curTime.ToString("HH:MM:SS.mmm"));
            //formatTime = curTime.ToLongTimeString();
        }


    }
}
