# Demo to show dynamically load plugins using Reflect #
---

The Solution contains 4 projects

## Project Structure: ##
```
--|
  |--PluginHost
  |--Common
  |--ArsenalPlugin
  |--ChelsePlugin
```

- `Common` defines the interfaces
- `PluginHost` is the host to load plugins and call plugsin's method
- `ArsenalPlugin` and `ChelsePlugin` are 2 plugins implemented the interface and will build as 2 Dlls


## Usage: ##

1. Clone and build the solution
2. Copyt the `PluginHost.exe` and `Command.dll` to a `<folder>`
3. Create an sub folder `<plugins>` in `<folder>` and copy the built out dlls `ArsenalPlugin.dll` `ChelsePlugin.dll` to the `<plugins>` folder
4. Run the `PluginHost.exe`