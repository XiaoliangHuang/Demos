using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfece
{
    public class Host : IPluginHost
    {
        private string _name;

        private string _description;

        private string _version;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

    }
}
