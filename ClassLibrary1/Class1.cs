using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Bus
    {
        public string Type { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int CurrentStop { get; private set; }
        public int Progress { get; private set; }
        public int TimeBetweenStops { get; } 

        public Bus(string type, TimeSpan departureTime, int timeBetweenStops, int currentStop = 0)
        {
            Type = type;
            CurrentStop = currentStop;
            Progress = 0;
            TimeBetweenStops = timeBetweenStops;
            DepartureTime = departureTime; // Устанавливаем время последнего перемещения в минимальное значение
        }

        public void MoveToNextStop(TimeSpan lastMoveTime)
        {
            CurrentStop++;
            Progress = 0;
            DepartureTime = lastMoveTime.Add(TimeSpan.FromMinutes(TimeBetweenStops)); // Обновляем время последнего перемещения
        }

        public bool IsAtLastStop()
        {
            return CurrentStop >= 6;
        }

        // Метод для обновления прогресса перемещения на основе фактического времени
        public void UpdateProgress()
        {
            
        }

    }
}