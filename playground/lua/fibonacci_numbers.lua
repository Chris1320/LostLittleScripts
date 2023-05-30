-- Get the next fibonacci number from x and y.
local function nextFibonacciNumber(x, y)
    return x + y
end

local function main()
    io.write("How many fibonacci numbers do you want to see? > ")
    local nums = io.read('n')

    -- Set up the first three fibonacci numbers.
    local x = 1
    local y = 1
    local z = nextFibonacciNumber(x, y)
    local n = 0

    io.write("\nListing " .. nums .. " Fibonacci numbers...\n\n")

    if nums >= 1 then
        n = n + 1
        io.write('[' .. n .. '] ' .. x .. '\n')
    end

    if nums >= 2 then
        n = n + 1
        io.write('[' .. n .. '] ' .. y .. '\n')
    end

    if nums >= 3 then
        n = n + 1
        io.write('[' .. n .. '] ' .. z .. '\n')
    end

    while n < nums do
        x = y
        y = z
        z = nextFibonacciNumber(x, y)
        n = n + 1
        io.write('[' .. n .. '] ' .. z .. '\n')
    end
    return 0
end

os.exit(main())
