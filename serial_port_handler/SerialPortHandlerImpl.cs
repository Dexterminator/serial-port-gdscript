using Godot;
using System;
using System.IO.Ports;

public partial class SerialPortHandlerImpl : Node2D
{
	private SerialPort serialPort;

	// TODO: Make baud and port args, and add them from gdscript (can use build var to change values)
	public void InitPort()
	{
		// serialPort = new SerialPort("/dev/cu.usbmodem101", 9600);
		serialPort = new SerialPort();
		serialPort.BaudRate = 9600;
		serialPort.PortName = "/dev/cu.usbmodem101";
		serialPort.Open();
	}

	public string ReadData()
	{
		if (serialPort.IsOpen)
		{
			try
			{
				return serialPort.ReadLine();
			}
			catch (Exception e)
			{
				GD.Print("Error reading from serial port: ", e.Message);
				return "";
			}
		}
		return "";
	}

	public void WriteData(string data)
	{
		if (serialPort.IsOpen)
		{
			GD.Print(serialPort.IsOpen);
			try
			{
				serialPort.WriteLine(data);
			}
			catch (Exception e)
			{
				GD.Print("Error writing to serial port: ", e.Message);
			}
		}
	}

	public override void _ExitTree()
	{
		if (serialPort.IsOpen)
		{
			serialPort.Close();
		}
	}
}
