using System;
using System.ServiceModel;
using WCFExample;

namespace WCFHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host *****");
            using (var serviceHost = new ServiceHost(typeof (MagicEightBallService)))
            {
                // Open the host and start listening for incoming messages.    
                serviceHost.Open();

                // Display info
                DisplayHostInfo(serviceHost);

                // Keep the service running until the Enter key is pressed.    
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }

        private static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");
            foreach (var se in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", se.Address);
                Console.WriteLine("Binding: {0}", se.Binding.Name);
                Console.WriteLine("Contract: {0}", se.Contract.Name);
                Console.WriteLine();
            }
            Console.WriteLine("**********************");
        }
    }
}