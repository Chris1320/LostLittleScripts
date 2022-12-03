use std::io;
use std::io::Write;

fn main()
{
    let cost = 2_000_000.0;  // How much does it cost to build a hovercraft
    let price = 3_000_000.0;  // How much is the hovercraft being sold
    let insurance = 1_000_000.0;  // Paid every month
    let quantity = 10.0;  // How many hovercrafts are made every month.
    let mut number_of_customers = String::new();  // How many customers bought a hovercraft that month.

    print!("How many hovercrafts did you sell this month? > ");
    io::stdout().flush().expect("");
    io::stdin().read_line(&mut number_of_customers).expect("Enter a valid number.");

    let number_of_customers: f64 = number_of_customers.trim().parse().expect("Enter a valid number.");
    let profit = (number_of_customers * price) - (cost * quantity) - insurance;

    if profit == 0.0 {println!("Broke Even");}
    else if profit > 0.0 {println!("Profit");}
    else {println!("Loss");}
}
