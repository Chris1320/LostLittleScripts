use std::io;

fn main()
{
    let num: i8;
    let mut user_input = String::new();  // user input

    println!("Enter a number from -128 to 127 below:");
    io::stdin().read_line(&mut user_input).expect("Cannot get user input.");
    num = user_input.trim().parse().expect("Enter a valid number.");
    println!("Number: {}", num);
}
