--[[
Time Converter

You need a program to convert days to seconds.
The given code takes the amount of days as input.

Complete the code to convert it to seconds and output the result.

Sample Input:
12

Sample Output:
1036800
--]]

function Main()
    io.write("Enter the number of days to convert to seconds: ");
    local days = io.read("*n")
    print(days * 24 * 60 * 60)
end

Main()
