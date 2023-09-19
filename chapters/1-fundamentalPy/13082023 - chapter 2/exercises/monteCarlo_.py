import numpy as np
import scipy.stats as stats
import matplotlib.pyplot as plt


N = 2 # Number of sets

# Generate random points distributed according to exponential distribution

x_numpy = np.random.exponential(1, size = (8, N))
mean_numpy = np.mean(x_numpy, axis = 0)


# In scipy
# Or N sets
x = stats.expon.rvs(1, size=(8, N))
# mean_scipy = stats.expon.mean(x, axis = 0) Does not work
mean_scipy = stats.expon.mean(x)


# Mean on scipy made numbers 
mean_scipy = np.mean(x, axis = 0)




N_array = np.array([1, 2, 3, 4, 5, 6, 7, 8])
# With more spacing
# N_array = np.array([2, 4, 8, 10, 20, 40, 80, 100])
N_array = np.arange(1, 10000, 1)

# Generate random points distributed according to exponential distribution
x_numpy = np.random.exponential(1, size = (8, len(N_array)))
print(len(x_numpy))

# plt.plot(N_array, np.mean(x_numpy, axis = 0), 'ro')
# plt.show()



# Now we take mean of all the measurements, because the other method did not show assymmetry
N = [4, 8, 10, 20]


for i in N:
    x_numpy = np.random.exponential(1, size = (8, i))
    mean_numpy = np.mean(x_numpy, axis = 0)
    # plt.plot(i, np.mean(mean_numpy), 'ro')
    # plt.show()

# x_numpy = np.random.exponential(1, size = (8, N))
# mean_numpy = np.mean(x_numpy, axis = 0)






def write():
    print("Mean using numpy, axis = 0", mean_numpy)

    # print(x, "\n size", x.size)
    print("mean using scipy", mean_scipy)
    print("Not quite the same as the mean using numpy. Why?")
    
    # Now using numpy on the scipy generated numbers
    mean_numpy_scipy = np.mean(x, axis = 0)
    print("mean using numpy on scipy generated numbers", mean_numpy_scipy)
    print("Same as the mean using scipy. The seed of the random numbers are different, but the scipy and numpy functions are the same, when axis = 0 in numpy.")
    print("-----------------------------------------------")

    print("Plotting the mean of the exponential distribution for different N")


    # New try
    print("x_numpy", x_numpy)


    print("Mean using numpy, axis = 0: ", mean_numpy)

    for i in x_numpy:
        i = np.mean(i)
        print(i)