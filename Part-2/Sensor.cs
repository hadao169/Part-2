using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    public abstract class Sensor : IComparable<Sensor>
    {
        // Serial property
        public int _serial;
        public int Serial
        {
            get { return _serial; }
            set
            {
                if (999999 >= value && value >= 100000)
                {
                    _serial = value;
                }
                else
                {
                    _serial = -1;
                }
            }
        }

        // Initialize constructor method
        public Sensor(int serial)
        {
            Serial = serial;
        }

        //Abstract CurrentStatus method
        public abstract string CurrentStatus();

        // Override ToString method
        public override string ToString()
        {
            return $"Serial of sensor: {Serial}";
        }

        // Implement IComparable: a way to define how objects are compared to each other
        public int CompareTo(Sensor? other)
        {
            if (other == null) return 1;
            return Serial.CompareTo(other.Serial);
        }
    }

    public class DoorSensor : Sensor
    {
        public bool IsOpen { get; set; }

        //Constructor
        public DoorSensor(int serial, bool isOpen) : base(serial)
        {
            IsOpen = isOpen;
        }

        //Override CurrentStatus method
        public override string CurrentStatus()
        {
            if (IsOpen)
            {
                return "Open";
            }
            else
            {
                return "Closed";
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return base.ToString() + $" Current status: {CurrentStatus()}";
        }
    }

    public class TemperatureSensor : Sensor
    {
        public double Temperature { get; set; }

        public TemperatureSensor(int serial, double temperature) : base(serial)
        {
            Temperature = temperature;
        }

        public override string CurrentStatus()
        {
            return $"{Temperature} Celsius!";
        }

        public override string ToString()
        {
            return base.ToString() + $" Current temperature: {CurrentStatus()}";
        }
    }
}
