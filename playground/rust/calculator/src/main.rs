use std::io;
use std::io::Write;  // for flushing the buffer

fn main()
{
    // Initialize strings for user input.
    let error_desc = "Please enter a valid number.";
    let mut num1 = String::new();
    let mut num2 = String::new();
    let mut operation = String::new();

    // Ask the user for inputs.
    print!("Enter the value of num1: ");
    io::stdout().flush().expect("");
    io::stdin().read_line(&mut num1).expect(error_desc);

    print!("Enter the value of num2: ");
    io::stdout().flush().expect("");
    io::stdin().read_line(&mut num2).expect(error_desc);

    println!("\n[1] Addition");
    println!("[2] Subtraction");
    println!("[3] Multiplication");
    println!("[4] Division\n");
    print!("Enter the number of the operation you want to perform: ");
    io::stdout().flush().expect("");
    io::stdin().read_line(&mut operation).expect(error_desc);

    // Convert user inputs to its respective types.
    let num1: f64 = num1.trim().parse().expect(error_desc);
    let num2: f64 = num2.trim().parse().expect(error_desc);
    let operation: i32 = operation.trim().parse().expect(error_desc);
    let answer = match operation {
        1 => num1 + num2,
        2 => num1 - num2,
        3 => num1 * num2,
        4 => num1 / num2,
        _ => 0.0
    };

    println!("\nNow you answer it...");
    let mut tries = 0;
    let mut question_answered = false;
    while tries < 3
    {
        let mut user_answer = String::new();
        print!("Answer: ");
        io::stdout().flush().expect("");
        io::stdin().read_line(&mut user_answer).expect(error_desc);
        let user_answer: f64 = user_answer.trim().parse().expect(error_desc);
        if user_answer == answer
        {
            question_answered = true;
            break;
        }
        else
        {
            tries += 1;
        }
    }

    if !question_answered
    {
        println!("So you DO need a calculator...");
    }
    else
    {
        println!("You answered it... Why do you need a calculator, then?");
    }

    match operation
    {
        1 => println!("The sum of {} + {} is {}.", num1, num2, answer),
        2 => println!("The difference of {} - {} is {}.", num1, num2, answer),
        3 => println!("The product of {} * {} is {}.", num1, num2, answer),
        4 => println!(
            "The quotient of {} / {} is {}, with a remainder of {}.",
            num1, num2, answer, num1 % num2
        ),
        _ => println!("Unknown operation.")
    }
}
