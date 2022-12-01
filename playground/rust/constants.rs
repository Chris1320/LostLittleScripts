fn main()
{
    const MAX_NUMBER: i32 = 10;  // datatype MUST be annotated.
    let number = 5;  // immutable
    println!("{}", number);
    /*
     * Both cannot be changed, but number can be shadowed
     * while MAX_NUMBER cannot.
     */

    let number = 7;  // shadows previous variable name
    println!("{}", number);

    println!("{}", MAX_NUMBER);
}
