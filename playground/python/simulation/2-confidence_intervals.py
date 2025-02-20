#!/usr/bin/env python3

import sys
from typing import Final

import numpy as np
import matplotlib.pyplot as plt
import scipy.stats as stats

true_mean: Final[int] = 10  # true average waiting time
true_std: Final[int] = 2
confidence_level: Final[float] = 0.95
z_score = stats.norm.ppf((1 + confidence_level) / 2)  # for 95% confidence


def main() -> int:
    sample_sizes = [10, 30, 50, 100, 200]
    interval_widths = []

    for n in sample_sizes:
        # Simulate waiting times
        waiting_times = np.random.normal(true_mean, true_std, n)

        sample_mean = np.mean(waiting_times)
        sample_std = np.std(waiting_times, ddof=1)

        margin_of_error = z_score * (sample_std / np.sqrt(n))

        # Calculate confidence interval
        ci_lower = sample_mean - margin_of_error
        ci_upper = sample_mean + margin_of_error

        interval_widths.append(ci_upper - ci_lower)

        print(
            f"{n=}, {sample_mean=:.2f}, [{ci_lower=:.2f}, {ci_upper=:.2f}], width={ci_upper - ci_lower:.2f}"
        )

    plt.figure(figsize=(10, 6))
    plt.plot(sample_sizes, interval_widths, marker="o")
    plt.title("Sample Size on Confidence Interval Width")
    plt.xlabel("Sample Size")
    plt.ylabel("Confidence Interval Width")
    plt.grid()
    # plt.xscale("log")
    plt.xticks(sample_sizes)
    plt.show()

    return 0


if __name__ == "__main__":
    sys.exit(main())
