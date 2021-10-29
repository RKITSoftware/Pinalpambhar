using System;

namespace Event_Demo
{
    #region Class Maths
    class Maths
    {
        // Declare the delegate
        public delegate void SampleDelegate();
        //Declare an event
        public event SampleDelegate SampleEvent;

        #region Method Add
        public void Add(int a, int b)
        {
            // Calling event delegate to check subscription
            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Add Result: {0}", a + b);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        #endregion Method Add

        #region Method Subtract
        public void Subtract(int x, int y)
        {
            // Calling event delegate to check subscription
            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Subtract Result: {0}", x - y);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }
        #endregion Method Subtract
    }
    #endregion Class Maths

    #region Class Operation
    class Operations
    {
        Maths m = new Maths();
        public int a { get; set; }
        public int b { get; set; }

        #region Parameterized Constructor
        public Operations(int x, int y)
        {
            // Subscribe to SampleEvent event
            m.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }
        #endregion Parameterized Constructor

        // SampleEvent Handler
        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");
        }
        public void AddOperation()
        {
            m.Add(a, b);
        }
        public void SubOperation()
        {
            m.Subtract(a, b);
        }
    }
    #endregion Class Operation

    #region Main Class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Events Example****");
            Operations op = new Operations(20, 10);
            op.AddOperation();
            op.SubOperation();
        }
    }
    #endregion Main Class Program
}
