use rand::Rng;           // For generating a random number.
use std::cmp::Ordering;  // For comparing num and guess.
use std::io;             // For stdin and stdout.
use std::io::Write;      // For flushing stdout.

fn main() {
    const MIN_GUESS: u32 = 1;  // The minimum possible number.
    const MAX_GUESS: u32 = 100;  // The maximum possible number.

    let num = rand::thread_rng().gen_range(MIN_GUESS..=MAX_GUESS);  // Generate a random number based on the constants.
    let mut tries = 5;  // Maximum number of guesses.
    println!("Guessing Game\n");
    loop {
        if tries == 0 {
            println!("You have run out of tries.");
            break;
        }

        print!("Please enter your guess ({MIN_GUESS}-{MAX_GUESS}): ");
        io::stdout().flush().expect("Failed to flush stdout.");
        let mut guess = String::new();  // Create a new string value.
        io::stdin().read_line(&mut guess).expect("Failed to read user input.");

        // "shadows" the previous `guess` variable. String -> u32
        let guess: u32 = match guess.trim().parse() {
            Ok(result) => result,  // return the result if OK.
            Err(_) => continue  // continue loop if parse() returned an error.
        };

        if guess < MIN_GUESS || guess > MAX_GUESS {
            println!("Valid guesses are {MIN_GUESS}-{MAX_GUESS} only.");
            continue;
        }

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
