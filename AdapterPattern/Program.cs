using System;

namespace DoFactory.GangOfFour.Adapter.Structural
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    interface ITarget
    {
        void Request();
    }

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() 
        {
            // Create adapter and place a request
            ITarget target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}

/* Output

Called SpecificRequest()

*/
