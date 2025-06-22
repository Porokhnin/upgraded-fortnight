using System.ComponentModel.DataAnnotations;

namespace warmhouse.devices.Requests
{
    /// <summary>
    /// Модель регистрации устройства
    /// </summary>
    public sealed class DeviceCreateRequest
    {
        /// <summary>
        /// Серийный номер 
        /// </summary>
        [Required]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Модель
        /// </summary>
        [Required]
        public string Model { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        [Required]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Мак адрес
        /// </summary>
        [Required]
        public string MacAddress { get; set; }

        /// <summary>
        /// Сенсоры
        /// </summary>
        [Required]
        public List<SensorCreateRequest> Sensors { get; set; }
    }
}