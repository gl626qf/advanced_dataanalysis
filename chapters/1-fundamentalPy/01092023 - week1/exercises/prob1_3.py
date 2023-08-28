import numpy as np

def poisson_distribution(lam, k):
    return (lam**k / np.math.factorial(k)) * np.exp(-lam)



def cumulative_poisson_distribution(lam, k):
    return sum([poisson_distribution(lam, i) for i in range(k+1)])




