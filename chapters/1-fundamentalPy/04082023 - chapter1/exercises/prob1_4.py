import numpy as np


# N locations 
# N = 10

# After one unsuccesful investigation




# def P_N(P):
#     return (N - 1) / (N - P) * P


# # Probabilities
# P = np.array([0.9, 0.99])

# # print(P_N(P))


# def p


# -----------------------------------------------

# The first try was not right. 
# Need recursive function

P_prior = np.array([0.9, 0.99])
P_prior_ = np.array([0.9, 0.99])

N = 10

for i in range(0,N - 1):
    i_inverse = N - i
    P_prior = (i_inverse - 1) / (i_inverse - P_prior) * P_prior
    print(P_prior)





def write():
    # p10 = P_recursive(np.array([0.9, 0.99]), 10)
    # print("p10", p10)
    print(P_prior)
    # P2 = (9 / (10 - P_prior_) * P_prior_)
    # P3 = (8 / (10 - P2) * P2)
    # print(P3)
    
