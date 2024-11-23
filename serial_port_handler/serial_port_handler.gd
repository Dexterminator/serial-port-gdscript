extends Node

var serial_port_handler


func _ready() -> void:
	var SerialPortHandlerImpl = load("res://serial_port_handler/SerialPortHandlerImpl.cs")
	serial_port_handler = SerialPortHandlerImpl.new()
	serial_port_handler.InitPort()


func read() -> String:
	return serial_port_handler.ReadData()


func write(data: String) -> void:
	serial_port_handler.WriteData(data)
