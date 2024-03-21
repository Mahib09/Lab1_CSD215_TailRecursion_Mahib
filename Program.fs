let rec factorial_tail n acc =
    if n <= 1 then
        acc
    else
        factorial_tail (n - 1) (acc * n)

let result = factorial_tail 5 1
printfn "%d" result

//let rec factorial_non_tail n =
    //if n <= 1 then
       // 1
    //else
       // n * factorial_non_tail (n - 1)
