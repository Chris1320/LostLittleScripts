#!/usr/bin/env python3

"""
Task:  Fit a distribution to a dataset of arrival times and visualize results
Tools: Python, Matplotlib
Analyze:
    - Best-fit distribution
    - Parameters
    - Goodness-of-fit metrics (KS statistic)
    - Visualization of the empirical data vs fitted PDFs
"""

import csv
import sys
import time
from pathlib import Path
from typing import Any
from datetime import datetime

import numpy as np
from scipy import stats
import matplotlib.pyplot as plt

import kagglehub


def get_dataset() -> Path:
    """Download dataset from KaggleHub."""

    filename = "Data_Train.csv"

    return Path(
        kagglehub.dataset_download("muhammadbinimran/flight-price-prediction")
    ) / Path(filename)


def time_to_minutes(tm_struct: time.struct_time) -> int:
    """Convert a time.struct_time (with hour and minute) to minutes since midnight."""

    return tm_struct.tm_hour * 60 + tm_struct.tm_min


def extract_arrival_minutes(data: list[dict[str, Any]]) -> np.ndarray:
    """Given the dataset, extract the arrival times (converted to minutes-since-midnight)."""

    arrival_minutes: list[int] = []

    for entry in data:
        tm_struct = entry["Arrival_Time"]
        minutes = time_to_minutes(tm_struct)
        arrival_minutes.append(minutes)

    return np.array(arrival_minutes, dtype=float)


def fit_distribution(
    data: np.ndarray, distribution: stats.rv_continuous
) -> tuple[tuple[Any], float]:
    """
    Fit a distribution to data.
    Returns the fitted parameters and the KS statistic.
    """

    params = distribution.fit(data)
    D, _ = stats.kstest(data, distribution.name, args=params)
    return (params, D)


def plot_fit(
    data: np.ndarray,
    x_values: np.ndarray,
    candidate_distributions: dict[str, stats.rv_continuous],
    fit_results: dict[str, dict[str, float]],
) -> None:
    """Create a plot of the histogram of data overlaid with the fitted PDFs of candidate distributions."""

    print("Creating plot...")
    plt.figure(figsize=(10, 6))

    # Plot histogram of data
    plt.hist(
        data, bins=30, density=True, alpha=0.5, color="gray", label="Data Histogram"
    )

    # Plot Probability Distribution Function (PDF) for each candidate distribution
    for dist_name, dist in candidate_distributions.items():
        params = fit_results[dist_name]["params"]
        pdf_values = dist.pdf(x_values, *params)
        plt.plot(
            x_values,
            pdf_values,
            lw=2,
            label=f"{dist_name} (KS: {fit_results[dist_name]['ks_stat']:.4f})",
        )

    print("Plotting...")
    # Eyy I just looked this up
    plt.xlabel("Arrival Time (minutes since 00:00)")
    plt.ylabel("Density")
    plt.title("Empirical Data vs Fitted Distribution PDFs")
    plt.legend()
    plt.grid(True)
    plt.tight_layout()
    plt.show()


def main() -> int:
    """Main function."""

    dataset_fp: Path = get_dataset()
    print("Dataset:", dataset_fp)
    print()

    data: List[dict[str, Any]] = []
    with open(dataset_fp, "r", encoding="utf-8") as file:
        dataset = csv.reader(file)
        header = next(dataset)  # Skip header

        for row in dataset:
            # Expected columns:
            # Airline,Date_of_Journey,Source,Destination,Route,Dep_Time,Arrival_Time,Duration,Total_Stops,Additional_Info,Price
            try:
                doj = datetime.strptime(row[1], "%d/%m/%Y")
                dep_time = time.strptime(row[5], "%H:%M")

                # Handle two possible arrival time formats
                arr_time = (
                    time.strptime(row[6], "%H:%M %d %b")
                    if len(row[6].split()) == 3
                    else time.strptime(row[6], "%H:%M")
                )

            except Exception as e:
                print(f"Error parsing row: {row} -> {e}", file=sys.stderr)
                continue

            data.append(
                {
                    "Airline": row[0],
                    "Date_of_Journey": doj,
                    "Source": row[2],
                    "Destination": row[3],
                    "Route": row[4],
                    "Dep_Time": dep_time,
                    "Arrival_Time": arr_time,
                    "Duration": row[7],
                    "Total_Stops": row[8],
                    "Additional_Info": row[9],
                    "Price": int(row[10]),
                }
            )

    arrival_minutes = extract_arrival_minutes(data)
    print(f"Number of entries: {len(arrival_minutes)}")

    # Define candidate distributions
    candidate_distributions: dict[str, stats.rv_continuous] = {
        "normal": stats.norm,  # Normal distribution
        "gamma": stats.gamma,  # Gamma distribution
        "lognorm": stats.lognorm,  # Lognormal distribution
    }

    print()
    fit_results = {}
    for name, dist in candidate_distributions.items():
        params, ks_stat = fit_distribution(arrival_minutes, dist)
        print(f"Distribution: {name}")
        print(f"- Fitted parameters: {params}")
        print(f"- KS statistic: {ks_stat:.4f}\n")
        fit_results[name] = {"params": params, "ks_stat": ks_stat}

    best_dist = min(fit_results.items(), key=lambda kv: kv[1]["ks_stat"])
    print("Best fitting distribution:", best_dist[0])
    print("Parameters:", best_dist[1]["params"])
    print("KS statistic:", best_dist[1]["ks_stat"])

    # Prepare x values for plotting PDFs
    x_min = arrival_minutes.min() - 10
    x_max = arrival_minutes.max() + 10
    x_values = np.linspace(x_min, x_max, 500)

    # Plot histogram and fitted PDFs
    print()
    plot_fit(arrival_minutes, x_values, candidate_distributions, fit_results)

    return 0


if __name__ == "__main__":
    sys.exit(main())
