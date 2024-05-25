using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Client
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know anout the existence 
        // of the subsystem. This approach lets you keep the complexity under 
        // control.

        public static void ClientCode(Facade facade)
        {
            System.Console.WriteLine(facade.Operation());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();

            Facade facade = new Facade(subsystem1, subsystem2);


            Client.ClientCode(facade);
        }
    }
}