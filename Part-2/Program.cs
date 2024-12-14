namespace Part_2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            List<Sensor> sensors = new List<Sensor>();

            // Add instances to the list
            sensors.Add(new DoorSensor(123456, true));
            sensors.Add(new DoorSensor(654321, false));
            sensors.Add(new TemperatureSensor(987654, 22.5));
            sensors.Add(new TemperatureSensor(456789, 18.7));
            sensors.Add(new DoorSensor(567890, true));
            sensors.Add(new TemperatureSensor(345678, 25.3));

            // Sort the element of list based on serial
            sensors.Sort();

            // Iterate through the sorted list and print 
            foreach (var sensor in sensors)
            {
                Console.WriteLine(sensor.ToString());
            }
        }
    }
}
