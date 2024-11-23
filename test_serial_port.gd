extends Node2D

@onready var serial_port_handler = $SerialPortHandler


func _ready():
	var data = serial_port_handler.read()
	if data != "":
		print("Received Data: ", data)

	serial_port_handler.write("in")
