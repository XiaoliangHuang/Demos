using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfece
{
    public interface IPlugin
    {
        IPluginHost Host { get; set; }

        string Name { get; }

        string Description { get; }

        string Author { get; }

        string Version { get; }

        void SayHello();

    }
}
