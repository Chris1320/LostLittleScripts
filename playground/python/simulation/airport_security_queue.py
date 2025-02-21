import random
import statistics
from typing import Final

SIMULATION_DURATION: Final[int] = 480  # Total simulation time in minutes
ARRIVAL_RATE: Final[float] = 1 / 2  # average arrival every 2 minutes

# Service time parameters in minutes (for each passenger)
# Let me pretend I understand what these are...
SERVICE_TIME_MEAN: Final[int] = 4
SERVICE_TIME_STD: Final[int] = 1


# Use fewer staffs during first half and higher staffing during second half of the simulation
def get_staffing_level(current_time):
    return 2 if current_time < SIMULATION_DURATION / 2 else 3


class Passenger:
    """Class to represent a passenger in the simulation"""

    def __init__(self, arrival_time: float):
        self.arrival_time = arrival_time
        self.start_service_time: float | None = None
        self.departure_time: float | None = None
        self.wait_time: float | None = None


def simulate():
    """Run the simulation"""

    current_time = 0.0
    passengers: list[Passenger] = []

    # Maintain a list of staff next available times.
    current_staffing = get_staffing_level(0)
    staff_available_times = [0.0 for _ in range(current_staffing)]

    while current_time < SIMULATION_DURATION:
        # Generate next arrival time using exponential distribution
        # I just got this from the internet actually.
        inter_arrival = random.expovariate(1 / (1 / ARRIVAL_RATE))
        current_time += inter_arrival

        # If simulation time has been exceeded, exit loop
        if current_time >= SIMULATION_DURATION:
            break

        # Check and update staffing level based on the current simulation time.
        desired_staff_count = get_staffing_level(current_time)
        current_count = len(staff_available_times)
        if desired_staff_count > current_count:
            # Add additional staff who are available now
            staff_available_times.extend(
                [current_time] * (desired_staff_count - current_count)
            )
        elif desired_staff_count < current_count:
            # If staffing level decreases, we just trim the extra servers.
            staff_available_times = sorted(staff_available_times)[:desired_staff_count]

        passenger = Passenger(current_time)

        # Identify the next available staff member (i.e., the one with the minimum release time)
        next_available_index = staff_available_times.index(min(staff_available_times))
        next_available_time = staff_available_times[next_available_index]

        # Calculate when service can start for this passenger
        passenger.start_service_time = max(passenger.arrival_time, next_available_time)
        passenger.wait_time = passenger.start_service_time - passenger.arrival_time

        # Generate a random service time for this passenger (ensuring positive value)
        service_time = max(0.1, random.gauss(SERVICE_TIME_MEAN, SERVICE_TIME_STD))
        passenger.departure_time = passenger.start_service_time + service_time

        # Update the staff member's next available time
        staff_available_times[next_available_index] = passenger.departure_time

        passengers.append(passenger)  # Add passenger to the list

    return passengers


def main():
    # Run the simulation
    passengers = simulate()

    # Calculate average waiting time
    wait_times = [p.wait_time for p in passengers if p.wait_time is not None]
    avg_wait = statistics.mean(wait_times) if wait_times else 0

    # Count passengers processed
    total_passengers = len(passengers)

    # Report results
    print("Airport Security Queue Simulation")
    print("----------------------------------")
    print(f"Simulation Duration: {SIMULATION_DURATION} minutes")
    print(f"Total Passengers Processed: {total_passengers}")
    print(f"Average Waiting Time: {avg_wait:.2f} minutes")
    print(f"Max Waiting Time: {max(wait_times):.2f} minutes")
    print(f"Min Waiting Time: {min(wait_times):.2f} minutes")


if __name__ == "__main__":
    main()
