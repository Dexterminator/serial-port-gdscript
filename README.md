# GdScript serial port comms
Based on https://youtu.be/nOKno82_gd0?si=i7zCyCndsfXXC8QI
With the following additions:
- Use an Autoload in gdscript to call the C# SerialPort functions (allowing you to keep using GdScript as your main language).
- Add the toggle mono build plugin so that the C# build can be turned off (since we're only using one file that won't change); shaves some time off each run.
