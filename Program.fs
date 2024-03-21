// For more information see https://aka.ms/fsharp-console-apps
//Step 1: Partial Application
// Define a function that takes an exponent and a value and returns the result of applying the exponent to the value
let power exponent value =
    value ** exponent
// Partially apply the function with exponent 2 to create a square function
let square = power 2.0
// Partially apply the function with exponent 3 to create a cube function
let cube = power 3.0
// Define a function to print the results of applying square and cube to a given value
let printResults value =
    
    printfn "Square of %.2f: %.2f" value (square value)
    printfn "Cube of %.2f: %.2f" value (cube value)
let functionResult = power 3.0 4.0
printfn"Step 1"
printfn "Output of the power Function: %.2f" functionResult
// Test the square and cube functions with different values
let test = [2.0; 3.0; 4.0]
List.iter printResults test

//Step 2 Tail Recursion 1:
let rec itemsInList lst =
    let rec itemsAcc item lst =
        match lst with
        | [] -> item
        | head::tail -> itemsAcc (item * head) tail
    itemsAcc 1 lst
// Test the function with a list of numbers
let testList = [1; 2; 3; 4; 5]
let product = itemsInList testList
printfn "Step 2"
printfn "Product of the list: %d" product

//Step 3 Tail Recursion 2: