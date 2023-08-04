using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;

using DataAnalysisProject.Source.Models;

namespace DataAnalysisProject.Source.DataAccess
{
    public class DataLoader
    {
        public void Test()
        {
            Console.WriteLine("...DataLoader.cs connected");
        }

        public static YourDataType[] LoadDataFromCsv(string filePath)
        {
            List<YourDataType> dataList = new List<YourDataType>();



            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header row if needed
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(' '); // Assuming CSV is space-separated

                        // Parse values and create a new instance of YourDataType
                        YourDataType dataItem = new YourDataType
                        {
                            // Assuming YourDataType has properties with appropriate data types
                            Column1 = int.Parse(values[0]),
                            Column2 = double.Parse(values[1]),
                            Column3 = double.Parse(values[2]),
                        };

                        // Add the data item to the list
                        dataList.Add(dataItem);
                    }
                }

                // Convert the list to an array and return
                return dataList.ToArray();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during data loading
                Console.WriteLine($"Error loading data from CSV: {ex.Message}");
                return new YourDataType[0]; // Return an empty array or handle the error accordingly
            }
        }
    }
}

