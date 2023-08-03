using System;
using static System.Console;
using DataAnalysisProject.Source.Analysis;
using DataAnalysisProject.Source.DataAccess;
using DataAnalysisProject.Source.Models;

namespace DataAnalysisProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Analysis Project");
            
            // // Trying out the DataAnalyzer.cs
            // DataAnalyzer dataAnalyzer = new DataAnalyzer();
            // dataAnalyzer.Test();


            // DataLoader dataLoader = new DataLoader();
            // dataLoader.Test();


            Console.WriteLine("Data Analysis Project");

            string csvFilePath = "Data/RawData/data.csv";
            YourDataType[] data = DataLoader.LoadDataFromCsv(csvFilePath);

            // Use the loaded data as needed
            foreach (var item in data)
            {
                Console.WriteLine($"Column1: {item.Column1}, Column2: {item.Column2}, Column3: {item.Column3}");
            }

            // Add your data analysis code here

            Console.WriteLine("Data analysis completed. Press any key to exit.");
            Console.ReadKey();


            
            // Add your data analysis code here

            // Example: Load data from CSV file
            // string csvFilePath = "Data/RawData/raw_data_file.csv";


            // DataLoader dataLoader = new DataLoader();
            // double[] data = dataLoader.LoadDataFromCsv("advanced_dataanalysis/chapters/HiggsChiSquaredProject/Data/RawData/data.csv");


            // Use the loaded data as needed
            // foreach (var item in data)
            // {
            //     Console.WriteLine($"Property1: {item.Property1}, Property2: {item.Property2}");
            // }

            // // Example: Perform data analysis
            // var analysisResult = PerformDataAnalysis(data);

            // // Example: Save processed data to CSV file
            // string processedCsvFilePath = "Data/ProcessedData/processed_data_file.csv";
            // SaveDataToCsv(analysisResult, processedCsvFilePath);

            // Console.WriteLine("Data analysis completed. Press any key to exit.");
            // Console.ReadKey();
        }

        // Example method for loading data from CSV file
        // private static YourDataType[] LoadDataFromCsv(string filePath)
        // {
        //     // Implement the logic to load data from the CSV file
        //     // Return the loaded data as an array of YourDataType
        //     // Replace YourDataType with the actual data type you are using
        //     return new YourDataType[0];
        // }

        // Example method for performing data analysis
        // private static AnalysisResult PerformDataAnalysis(YourDataType[] data)
        // {
        //     // Implement the logic to perform data analysis
        //     // Replace YourDataType with the actual data type you are using
        //     // Return the analysis result as an instance of AnalysisResult
        //     // Replace AnalysisResult with the actual result type
        //     return new AnalysisResult();
        // }

        // // Example method for saving data to CSV file
        // private static void SaveDataToCsv(AnalysisResult result, string filePath)
        // {
        //     // Implement the logic to save the analysis result to a CSV file
        //     // Replace AnalysisResult with the actual result type
        //     // Use filePath to determine where to save the data
        // }
    }

    // Replace YourDataType and AnalysisResult with the actual types you are using for data and analysis results.
    // If you are using custom classes or structures to represent data and analysis results,
    // define them here or in separate files in the Models folder.
    // Example:
    // public class YourDataType { /* ... */ }
    // public class AnalysisResult { /* ... */ }
}



// using System;
// using DataAnalysisProject.Source.DataAccess;

// namespace DataAnalysisProject
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Data Analysis Project");

//             string csvFilePath = "path/to/your/dataset.csv";
//             YourDataType[] data = DataLoader.LoadDataFromCsv(csvFilePath);

//             // Use the loaded data as needed
//             foreach (var item in data)
//             {
//                 Console.WriteLine($"Column1: {item.Column1}, Column2: {item.Column2}, Column3: {item.Column3}");
//             }

//             // Add your data analysis code here

//             Console.WriteLine("Data analysis completed. Press any key to exit.");
//             Console.ReadKey();
//         }
//     }
// }
