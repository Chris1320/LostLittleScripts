import sys
from typing import Final

import numpy as np
import matplotlib.pyplot as plt
from scipy.stats import expon

LAMBDA_VAL: Final[int] = 1  # Rate parameter
NUM_SAMPLES: Final[int] = 10000


def main() -> int:
    """Main function."""

    # Generate uniform random numbers
    uniform_samples = np.random.rand(NUM_SAMPLES)

    # Generate exponential random variates using inverse CDF method
    exponential_samples = -np.log(uniform_samples) / LAMBDA_VAL

    plt.figure(figsize=(10, 6))
    plt.hist(
        exponential_samples,
        bins=50,
        density=True,
        alpha=0.6,
        color="teal",
        label="Generated Samples",
    )

    # Generate x values for plotting the theoretical PDF
    x_values = np.linspace(0, max(exponential_samples), 200)
    # Calculate the theoretical PDF for exponential distribution
    theoretical_pdf = expon.pdf(x_values, scale=1 / LAMBDA_VAL)  # scale = 1/lambda

    # Plot the theoretical PDF
    plt.plot(x_values, theoretical_pdf, "r-", label="Theoretical PDF", linewidth=2)
    plt.xlabel("Value")
    plt.ylabel("Probability Density")
    plt.title("Exponential Distribution: Generated Samples vs. Theoretical PDF")
    plt.legend()
    plt.grid(axis="y", linestyle="--", alpha=0.7)
    plt.show()

    return 0


if __name__ == "__main__":
    sys.exit(main())
