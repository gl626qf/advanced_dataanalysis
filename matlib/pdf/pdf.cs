using System;
using static System.Console;
using static System.Math;


public static class Pdf{


    public static int CalculateFactorial(int n){
        if (n == 0){return 1;}
        return n * CalculateFactorial(n - 1);
    }

    public static double CalculateLogBinomialCoefficient(int n, int k)
    {
        double logNumerator = 0;
        double logDenominator = 0;

        for (int i = 1; i <= k; i++)
        {
            logNumerator += Math.Log(n - i + 1);
            logDenominator += Math.Log(i);
        }

        return logNumerator - logDenominator;
    }



    // public static BigInteger CalculateFactorialBig(int n)
    // {
    //     if (n <= 1)
    //         return 1;

    //     BigInteger result = 1;
    //     for (int i = 2; i <= n; i++)
    //         result *= i;

    //     return result;
    // }

    // public static double gauss(vector m){

    // }


    public static double gauss(double x, double mu, double sigma){
        // double K = 1 / (Sqrt(2*PI) * sigma) * Exp(-Pow(x-mu,2) / (2 * Pow(sigma,2)));
        double K = 1 / (Sqrt(2*PI) * sigma);
        double g_ = Exp(-Pow(x-mu,2) / (2 * Pow(sigma,2)));
        // WriteLine("Gaussian PDF");
        // WriteLine($"Standard deviation, σ = {sigma}");
        // WriteLine($"Average value, µ = {mu}");
        return K * g_;

    } // gauss


    public static double poisson(int n, double v){
        // double sigma = Sqrt(v);
        // WriteLine($"Standard deviation, σ = {sigma}");
        // WriteLine($"Average value, 𝛎 = {v}");
        return Pow(v,n) / CalculateFactorial(n) * Exp(-v);
    }

    public static double binomial(int r, int N, double p){
        // double part1 = CalculateFactorial(N) / (CalculateFactorial(r) * CalculateFactorial(N - r));
        // double part2 = Pow(p,r) * Pow((1- p), N-r);
        // return part1 * part2;
        double logPart1 = CalculateLogBinomialCoefficient(N, r);
        double logPart2 = r * Math.Log(p) + (N - r) * Math.Log(1 - p);
        return Math.Exp(logPart1 + logPart2);
    }   



} //Pdf
