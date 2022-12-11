fn main()
{
    // println!(15)  // invalid
    println!("{}", 15);  // valid

    // Basic formatting
    println!("{}, {}!", "Hello", "World");

    // Positional formatting
    println!("{0}, {1}! {0}, {2}!", "Hello", "World", "Universe");

    // Named formatting
    println!("The color of the {animal} is {color}.", animal="Dog", color="Brown");
}