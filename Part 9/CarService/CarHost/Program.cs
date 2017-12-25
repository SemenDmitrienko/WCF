using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CarHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(CarService.CarService)))
            {
                host.Open();

                Console.WriteLine("Host started...");
                Console.ReadLine();
            }
        }
    }
}
