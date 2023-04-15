use rand::Rng;           // For generating a random number.
use std::cmp::Ordering;  // For comparing num and guess.
use std::io;             // For stdin and stdout.
use std::io::Write;      // For flushing stdout.

fn main() {
    let num = rand::thread_rng().gen_range(1, 101);  // Generate a random number from 1 to 100.
    let mut tries = 5;                               // Maximum number of guesses.
    println!("Guessing Game\n");
    loop {
        if tries == 0 {
            println!("You have run out of tries.");
            break;
        }

        print!("Please enter your guess (1-100): ");
        io::stdout().flush().expect("Failed to flush stdout.");
        let mut guess = String::new();  // Create a new string value.
        io::stdin().read_line(&mut guess).expect("Failed to read user input.");

        // "shadows" the previous `guess` variable. String -> u32
        let guess: u32 = match guess.trim().parse() {
            Ok(num) => num,  // return num if result is OK.
            Err(_) => continue  // continue loop if parse() returned an error.
        };

        match guess.cmp(&num) {
            Ordering::Less => println!("Your number is too small."),
            Ordering::Greater => println!("Your number is too big."),
            Ordering::Equal => {
                println!("You got the right answer!");
                break;  // break out of loop.
            }
        }

        tries -= 1;
        println!("You have {tries} tries left.\n");
    }

    println!("\nThe number is {num}.");
}
