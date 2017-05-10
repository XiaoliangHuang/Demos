using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfece
{
    public interface IPluginHost
    {
        string Name { get; set; }

        string Description { get; set; }

        string Version { get; set; }
    }
}
