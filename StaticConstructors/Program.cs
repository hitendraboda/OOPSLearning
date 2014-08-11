using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructors
{
    /*
        Defination  : A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only. 
                     It is called automatically before the first instance is created or any static members are referenced.
     
        Properties   :Static constructors have the following properties:
                    A static constructor does not take access modifiers or have parameters.
                    A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
                    A static constructor cannot be called directly.
                    The user has no control on when the static constructor is executed in the program.
                    A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
                    Static constructors are also useful when creating wrapper classes for unmanaged code, when the constructor can call the LoadLibrary method.
                    If a static constructor throws an exception, the runtime will not invoke it a second time, and the type will remain uninitialized for the lifetime of the application domain in which your program is running.
     */
    public class Bus
    {
        // Static variable used by all Bus instances. 
        // Represents the time the first bus of the day starts its route. 
        protected static readonly DateTime globalStartTime;

        // Property for the number of each bus. 
        protected int RouteNumber { get; set; }

        // Static constructor to initialize the static variable. 
        // It is invoked before the first instance constructor is run. 
        static Bus()
        {
            globalStartTime = DateTime.Now;

            // The following statement produces the first line of output,  
            // and the line occurs only once.
            Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }

        // Instance constructor. 
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }

        // Instance method. 
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            // For demonstration purposes we treat milliseconds as minutes to simulate 
            // actual bus times. Do not do this in your actual bus schedule program!
            Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                    this.RouteNumber,
                                    elapsedTime.TotalMilliseconds,
                                    globalStartTime.ToShortTimeString());
        }
    }

    class TestBus
    {
        static void Main()
        {
            // The creation of this instance activates the static constructor.
            Bus bus1 = new Bus(71);

            // Create a second bus.
            Bus bus2 = new Bus(72);

            // Send bus1 on its way.
            bus1.Drive();

            // Wait for bus2 to warm up.
            System.Threading.Thread.Sleep(25);

            // Send bus2 on its way.
            bus2.Drive();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
    /* Sample output:
        Static constructor sets global start time to 3:57:08 PM.
        Bus #71 is created.
        Bus #72 is created.
        71 is starting its route 6.00 minutes after global start time 3:57 PM.
        72 is starting its route 31.00 minutes after global start time 3:57 PM.      
   */
}
