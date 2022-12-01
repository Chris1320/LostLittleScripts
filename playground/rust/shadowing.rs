fn main()
{
    let x = 5;  // immutable
    let mut y = 2;
    print!("{} ", x);
    println!("{}", y);

    let x = x + 3;  // SHADOWS variable x; you can change its type when shadowing.
    y *= x;  // y is mutable so we can OVERWRITE its value.
    print!("{} ", x);
    println!("{}", y);
}
