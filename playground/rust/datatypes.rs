fn main()
{
    println!("Scalar datatypes:\n");
    println!("- Integer Types");
    println!("\t- i8:    ({0} to {1})", std::i8::MIN, std::i8::MAX);
    println!("\t- i16:   ({0} to {1})", std::i16::MIN, std::i16::MAX);
    println!("\t- i32:   ({0} to {1})", std::i32::MIN, std::i32::MAX);
    println!("\t- i64:   ({0} to {1})", std::i64::MIN, std::i64::MAX);
    println!("\t- i128:  ({0} to {1})", std::i128::MIN, std::i128::MAX);
    println!("\t- isize: ({0} to {1})", std::isize::MIN, std::isize::MAX);
    println!("\t- u8:    ({0} to {1})", std::u8::MIN, std::u8::MAX);
    println!("\t- u16:   ({0} to {1})", std::u16::MIN, std::u16::MAX);
    println!("\t- u32:   ({0} to {1})", std::u32::MIN, std::u32::MAX);
    println!("\t- u64:   ({0} to {1})", std::u64::MIN, std::u64::MAX);
    println!("\t- u128:  ({0} to {1})", std::u128::MIN, std::u128::MAX);
    println!("\t- usize: ({0} to {1})", std::usize::MIN, std::usize::MAX);
    println!("- Floating-Point Types");
    println!("\t- f32:   ({0} to {1})", std::f32::MIN, std::f32::MAX);
    println!("\t- f64:   ({0} to {1})", std::f64::MIN, std::f64::MAX);

    let a = b'A'; // byte representation (u8 only)
    let w = 0b1010_1010_1010_1010; // binary representation
    let x = 1_241_612;  // use _ to make large numbers more readable
    let y = 0x7a25be; // hexadecimal representation
    let z = 0o272136;  // octal representation
    println!("{}\n{}\n{}\n{}\n{}", a, w, x, y, z);
}
