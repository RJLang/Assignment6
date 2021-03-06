﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class DisplayMessageClass 
    {
        ////Two member variables. 
        ////The first is a private reference to the CustomTimerClass 
        ////he second is a static counter of type int.
        ////create a constructor that accepts a CustomTimerClass argument and save that argument in the private member variable. 
        ////Finally, create a method called DisplayMessage that takes two arguments –
        //    ///a sender object and a TimerEventArgs reference  
        //    ///displays the information from the TimerEventArgs object. 
        //    ///Increment the counter and then check it. 
        //    ///If the counter is >= 0, 
        //    ///set the StopFlag property of the CustomTimerClass object to true.

        private CustomTimerClass _customTimer = new CustomTimerClass();
        static int counter = 0;

        public DisplayMessageClass (CustomTimerClass timer)
        {
            _customTimer = timer;
        }

        public void DisplayMessage (int send, TimerEventArgs args)
        {
            Console.WriteLine($"The current time is: { args.FormatTime}");
            counter += 1;
            if (counter >= 0) { _customTimer.StopFlag = true; }
        }
    }
}
