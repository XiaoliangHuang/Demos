using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfece;

namespace ArsenalPlugin
{
    public class ArsenalPlugin : IPlugin
    {
        private IPluginHost _host;

        public IPluginHost Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        public string Name {
            get { return "Arsenal Plugin"; }
        }

        public string Description{
            get { return "Arsenal Plugin implement"; }
        }

        public string Author
        {
            get { return "Wenger"; }
        }


        public string Version
        {
            get { return "1.0.0"; }
        }

        public void SayHello()
        {
            string introduce = string.Format("Hello, this is {0} with version {1}, I am {2}, I am a Plugin of {3}-v {4} ", Name, Version, Author, this._host.Name, this._host.Version);
            Console.WriteLine(introduce); 
        }
    }
}
