namespace warmhouse.telemetry
{
    public class Telemetry
    {
        public DateTimeOffset When { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }
}
