use std::io;
use std::io::Write;

fn main()
{
    let mut x = String::new();
    let mut y = String::new();

    print!("Enter number x: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut x).expect("Cannot read input.");
    print!("Enter number y: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut y).expect("Cannot read input.");

    let x: i32 = x.trim().parse().expect("Invalid integer.");
    let y: i32 = y.trim().parse().expect("Invalid integer.");
    println!("Answer: {}", x * y);
}
