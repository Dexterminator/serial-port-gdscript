using Godot;
using System;
using System.IO.Ports;

public partial class SerialPortHandlerImpl : Node2D
{
	private SerialPort serialPort;

	public void InitPort(int baudRate, string portName)
	{
		serialPort = new SerialPort();
		serialPort.BaudRate = baudRate;
		serialPort.PortName = portName;
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
