using System.Diagnostics;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Bus
    {
        public string Type { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int CurrentStop { get; private set; }
        public int PassengersAmount { get; set; }
        public int TimeBetweenStops { get; }

        public Bus(string type, TimeSpan departureTime, int timeBetweenStops, int currentStop = 1, int passengersAmount = 0)
        {
            Type = type;
            CurrentStop = currentStop;
            TimeBetweenStops = timeBetweenStops;
            DepartureTime = departureTime;
            PassengersAmount = passengersAmount;
        }

        public void MoveToNextStop(TimeSpan lastMoveTime)
        {
            CurrentStop++;
            DepartureTime = lastMoveTime.Add(TimeSpan.FromMinutes(TimeBetweenStops)); // Обновляем время последнего перемещения
        }

        public bool IsAtLastStop()
        {
            return CurrentStop >= 6;
        }
    }
}