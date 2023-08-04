namespace DataAnalysisProject.Source.Models
{
    public class FitModel
    {
        public double Slope { get; set; }
        public double Intercept { get; set; }

        // You can add more properties to represent other fitting parameters
        // For example:
        // public double RSquared { get; set; }
        // public double Residuals { get; set; }
        // ...

        public override string ToString()
        {
            return $"Slope: {Slope}, Intercept: {Intercept}";
        }
    }
}
