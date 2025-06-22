using System.ComponentModel.DataAnnotations;

namespace warmhouse.devices.Options
{
    /// <summary>
    /// Настройки для топиеов
    /// </summary>
    public class KafkaTopicOptions
    {
        public const string NAME = "KafkaTopic";

        /// <summary>
        /// Recipients 
        /// </summary>
        [Required]
        public string DeviceRegisteredTopic { get; set; } = string.Empty;

    }
}
