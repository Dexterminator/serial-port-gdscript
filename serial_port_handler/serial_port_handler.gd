extends Node

const MACOS_PORT = "/dev/cu.usbmodem101"
const WINDOWS_PORT = "COM3"
const DEFAULT_PORT = MACOS_PORT
const BAUD_RATE = 9600
var serial_port_handler


func _ready() -> void:
	var port = DEFAULT_PORT
	if OS.has_feature("windows"):
		port = WINDOWS_PORT
	elif OS.has_feature("macos"):
		port = MACOS_PORT

	var SerialPortHandlerImpl = load("res://serial_port_handler/SerialPortHandlerImpl.cs")
	serial_port_handler = SerialPortHandlerImpl.new()
	serial_port_handler.InitPort(BAUD_RATE, port)


func read() -> String:
	return serial_port_handler.ReadData()


func write(data: String) -> void:
	serial_port_handler.WriteData(data)
