function Main()
    io.write("Enter the height of the rectangle: ")
    height = io.read()
    io.write("Enter the width of the rectangle: ")
    width = io.read()
    print("The area of a " .. height .. 'x' .. width .. " rectangle is " .. (height * width))

end

Main()