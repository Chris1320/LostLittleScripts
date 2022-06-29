function factorial(x)
    if x == 0 then
        return 1

    else
        return x * factorial(x - 1)

    end
end

function main()
    io.write("Enter a number: ")  -- Write to stdout without a newline.
    local n = io.read("*n")  -- Read user input.
    -- `..` is the concatenation operator.
    print("Factorial of " .. n .. " is " .. factorial(n) .. '.')
end

main()

