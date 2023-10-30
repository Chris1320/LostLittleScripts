--- This is the Lua version of the solution for
--- the LeetCode problem "Two Sum".
local function solution(num_list, target)
    -- Iterate through the list to find the two numbers
    -- that sum up to <target>.
    for i = 1, #num_list do
        for j = i + 1, #num_list do
            if num_list[i] + num_list[j] == target then
                return { i, j }
            end
        end
    end
end

--- Helper function to test the solution.
local function testSolution(idx, num_list, target, expect)
    local reality = solution(num_list, target) -- Get the result.
    -- Compare the result with the expected values.
    if reality[1] == expect[1] and reality[2] == expect[2] then
        print(string.format("Test %d: pass", idx))
    else
        print(
            string.format(
                "Test %d: fail [Result: %s][Expecting: %s]",
                idx,
                string.format("{%s}", table.concat(reality, ',')),
                string.format("{%s}", table.concat(expect, ','))
            )
        )
    end
end

-- Test the solution.
testSolution(1, { 2, 7, 11, 15 }, 9, { 1, 2 })
testSolution(2, { 3, 2, 4 }, 6, { 2, 3 })
testSolution(3, { 3, 3 }, 6, { 1, 2 })
