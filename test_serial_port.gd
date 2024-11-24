extends Node2D


func _ready():
	var data = SerialPortHandler.read()
	if data != "":
		print("Received Data: ", data)

	SerialPortHandler.write("test")
