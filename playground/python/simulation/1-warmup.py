#!/usr/bin/env python3

import sys
from typing import Final

import numpy as np
import matplotlib.pyplot as plt

arrival_rate: Final[float] = 1.0  # λ (lambda)
service_rate: Final[float] = 1.5  # μ (mu)
num_customers: Final[int] = 1000  # Total number of customers to simulate


def main() -> int:
    # Generate random arrival and service times
    arrival_times = np.cumsum(np.random.exponential(1 / arrival_rate, num_customers))
    service_times = np.random.exponential(1 / service_rate, num_customers)
    waiting_times = np.zeros(num_customers)
    completion_times = np.zeros(num_customers)

    # Simulate the queue
    for i in range(num_customers):
        if i == 0:
            # First customer starts service immediately upon arrival
            waiting_times[i] = 0
            completion_times[i] = arrival_times[i] + service_times[i]

        else:
            # Calculate waiting time
            waiting_times[i] = max(0, completion_times[i - 1] - arrival_times[i])
            completion_times[i] = arrival_times[i] + waiting_times[i] + service_times[i]

    # Calculate average waiting time over time
    average_waiting_time = np.cumsum(waiting_times) / (np.arange(1, num_customers + 1))

    steady_state_start = 400

    plt.figure(figsize=(12, 6))
    plt.plot(average_waiting_time, label="Average Waiting Time", color="blue")
    plt.axhline(
        y=np.mean(waiting_times),
        color="red",
        linestyle="--",
        label="Steady State Average",
    )

    # Transient phase shade
    plt.fill_between(
        range(steady_state_start),
        average_waiting_time[:steady_state_start],
        color="lightgray",
        label="Transient Phase",
        alpha=0.5,
    )

    # Steady state phase shade
    plt.fill_between(
        range(steady_state_start, num_customers),
        average_waiting_time[steady_state_start:],
        color="lightgreen",
        label="Steady State Phase",
        alpha=0.5,
    )

    plt.title("Average Waiting Time in Queueing System")
    plt.xlabel("Number of Customers Served")
    plt.ylabel("Average Waiting Time")
    plt.legend()
    plt.grid()
    plt.show()

    return 0


if __name__ == "__main__":
    sys.exit(main())
