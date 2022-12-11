fn main()
{
    let x = (128, 3.1415, true, "A String!");  // This will be used in one of the examples below.

    // println!(15)  // invalid
    println!("{}", 15);  // valid

    // Basic formatting
    println!("{}, {}!", "Hello", "World");

    // Positional formatting
    println!("{0}, {1}! {0}, {2}!", "Hello", "World", "Universe");

    // Named formatting
    println!("The color of the {animal} is {color}.", animal="dog", color="brown");

    // Placeholder traits
    println!("The binary, octal, and hexadecimal forms of the number {0} are {0:b}, {0:o}, and {0:x} respectively.", 75);

    // Placeholder traits (Debugging)
    println!("These are the contents of the tuple x: {:?}", x);
}