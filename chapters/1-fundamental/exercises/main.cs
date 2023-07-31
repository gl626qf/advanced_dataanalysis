using System;
using static System.Console;
using static System.Math;


public class main{


    // // Function to minimize (example)
    // public static double function1(vector x)
    // {
	// 	double result = Sin(x[0]) + Cos(x[1]);
    //     return result;
    // }


    // public static double function2(vector x)
    // {
    //     double result = Pow(x[0] - 0, 2) + Pow(x[1] - 3, 2);
	// 	// double result = - Exp(Pow(-x[0],2)) - Exp(Pow(-x[1],2));
    //     return result;
    // }



	// public static double divFunction1(vector x)
	// {
	// 	double result = Log(x[0]) + 2 * Log(x[1]) + 0.5 * Log(x[2]);
	// 	return result;
	// }


    public static void Main(string[] args){
		
		foreach(var arg in args){
			if(arg == "-testRandomVec"){
				// var rnd = new Random();

				// vector a_test = new vector(1, 0);
				// vector b_test = new vector(2,0);
				// vector vecSvarm = svarm.randomvec(a_test, b_test, rnd);
				// vecSvarm.print("Random vector");



			}



			if(arg == "-gauss"){
				    
				double gaussTest = Pdf.gauss(4, 2, 3);
				WriteLine(gaussTest);

				int xRange = 10;

				for(double x=-xRange + 1.0/128;x<=xRange;x+=1.0/64){
					WriteLine($"{x} {Pdf.gauss(x, 2, 3)}");}

			
			}


			if(arg == "-poisson"){

				
				// double poissonTest = Pdf.poisson(1,0.45);
				// WriteLine(poissonTest);
				for(int n=0;n<=12;n+=1){
					WriteLine($"{n} {Pdf.poisson(n, 3)}");}

			
			}




			if(arg == "-binomial"){
				    

				// double poissonTest = Pdf.poisson(1,0.45);
				// WriteLine(poissonTest);
				int N = 100;
				for(int r=1;r<=N;r+=1){
					WriteLine($"{r} {Pdf.binomial(r, N, 0.5)}");}

			
			}




	} 

}

} // main
