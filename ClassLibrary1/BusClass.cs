using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace BusClassLibrary
{
    public class Bus
    {
        public string Type { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int CurrentStop { get; set; }
        public int PassengersAmount { get; set; }
        public int TimeBetweenStops { get; set; }

        public Bus(string type, TimeSpan departureTime, int timeBetweenStops = 45, int currentStop = 0, int passengersAmount = 0)
        {
            Type = type;
            CurrentStop = currentStop;
            TimeBetweenStops = timeBetweenStops;
            if (type == "Маршрутка") TimeBetweenStops = 30;
            DepartureTime = departureTime.Add(TimeSpan.FromMinutes(timeBetweenStops));
            PassengersAmount = passengersAmount;
        }

        public void MoveToNextStop(TimeSpan lastMoveTime)
        {
            CurrentStop++;
            DepartureTime = lastMoveTime.Add(TimeSpan.FromMinutes(TimeBetweenStops));
        }

        public bool IsAtLastStop()
        {
            return CurrentStop >= 6;
        }
    }
}