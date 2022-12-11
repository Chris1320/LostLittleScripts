// Variables are immutable by default.

fn main()
{
    const PI: f64 = 3.1415;
    let name = "Bob";  // Assign the value Bob to variable name.
    let age = 12;
    let mut mutable_age = age;  // The `mut` keyword tells the compiler that the
                                // variable is mutable.

    // The following will result into a compiler error
    // because <age> is immutable.
    // age = 13;

    println!("{0}'s age is {1}.", name, mutable_age);
    mutable_age = 13;  // Change the value of a mutable variable.
    println!("{0}'s age used to be {1}, but now he is {2}.", name, age, mutable_age);
    println!("PI: {}", PI);

    // Multiple variable assignments
    let (country, temperature) = ("The Philippines", 36.5);

    println!("The temperature in {} is {}.", country, temperature);
}
