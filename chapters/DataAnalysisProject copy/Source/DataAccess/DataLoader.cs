using System;
using System.Collections.Generic;
using System.IO;

namespace DataAnalysisProject.Source.DataAccess
{
    public class DataLoader
    {
        public static double[] LoadDataFromCsv(string filePath)
        {
            List<double> dataList = new List<double>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header row if needed
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(','); // Assuming CSV is comma-separated

                        // Parse values and create a new instance of YourDataType
                        double dataItem = new double
                        {
                            // Assuming YourDataType has properties with appropriate data types
                            Property1 = Convert.ToDouble(values[0]),
                            Property2 = Convert.ToInt32(values[1]),
                            // Add more properties based on your actual data structure
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
                return new double[0]; // Return an empty array or handle the error accordingly
            }
        }
    }
}
