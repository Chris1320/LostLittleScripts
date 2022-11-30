use std::io;
use rand::Rng;
use std::cmp::Ordering;

fn main()
{
    let num = rand::thread_rng().gen_range(1, 101);  // Generate a number from 1 to 100.
    println!("Guessing Game");
    loop {
        println!("Please enter your guess: ");
        let mut guess = String::new();  // Create a new string value.
        io::stdin().read_line(&mut guess).expect("Failed to read user input.");

        // "shadows" the previous `guess` variable. String -> u32
        let guess: u32 = match guess.trim().parse()
        {
            Ok(num) => num,  // return num if result is OK.
            Err(_) => continue  // continue loop if parse() returned an error.
        };

        match guess.cmp(&num)  // Match result of guess.cmp()
        {
            Ordering::Less => println!("Your number is too small."),
            Ordering::Greater => println!("Your number is too big."),
            Ordering::Equal => {
                println!("You got the right answer!");
                break;  // break out of loop.
            }
        }
    }

    println!("The number is {}.", num);
}
