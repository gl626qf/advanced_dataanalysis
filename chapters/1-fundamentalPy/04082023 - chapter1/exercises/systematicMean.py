import numpy as np

'''
exercise 2 week 2

Systematic error is from background factors that affect the measurement in a constant way.
'''

data = np.array([13.848, 13.869, 13.896, 13.824, 13.923])

dataMean = np.mean(data)
print(dataMean)

dataStd = np.std(data)


# The statical error and systematic error
statistical_error_data = np.array([38, 33, 36, 39])
systematic_error_data = np.array([18, 20, 24, 20])



# Copied from the week
# np.array([13.848(38)(18), 13.869(33)(20), 13.824(36)(24), 13.923(39)(20)])


# Calculating the standard deviation of the statical error and the systematic error
# Assuming guassian distribution, and IID (probably ask Karsten about this)
# https://www.itl.nist.gov/div898/handbook/eda/section3/eda35c.htm great website


statistical_error_data_std = np.std(statistical_error_data)
systematic_error_data_std = np.std(systematic_error_data)
total_std = np.sqrt(statistical_error_data_std**2 + systematic_error_data_std**2)



# Other methode
# https://numpy.org/doc/stable/reference/generated/numpy.corrcoef.html
rho = np.corrcoef(statistical_error_data, systematic_error_data)






def write():
    print("Exercise 2 week 2")
    print("First the mean of the data is taken")
    print("Data mean", dataMean)

    print("Finding standard deviation of the statical error and the systematic error")
    print("Statical error standard deviation", statistical_error_data_std)
    print("Systematic error standard deviation", systematic_error_data_std)
    print("Total standard deviation", total_std)
    print("Here I don't get what they got in the lecture")


    print("-----------------------------------------------")
    print("Trying other methode with correlation")
    print("Correlation", rho)

    print("_----------------------------------------------")
    print("Try also using gauss std to the data")
    print("Data std", dataStd)