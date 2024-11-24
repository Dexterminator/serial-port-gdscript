# GdScript serial port comms
Based on https://youtu.be/nOKno82_gd0?si=i7zCyCndsfXXC8QI

### With the following additions:
- Use an Autoload in gdscript to call the C# SerialPort functions (allowing you to keep using GdScript as your main language).
- Add the toggle mono build plugin so that the C# build can be turned off (since we're only using one file that won't change); shaves some time off each run.

### Prerequisites
- .NET version of Godot 4
- .NET runtime installed

### Setup (summarized from video):
1. Make sure there is a `your-project-name.csproj` file (should be auto created when you make a C# script)
2. Install the System.IO.Ports .NET package: `dotnet add package System.IO.Ports --version 7.0.0`
3. Activate the Mono Build Toggler plugin
