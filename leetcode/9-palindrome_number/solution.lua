local function solution(num)
    return tostring(num) == string.reverse(tostring(num))
end

local function test(i, num, expect)
    if solution(num) == expect then
        print("Test " .. i .. " passed!")
    else
        print("Test " .. i .. " failed!")
    end
end

local test_data = {
    {121, true},
    {1285, false},
    {1527251, true},
    {1234567890987654321, true},
    {6910275, false}
}

for i, v in ipairs(test_data) do
    test(i, v[1], v[2])
end
