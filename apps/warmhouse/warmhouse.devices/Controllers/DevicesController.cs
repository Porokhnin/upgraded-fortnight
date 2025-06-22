using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using warmhouse.devices.Kafka;
using warmhouse.devices.Options;
using warmhouse.devices.Requests;

namespace warmhouse.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly ILogger<DevicesController> _logger;


        public DevicesController(ILogger<DevicesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получить все устройств
        /// </summary>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Устройства</returns>
        /// <response code="200">Устройство</response>  
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Device>), StatusCodes.Status200OK)]
        public IEnumerable<Device> GetDevices(CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Debug, nameof(GetDevices));

            return Enumerable.Range(1, 5).Select(index => new Device
            {
                Id = Guid.NewGuid(),
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToList();
        }


        /// <summary>
        /// Получить устройство по идентификатору
        /// </summary>
        /// <param name="deviceId">Идентификатор устройства</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Устройство</returns>
        /// <response code="200">Список устройств</response>  
        [HttpGet("{deviceId:Guid}")]
        [ProducesResponseType(typeof(Device), StatusCodes.Status200OK)]
        public Device GetDeviceById([FromRoute] Guid deviceId, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Debug, $"nameof(GetDeviceById) {0}", deviceId);

            return new Device
            {
                Id = deviceId,
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = Random.Shared.Next(-20, 55),
            }; ;
        }

        /// <summary>
        /// Создать устройство
        /// </summary>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns></returns>
        /// <response code="200">Устройство создано</response>  
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateDevicesAsync(DeviceCreateRequest createRequest,
            [FromServices] KafkaDependentProducer<string, string> producerBuilder,
            IOptions<KafkaTopicOptions> options,
            CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Debug, nameof(CreateDevicesAsync));

            await Task.Delay(TimeSpan.FromSeconds(2)); // Типо долгая операция сохранения в бд...


            try
            {
                var message = new Confluent.Kafka.Message<string, string>();
                message.Key = "device.registered";
                message.Value = System.Text.Json.JsonSerializer.Serialize(createRequest);

                producerBuilder.ProduceAsync(options.Value.DeviceRegisteredTopic, message);
            }
            catch (Exception ex)
            {

                int f = 3;
            }

            int g = 5;

        }
    }
}
