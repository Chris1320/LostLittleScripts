import random
import statistics
from typing import Final

SIMULATION_DAYS: Final[int] = 180
INITIAL_INVENTORY: Final[int] = 100

AVERAGE_DEMAND: Final[int] = 5  # average daily demand
DEMAND_STD_DEV: Final[int] = 2

LEAD_TIME: Final[int] = 2  # days between placing an order and receiving it
ORDER_QUANTITY: Final[int] = 50
REORDER_POINT: Final[int] = 30

HOLDING_COST_PER_UNIT: Final[float] = 0.5  # per day
STOCKOUT_COST_PER_UNIT: Final[float] = 5

# Use a flag to choose demand distribution: 'normal' or 'poisson'
DEMAND_DISTRIBUTION = "normal"


class Order:
    """Class to represent an order."""

    def __init__(self, arrival_day: int, quantity: int):
        self.arrival_day = arrival_day
        self.quantity = quantity


def generate_daily_demand():
    """Generate daily demand based on the selected distribution."""

    # I definitely did not get this somewhere in the internet
    if DEMAND_DISTRIBUTION == "normal":
        demand = random.gauss(AVERAGE_DEMAND, DEMAND_STD_DEV)
        return max(0, round(demand))

    elif DEMAND_DISTRIBUTION == "poisson":
        # Poisson distribution: using random.poissonvariate if available, else approximate.
        # Python's random module does not have a poissonvariate, so we implement a simple version.
        L = pow(2.71828, -AVERAGE_DEMAND)
        k = 0
        p = 1.0
        while p > L:
            k += 1
            p *= random.random()

        return k - 1

    else:
        # Default to average demand if distribution not recognized
        return AVERAGE_DEMAND


def simulate_inventory():
    """Run the inventory management simulation."""

    day: int = 0
    inventory_level: int = INITIAL_INVENTORY
    total_holding_cost: float = 0
    total_stockout_cost: float = 0

    pending_orders: list[Order] = []

    inventory_history: list[int] = []
    stockout_history: list[int] = []
    restock_days: list[int] = []

    # Run simulation for designated period
    while day < SIMULATION_DAYS:
        # Process arriving orders
        pending_orders.sort(key=lambda x: x.arrival_day)
        if pending_orders and pending_orders[0].arrival_day == day:
            order = pending_orders.pop(0)
            inventory_level += order.quantity
            print(
                f"Day {day}: Received order of {order.quantity}. Inventory now {inventory_level}."
            )

        demand = generate_daily_demand()
        print(f"Day {day}: Demand generated: {demand}")

        if inventory_level >= demand:
            inventory_level -= demand
            stockout = 0

        else:
            stockout = demand - inventory_level
            inventory_level = 0

        # Calculate daily costs
        holding_cost = inventory_level * HOLDING_COST_PER_UNIT
        stockout_cost = stockout * STOCKOUT_COST_PER_UNIT
        total_holding_cost += holding_cost
        total_stockout_cost += stockout_cost

        inventory_history.append(inventory_level)
        stockout_history.append(stockout)

        if inventory_level <= REORDER_POINT:
            if not any(order.arrival_day > day for order in pending_orders):
                order_arrival_day = day + LEAD_TIME
                pending_orders.append(Order(order_arrival_day, ORDER_QUANTITY))
                restock_days.append(day)
                print(
                    f"Day {day}: Placed order of {ORDER_QUANTITY} to arrive on day {order_arrival_day}."
                )

        day += 1

    # Calculate average time between restocks
    if len(restock_days) > 1:
        restock_intervals = [
            restock_days[i] - restock_days[i - 1] for i in range(1, len(restock_days))
        ]
        average_restock_interval = statistics.mean(restock_intervals)
    else:
        average_restock_interval = 0

    results = {
        "total_days": SIMULATION_DAYS,
        "final_inventory": inventory_level,
        "total_holding_cost": total_holding_cost,
        "total_stockout_cost": total_stockout_cost,
        "total_cost": total_holding_cost + total_stockout_cost,
        "average_inventory": (
            statistics.mean(inventory_history) if inventory_history else 0
        ),
        "inventory_history": inventory_history,
        "stockout_history": stockout_history,
        "average_restock_interval": average_restock_interval,
    }

    return results


def main():
    """Main function to run the simulation and display results."""

    results = simulate_inventory()

    print("\nInventory Management Simulation Results")
    print("------------------------------------------")
    print(f"Total Simulation Days: {results['total_days']}")
    print(f"Final Inventory Level: {results['final_inventory']}")
    print(f"Average Inventory Level: {results['average_inventory']:.2f}")
    print(f"Total Holding Cost: PHP {results['total_holding_cost']:.2f}")
    print(f"Total Stockout Cost: PHP {results['total_stockout_cost']:.2f}")
    print(f"Total Cost (Holding + Stockout): PHP {results['total_cost']:.2f}")
    print(
        f"Average Time Between Restocks: {results['average_restock_interval']:.2f} days"
    )


if __name__ == "__main__":
    main()
