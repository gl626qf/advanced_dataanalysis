import numpy as np
import scipy.stats as stats


import exercises.prob1_3 as prob1_3
import exercises.prob1_5 as prob1_5




def main():



    '''
    Question 1 - Reflect:
    What software do I use: 
    - Python
    - c#



    Question 2 - Calculate different distributions using scipy.stats
    - Poisson
    - Normal
    - Binomial
    - chi-squared
    - Student's t
    '''



    print("-------------------Distributions-------------------")
    print(stats.poisson.pmf(2,3.7))
    print(stats.poisson.cdf(2,3.7))
    print(stats.norm.pdf(2,3.7))
    print(stats.norm.cdf(2,3.7))
    print(stats.binom.pmf(2,3.7, 0.5))
    print(stats.binom.cdf(2,3.7, 0.5))
    print(stats.chi2.pdf(2,3.7))
    print(stats.chi2.cdf(2,3.7))
    print(stats.t.pdf(2,3.7))
    print(stats.t.cdf(2,3.7))
    print()


    print("-------------------Problem 1.3-------------------")
    # First, calculated by hand
    print("Using hand", prob1_3.cumulative_poisson_distribution(2,3.7))

    #Using software
    print("Using scipy", stats.poisson.cdf(2,3.7))




    print("-------------------Problem 1.5-------------------")

    # erf = stats.norm.cdf(1.96) - stats.norm.cdf(-1.96)

    # print(erf)



    # #Tried it using scipy, not sure about the results
    # print("Not sure")
    # print("p-value 10%")
    # print(stats.norm.ppf(0.9))


    # print("p-value 5%")
    # print(stats.norm.ppf(0.05))

    # print("p-value 1%")
    # print(stats.norm.ppf(0.01))

    # # print(prob1_3.poisson_distribution(2,3.7))


    # #Trying two-sided test
    # print("Two-sided test")
    # print(1 - stats.norm.ppf(0.05))
    # print(stats.norm.ppf(0.05))
    # print(stats.norm.ppf(0.025))
    # print(stats.norm.ppf(0.005))

    # #Reflections. Using the inverse gives probably the positive value

    #Trying the errorfunction to check the values
    print("Error function for one sided test")

    #Test case to check the error function
    print("Test case, should give 1 standard deviation")
    print("Error function for 1", prob1_5.error_function(1) - prob1_5.error_function(-1))
    # print(prob1_5.error_function(1) - prob1_5.error_function(-1))
    # print(prob1_5.error_function(1))
    # print(stats.norm.cdf(1) - stats.norm.cdf(-1))
    # To use qnorm and pnorm in R with scipy in python it is given as
    print("For different p-values, 10%, 5%, 1% the standard deviations are")
    print("For right sided test")
    print("For 10%, the number of standard deviations are", stats.norm.ppf(1 - 0.10))
    print("For 5%, the number of standard deviations are", stats.norm.ppf(1 - 0.05))
    print("For 1%, the number of standard deviations are", stats.norm.ppf(1 - 0.01))
    
    print("For left sided test")
    print("For 10%, the number of standard deviations are", stats.norm.ppf(0.10))
    print("For 5%, the number of standard deviations are", stats.norm.ppf(0.05))
    print("For 1%, the number of standard deviations are", stats.norm.ppf(0.01))

    print("For two sided test, the value is plus minus the number of standard deviations")
    print("For 10%, the number of standard deviations are", stats.norm.ppf(1 - 0.10/2))
    print("For 5%, the number of standard deviations are", stats.norm.ppf(1 - 0.05/2))
    print("For 1%, the number of standard deviations are", stats.norm.ppf(1 - 0.01/2))





if __name__ == "__main__":
    main()