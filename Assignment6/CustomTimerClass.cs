using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class CustomTimerClass
    {
        //contain a public delegate called TimerAlarmHandler 
        //a public event called OnTimerAlarm. 
        //It will also contain a private member variable called stopFlag of type bool and set it to false.

        //also contain three methods. 
        //The first is a method called Run() that will sleep for 1 second and then call a second method to raise an event. 
        //The second method called RaiseTimerAlarm() will check to see if there are any subscribers to the event. 
        //If so, it will create a new TimerEventArgs object and raise the event. 
        //The final method is actually a read/write property called StopFlag the sets the stopFlag member or returns its value.
    }
}
