import os
import sys


def main() -> int:
    with open(os.path.join("..", "packets.txt"), 'r') as f:
        packets: list[str] = f.read().split('\n')

    for packet in packets:
        marker_found = False
        for idx, _ in enumerate(packet):  # Iterate through the packet.
            marker_candidate = packet[idx:idx + 4]
            if len(set(marker_candidate)) == 4:
                print(f"{idx + 4}:\t{marker_candidate}")
                marker_found = True
                break

        if not marker_found:
            print(f"[ERROR] Failed to find marker in packet `{packet}`.")

    return 0


if __name__ == "__main__":
    sys.exit(main())
