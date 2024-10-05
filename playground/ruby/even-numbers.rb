#!/usr/bin/env ruby

# Ask the user for x and y
print "Enter the starting number: "
x = gets.chomp.to_i

print "Enter the ending number: "
y = gets.chomp.to_i

# Loop from x to y
(x..y).each do |num|
    if num % 2 == 0
        puts "#{num}"
    end
end
