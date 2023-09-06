import numpy as np
import scipy.stats as stats




# def erf

# def erf_normal_distribution(x, mu, sigma):
#     return 0.5 * (1 + stats.erf((x - mu) / (sigma * np.sqrt(2))))



#This is maybe the numerical approximation of the error function
def error_function(x):
    return (2 / np.sqrt(np.pi)) * (x - (x**3 / 3) + (x**5 / 10) - (x**7 / 42) + (x**9 / 216))



def binomial_distribution(k, n, p):
    return (np.math.factorial(n) / (np.math.factorial(k) * np.math.factorial(n - k))) * (p**k) * ((1 - p)**(n - k))





