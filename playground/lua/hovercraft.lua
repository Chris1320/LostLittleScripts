--[[
Hovercraft

You run a hovercraft factory. Your factory makes ten hovercrafts in a month. Given
the number of customers you got that month, did you make a profit? It costs you
2,000,000 to build a hovercraft, and you are selling them for 3,000,000. You
also pay 1,000,000 each month for insurance.

Task:
Determine whether or not you made a profit based on how many of the ten
hovercrafts you were able to sell that month.

Input Format:
An integer that represents the sales that you made that month.

Output Format:
A string that says 'Profit', 'Loss', or 'Broke Even'.

Sample Input:
5

Sample Output:
Loss
--]]


function Main()
    local cost = 2000000  -- The cost to build one hovercraft.
    local price = 3000000  -- The price of one hovercraft when it is sold.
    local insurance = 1000000  -- Insurance per month.
    local monthly_production = 10  -- How many hovercrafts are being made each month.

    io.write("How many hovercrafts did you sell this month? > ")
    local customers = io.read("*n")  -- Get user input.

    local profit = price * customers - (cost * monthly_production) - insurance  -- Calculate profit
    if profit > 0 then
        print("Profit")
    elseif profit < 0 then
        print("Loss")
    else
        print("Broke Even")
    end
end

Main()

