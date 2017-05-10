using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;
using CommonInterfece;

namespace plugindemo
{
    public class PluginManager
    {
        private List<IPlugin> _plugins;

        private string pluginPath = @"\Plugins";

        private IPluginHost _host;

        public List<IPlugin> Plugins {
            get { return this._plugins; }
            set {}
        }

        public IPluginHost Host {
            get
            {
                if (this._host == null)
                {
                    InitHost();
                }

                return this._host;
            }
        }

        public PluginManager()
        {
            InitHost();
            LoadPlugins();
        }

        private void InitHost()
        {
            if(this._host == null)
            {
                this._host = new Host
                {
                    Name = "Plugin Host Primary's League",
                    Version = "2017.05.10",
                    Description = "Test Host For Plugin Demo"
                };
            }
        }

        public void LoadPlugins()
        {
            this._plugins = new List<IPlugin>();

            string currentPath = Directory.GetCurrentDirectory() + this.pluginPath;
            string[] filepaths = Directory.GetFiles(currentPath, "*.dll");

            if (filepaths == null)
            {
                Console.WriteLine("No Plugin Detected.");
            }
            else
            {
                Console.WriteLine("Plugins Detected. Loading...");
                
                foreach(string file in filepaths)
                {
                    Console.WriteLine("Begin to Load Assembly" + file);
                    LoadAssembly(file);

                    Console.WriteLine("Assembly Loaded.");
                }
            }
        }

        public void LoadAssembly(string assemblyFile)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyFile);

            Type[] tClass = assembly.GetExportedTypes();
            Type pluginType = typeof(IPlugin);
            
            foreach (Type t in assembly.GetTypes())
            {
                if (pluginType.IsAssignableFrom(t))
                {
                    IPlugin plugin = Activator.CreateInstance(t) as IPlugin;

                    // Set host information
                    plugin.Host = this.Host;

                    this._plugins.Add(plugin);
                }
            }
            
        }
    }


}
