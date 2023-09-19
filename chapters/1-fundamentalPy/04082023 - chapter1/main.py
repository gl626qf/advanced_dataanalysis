import numpy as np
import scipy.stats as stats


# import exercises.prob1_3 as prob1_3
# import exercises.prob1_5 as prob1_5

# import exercises.prob1_4 as prob1_4
# import exercises.systematicMean as systematicMean
import exercises.prob1_4 as prob1_4


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



    # print("-------------------Distributions-------------------")
    # # print(stats.poisson.pmf(2,3.7))
    # # print(stats.poisson.cdf(2,3.7))
    # # print(stats.norm.pdf(2,3.7))
    # # print(stats.norm.cdf(2,3.7))
    # # print(stats.binom.pmf(2,3.7, 0.5))
    # # print(stats.binom.cdf(2,3.7, 0.5))
    # # print(stats.chi2.pdf(2,3.7))
    # # print(stats.chi2.cdf(2,3.7))
    # # print(stats.t.pdf(2,3.7))
    # # print(stats.t.cdf(2,3.7))
    # # print()

    # print("-------------------Exercises-------------------")

    # print("Exericse 1.4")
    # print(prob1_4.P_N(np.array([0.9, 0.99])))
    # print("The probability changes, describe why.")

    # # In the PP, show the derivation of the formula for P_N

    # print("-----------------------------------------------")




    print("-------------------0609203 - Exercises-------------------")
    # systematicMean.write()
    prob1_4.write()

    


if __name__ == "__main__":
    main()