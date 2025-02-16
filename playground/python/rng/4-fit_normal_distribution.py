import sys

import numpy as np
import pandas as pd
import scipy.stats as stats
import matplotlib.pyplot as plt


def generate_dataset() -> pd.DataFrame:
    """Generate a dataset of total_bill values."""

    np.random.seed(42)

    total_bill = np.random.normal(loc=20, scale=5, size=500)
    total_bill = np.clip(
        total_bill, a_min=5, a_max=None
    )  # Clip to ensure total_bill >= 5

    return pd.DataFrame({"total_bill": total_bill})


def main() -> int:
    """Main function."""

    df = generate_dataset()
    data_total_bill = df["total_bill"]

    mu, std = stats.norm.fit(data_total_bill)
    print(f"Fitted Normal Distribution for total_bill: mu = {mu:.2f}, std = {std:.2f}")

    plt.figure(figsize=(8, 6))
    count, bins, ignored = plt.hist(
        data_total_bill,
        bins=20,
        density=True,
        alpha=0.6,
        color="teal",
        edgecolor="lightblue",
    )
    xmin, xmax = plt.xlim()
    x_fit = np.linspace(xmin, xmax, 100)
    p_fit = stats.norm.pdf(x_fit, mu, std)

    plt.plot(x_fit, p_fit, "r", lw=2, label="Fitted Normal PDF")
    plt.xlabel("Total Bill")
    plt.ylabel("Density")
    plt.title("Fit Normal Distribution of `total_bill`")
    plt.legend()
    plt.show()


if __name__ == "__main__":
    sys.exit(main())
