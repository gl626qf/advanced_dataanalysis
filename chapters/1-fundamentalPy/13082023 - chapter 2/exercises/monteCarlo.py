import numpy as np
import scipy.stats as stats
import matplotlib.pyplot as plt


N = [2,8, 10, 100] # Number of sets
sets = 1000

points = []


for i in N:
    # print(i)
    x_numpy = np.random.exponential(1, size = (i, sets))
    mean_numpy = np.mean(x_numpy, axis = 0)
    points.append(mean_numpy)
    # plt.plot(i, np.mean(mean_numpy), 'ro')
    # plt.show()


plt.hist(points, b)
plt.show()
# x_numpy = np.random.exponential(1, size = (8, sets))



# Marias løsning 
# fig, ax = plt.subplots(3,1, figsize = (10,14))
# times = int(1e5)
# N = [2,8,100]

# for i in range(len(N)):
#     print(i)
#     ran = ss.expon.rvs(size = (N[i],times))
#     result = []
#     for j in range(int(times)):
#         result.append(np.mean(ran[:,j]))
    
#     st = sorted(result)
#     idx = int(len(st)*0.16)
#     conf = [st[idx],st[len(st)-idx]]
#     ax[i].hist(result, bins = 50)
#     ax[i].set_title(f"Simulation tau with N={N[i]} by {times} runs")
#     ax[i].vlines(0,10000,conf[0],color='r')
#     ax[i].vlines(0,10000,conf[1],colro = 'r')


plt.plot(N, points, 'ro')


def write():
    # print("x shape", x_numpy.shape)

    # print(points)
    print("Monte carlo")

