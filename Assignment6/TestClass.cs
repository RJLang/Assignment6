using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TestClass
    {
        

        static void Main(string[] args)
        {
            //Create an object of type CustomTimerClass. 
            //Then create an object of type DisplayMessageClass 
            //an object of type LogMessageClass. 
            //Call the Run() method in the CustomTimerClass object.
            var myTimer = new CustomTimerClass();
            var display = new DisplayMessageClass(myTimer);
            var log = new LogMessageClass(myTimer);

            myTimer.Run();
            //myTimer.OnTimerAlarm(display);
            display.Run();

           

            



        //TimerEventArgs date;
        //Console.WriteLine($"{date.FormatTime.ToString()}");




    }
    }
}
