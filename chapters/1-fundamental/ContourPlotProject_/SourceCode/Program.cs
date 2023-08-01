using System;
using System.Diagnostics;
using System.IO;

namespace ContourPlotExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample data for the contour plot
            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 10, 20, 30, 40, 50 };
            double[,] z = { { 5, 10, 15, 20, 25 }, { 15, 20, 25, 30, 35 }, { 25, 30, 35, 40, 45 }, { 35, 40, 45, 50, 55 }, { 45, 50, 55, 60, 65 } };

            // Write data to a temporary data file
            string tempDataFilePath = "temp_data.dat";
            try
            {
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

                // Create a Gnuplot process
                using (var gnuplot = new Process())
                {
                    gnuplot.StartInfo.FileName = "gnuplot"; // Make sure 'gnuplot' is in your system PATH
                    gnuplot.StartInfo.Arguments = $"-e \"datafile='{tempDataFilePath}'\" \"contour_plot.gpi\""; // Pass the script file with datafile as an environment variable
                    gnuplot.StartInfo.UseShellExecute = false;
                    gnuplot.StartInfo.CreateNoWindow = true;

                    gnuplot.Start(); // Start gnuplot process

                    gnuplot.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Delete the temporary data file after Gnuplot execution
                if (File.Exists(tempDataFilePath))
                {
                    File.Delete(tempDataFilePath);
                }
            }
        }
    }
}
