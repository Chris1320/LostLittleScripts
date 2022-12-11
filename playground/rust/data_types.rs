fn main()
{
    let an_int: i32 = 512;  // All variations: u8, i8, u16, i16, u32, i32, u64, i64, u128, i128
    let a_float: f64 = 67.1262;  // All variations: f32, f64
    let a_boolean: bool = true;  // Another possible value: false
    let a_char: char = 'a';
    let a_tuple: (char, char, char, char, char) = ('H', 'E', 'L', 'L', 'O');
    let an_array: [i32; 3] = [2, 4, 6];

    println!("Integer:   {}", an_int);
    println!("Float:     {}", a_float);
    println!("Boolean:   {}", a_boolean);
    println!("Character: {}", a_char);
    println!("Tuple:     {:?}", a_tuple);
    println!("Array:     {:?}", an_array);
}