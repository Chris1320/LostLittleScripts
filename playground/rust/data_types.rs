fn main()
{
    // Rust is a statically-typed language, but most of the time the compiler can
    // infer the type of the variable we are using.
    // The following code is also a valid variable initialization:
    // let an_int = 512;

    let an_int: i32 = 512;  // All variations: u8, i8, u16, i16, u32, i32, u64, i64, u128, i128
    let a_float: f64 = 67.1262;  // All variations: f32, f64
    let a_boolean: bool = true;  // Another possible value: false
    let a_char: char = 'a';
    let a_tuple: (char, char, char, char, char) = ('H', 'E', 'L', 'L', 'O');
    let an_array: [i32; 3] = [2, 4, 6];

    println!("Integer:   {} (Range: {}-{})", an_int, std::i32::MIN, std::i32::MAX);
    println!("Float:     {}", a_float);  // `std::f64::MIN, std::f64::MAX)` to get the min and max values of f64.
    println!("Boolean:   {}", a_boolean);
    println!("Character: {}", a_char);
    println!("Tuple:     {:?}", a_tuple);
    println!("Array:     {:?}", an_array);
}