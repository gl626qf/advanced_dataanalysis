using System;
using TrainProject.Models;
using TrainProject.Services;

namespace TrainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Train Project!");

            Train train = new Train
            {
                Name = "Express 123",
                NumberOfPassengers = 150
            };

            TrainService trainService = new TrainService();
            trainService.DisplayTrainInfo(train);

            // Add more application logic as needed
        }
    }
}
