fun main() {
    // immutable variables
    val min_num = 3
    val max_num = 10
    val max_tries = 3
    val random_num = (min_num..max_num).random()
    var tries = 0  // mutable variable

    while (max_tries > tries++) {
        print("Please enter a number between $min_num and $max_num inclusive: ")
        var user_input = readLine()!!.toInt()

        if (user_input in min_num..max_num) {
            if (user_input == random_num) {
                println("You guessed the correct number: $random_num\n")
                return
            }
            println("You did not guess the correct number.")
            println("You have ${max_tries - tries} tries left.\n")
            continue
        }
        println("You entered $user_input which is not between $min_num and $max_num.")
        println("You have ${max_tries - tries} tries left.\n")
    }
    println("You have ran out of tries. The correct number was $random_num.\n")
    return
}
