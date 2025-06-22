using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace warmhouse.devices.Requests
{
    /// <summary>
    /// Модель создания сенсора
    /// </summary>
    public class SensorCreateRequest
    {
        /// <summary>
        /// Наименование сенсора
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// тип сенсора
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Местоположение
        /// </summary>
        [Required]
        public string Location { get; set; }

        /// <summary>
        /// Единицы измерения сенсора
        /// </summary>
        [Required]
        public string Unit { get; set; }

    }
}