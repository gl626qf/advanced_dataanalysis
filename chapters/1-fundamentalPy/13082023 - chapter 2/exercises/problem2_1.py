import numpy as np
import matplotlib.pyplot as plt




efficiency_array = np.array([0.99, 0.04])


observed_array = np.array([99, 4])
observed_error = np.array([9, 2])




def corrected_obs(efficiency_array, observed_array):
    '''
    Returns the corrected observed array, given the efficiency array and the observed array.
    '''
    return observed_array / efficiency_array


def corrected_obs_error(efficiency_array, observed_array, observed_error):
    '''
    Returns the corrected observed error array, given the efficiency array, the observed array and the observed error array.
    '''
    return observed_error / efficiency_array


def expLnLikelihood(tau, observed_array):
    '''
    Returns the exponential log likelihood, given the tau and the observed array.
    '''
    return np.sum(- np.log(tau) - observed_array / tau)



def plotExpLnLikelihood(tau, observed_array):
    '''
    Plots the exponential log likelihood, given the tau and the observed array.
    '''
    # return plt.plot(np.sum(- np.log(tau) - observed_array / tau))

    for i in range(0, len(tau)):
        print(tau[i], np.sum(- np.log(tau[i]) - observed_array / tau[i]))
        plt.plot(tau[i], np.sum(- np.log(tau[i]) - observed_array / tau[i]), 'ro')







def write():
    print("Exercise 2.1----------------------------------------------------------")
    print("Observed values", observed_array)
    print("Corrected counts of observables: ", corrected_obs(efficiency_array, observed_array))
    print("The total counts of observables: ", np.sum(corrected_obs(efficiency_array, observed_array)))
    print("Naivly calculated error of corrected counts of observables: ", corrected_obs_error(efficiency_array, observed_array, observed_error))

    print("Printing the total error of the corrected counts of observables: ", np.sqrt(np.sum(corrected_obs_error(efficiency_array, observed_array, observed_error)**2)))

    print("-----------------------------------------------")
    print("Maybe there is another way to calculate the error of the corrected counts of observables?")

    print("The standard deviation is here symmetrical, but it is not the case in general. In our case, the error is not symmetrical, so we cannot use the standard deviation. We have to use the error propagation formula.")


    print("----------------------------------------------------------")
    print("Using error propagation")


    print(expLnLikelihood(1, observed_array))
    plotExpLnLikelihood(np.array([1,2,3]), np.array([1,2,3]))




