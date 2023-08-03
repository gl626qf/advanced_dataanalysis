using System;
using TrainProject.Models;

namespace TrainProject.Services
{
    public class TrainService
    {
        public void DisplayTrainInfo(Train train)
        {
            Console.WriteLine($"Train Name: {train.Name}");
            Console.WriteLine($"Number of Passengers: {train.NumberOfPassengers}");
            // Add more logic as needed
        }
    }
}
