package services

import (
	//"context"
	//"encoding/json"
	//"log"
	"smarthome/db"
	//"smarthome/models"
	//"github.com/confluentinc/confluent-kafka-go/kafka"
)

// KafkaConsumerService handles fetching temperature data from external API
type KafkaConsumerService struct {
	DB                 *db.DB
	KafkaServerAddress string
	KafkaTopic         string
}

// NewSensorHandler creates a new SensorHandler
func NewKafkaConsumerService(db *db.DB, kafkaServerAddress string, kafkaTopic string) *KafkaConsumerService {
	return &KafkaConsumerService{
		DB:                 db,
		KafkaServerAddress: kafkaServerAddress,
		KafkaTopic:         kafkaTopic,
	}
}

func (k *KafkaConsumerService) Start() {
	// > [monolith builder 6/6] RUN CGO_ENABLED=1 GOOS=linux go build -o smarthome:
	//2.622 # runtime/cgo
	//2.622 cgo: C compiler "gcc" not found: exec: "gcc": executable file not found in $PATH
	//------
	//failed to solve: process "/bin/sh -c CGO_ENABLED=1 GOOS=linux go build -o smarthome" did not complete successfully: exit code: 1

	/*
		consumer, err := kafka.NewConsumer(&kafka.ConfigMap{
			"bootstrap.servers": k.KafkaServerAddress,
			"group.id":          "",
			"auto.offset.reset": "earliest",
		})
		if err != nil {
			panic(err)
		}
		defer consumer.Close()

		consumer.SubscribeTopics([]string{k.KafkaTopic}, nil)
		log.Printf("SubscribeTopics subscribed for topic: %s\n", k.KafkaServerAddress, k.KafkaTopic)

		for {
			msg, err := consumer.ReadMessage(-1)

			if err == nil {
				var device models.DeviceRegisterModel
				err := json.Unmarshal(msg.Value, &device)
				if err != nil {
					log.Printf("Error decoding message: %v\n", err)
					continue
				}

				log.Printf("Received Device: %+v\n", device)

				for index, element := range device.Sensors {
					var sensorCreate models.SensorCreate
					sensorCreate.Name = element.Name
					sensorCreate.Type = element.Type
					sensorCreate.Unit = element.Unit
					sensorCreate.Location = element.Location

					sensor, err := k.DB.CreateSensor(context.Background(), sensorCreate)
					if err != nil {
						return
					}
					log.Printf("Created Sensor: %+v\n", sensor)
				}
			} else {
				log.Printf("Error: %v\n", err)
			}
		}
	*/
}
