using System;
using System.Linq;
using MathNet.Numerics.LinearRegression;
using DataAnalysisProject.Source.Models; // Add the using directive for the data model namespace
using DataAnalysisProject.Source.Analysis; // Add the using directive for the analysis namespace

// Maybe add this, if the above namespace does not work.
// using DataAnalysisProject.Source.Analysis.Formulae;



namespace DataAnalysisProject.Source.Analysis
{
    public class FitAnalyzer
    {
        private BreitWignerFormula breitWignerFormula;

        public FitAnalyzer()
        {
            breitWignerFormula = new BreitWignerFormula();
        }

        // ...

        public FitModel PerformLinearRegression(double[] xValues, double[] yValues)
        {
            // ...
        }

        public double CalculateBreitWigner(double energy, double resonanceEnergy, double width)
        {
            double resonanceCrossSection = breitWignerFormula.CalculateResonanceCrossSection(energy, resonanceEnergy, width);
            return resonanceCrossSection;
        }
    }
}
