#!/usr/bin/env lua

function Main()
    io.write("Enter a string: ")
    local s = io.read()
    -- The `#` syntax is the length operator.
    print("You entered a string with " .. #s .. " characters.")

    return 0
end

os.exit(Main())
