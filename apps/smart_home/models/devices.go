package models

// Sensor represents a smart home device
type DeviceRegisterModel struct {
	SerialNumber string                `json:"SerialNumber"`
	Name         string                `json:"Name"`
	Model        string                `json:"Model"`
	Manufacturer string                `json:"Manufacturer"`
	MacAddress   string                `json:"MacAddress"`
	Sensors      []SensorRegisterModel `json:"Sensors"`
}

// SensorCreate represents the data needed to create a new sensor
type SensorRegisterModel struct {
	Name     string     `json:"Name" binding:"required"`
	Type     SensorType `json:"Type" binding:"required"`
	Location string     `json:"Location" binding:"required"`
	Unit     string     `json:"Unit"`
}
