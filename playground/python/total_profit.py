x = 0  # old users
y = 12000  # new users for the month
tp = 0  # total profit
for i in range(12):
    # old users subscribe for PHP 249
    # new users try the platform for free
    print(f"Month {i + 1}: {x} old users, {y} new users, PHP {x*249} profit")
    tp += x * 249
    x += y
    y = int(x * 0.05)  # 5% of old users become new users

# total profit for the year
print(f"Total profit for the year: PHP {tp}")
