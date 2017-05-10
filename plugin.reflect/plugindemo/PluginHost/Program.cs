using System;
using CommonInterfece;

namespace plugindemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Programs to show Dynamically Load Plugins with C# Reflect");
            PluginManager manager = new PluginManager();

            Console.WriteLine("Host:");
            Console.WriteLine("Name: " + manager.Host.Name);
            Console.WriteLine("Version: " + manager.Host.Version);

            if (manager.Plugins != null && manager.Plugins.Count > 0)
            {
                foreach(IPlugin plugin in manager.Plugins)
                {
                    plugin.SayHello();
                }
            }

            Console.WriteLine("Press Any Key to Exist:");
            Console.ReadKey();

        }
    }
}