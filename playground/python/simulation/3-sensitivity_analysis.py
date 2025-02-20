import numpy as np
import matplotlib.pyplot as plt

# Define parameters
service_rate = 5
num_servers = 1
arrival_rates = np.linspace(0, 10, 100)


def main() -> None:
    # Calculate average queue length (Lq) for M/M/1
    def average_queue_length(arrival_rate, service_rate):
        if arrival_rate >= service_rate:
            return float("inf")  # Queue length goes to infinity if λ >= μ

        return (arrival_rate**2) / (service_rate * (service_rate - arrival_rate))

    # Calculate queue lengths for different arrival rates
    queue_lengths = [average_queue_length(lam, service_rate) for lam in arrival_rates]

    # Plotting the results
    plt.figure(figsize=(10, 6))
    plt.plot(arrival_rates, queue_lengths, label="Average Queue Length", color="blue")
    plt.title("Average Queue Length vs Arrival Rate")
    plt.xlabel("Arrival Rate [customers/minute]")
    plt.ylabel("Average Queue Length")
    plt.axvline(x=service_rate, color="red", linestyle="--", label="Service Rate")
    plt.ylim(0, 20)
    plt.xlim(0, 10)
    plt.legend()
    plt.grid()
    plt.show()


if __name__ == "__main__":
    main()
