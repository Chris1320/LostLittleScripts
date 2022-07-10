function Main()
    -- We have a global variable `arg` that contains the arguments passed to the program.
    io.write("Hello " .. arg[1] .. " and " .. arg[2] .. ".\n")
    io.write("Goodbye " .. arg[2] .. " and " .. arg[1] .. ".\n")
end

Main()  -- Call the main function.
