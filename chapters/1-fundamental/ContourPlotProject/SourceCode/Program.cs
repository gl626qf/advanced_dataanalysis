using System;
// using static System.Console;
using System.Diagnostics;
using System.IO;

namespace ContourPlotExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Sample data for the contour plot
            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 10, 20, 30, 40, 50 };
            double[,] z = { { 5, 10, 15, 20, 25 }, { 15, 20, 25, 30, 35 }, { 25, 30, 35, 40, 45 }, { 35, 40, 45, 50, 55 }, { 45, 50, 55, 60, 65 } };

            // Write data to a temporary data file
            string tempDataFilePath = "Output/temp_data.dat";
                using (StreamWriter dataFile = new StreamWriter(tempDataFilePath))
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        for (int j = 0; j < y.Length; j++)
                        {
                            dataFile.WriteLine($"{x[i]} {y[j]} {z[i, j]}");
                        }
                    }
                }



        

        }
    }
}
