using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace warmhouse.telemetry.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TelemetryController : ControllerBase
    {
        private readonly ILogger<TelemetryController> _logger;

        public TelemetryController(ILogger<TelemetryController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получить телеметрию
        /// </summary>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Устройства</returns>
        /// <response code="200">Список телеметрии</response>  
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Telemetry>), StatusCodes.Status200OK)]
        public IEnumerable<Telemetry> GetTelemetry()
        {
            _logger.Log(LogLevel.Debug, nameof(GetTelemetry));

            return Enumerable.Range(1, 5).Select(index => new Telemetry
            {

            })
            .ToArray();
        }
    }
}
