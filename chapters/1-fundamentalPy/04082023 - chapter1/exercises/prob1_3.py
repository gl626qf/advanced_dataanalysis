import numpy as np

def poisson_distribution(k, lam):
    return (lam**k / np.math.factorial(k)) * np.exp(-lam)





def cumulative_poisson_distribution(k, lam):
    return sum([poisson_distribution(i,3.7) for i in range(0,k+1)])