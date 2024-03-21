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
let rec productofListItem lst =
    let rec itemsAcc item lst =
        match lst with
        | [] -> item
        | head::tail -> itemsAcc (item * head) tail
    itemsAcc 1 lst
// Test the function with a list of numbers
let testList = [1; 2; 3; 4; 5]
let product = productofListItem testList
printfn "Step 2"
printfn "Product of the list: %d" product

//Step 3 Tail Recursion 2:
let productOfOddNumbersInList lst =
    let rec itemAcc acc lst =
        match lst with
        | [] -> acc
        | head::tail ->
            if head % 2 = 0 then
                itemAcc acc tail // Skip even numbers
            else
                itemAcc (acc * head) tail // Multiply accumulator by odd numbers
    productAcc 1 lst
// Test the function with a list of numbers
let myList = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
let product = productOfOddNumbersInList myList
printfn "Step 3"
printfn "Product of odd numbers in the list: %d" product

//Step 4 Use of Map function
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = List.map (fun name -> name.Trim()) names
// Print the trimmed names
printfn "Trimmed names: %A" trimmedNames

//Step 5 Using Filter and Reduce with a Collection:
// Create a sequence of the first 700 positive integers
let numbersSequence = Seq.initInfinite (fun i -> i + 1)
// Convert the sequence into a list
let numbersList = Seq.toList numbersSequence
// Filter out numbers that are multiples of both 7 and 5
let filteredNumbers = List.filter (fun x -> x % 7 <> 0 || x % 5 <> 0) numbersList
// Sum all the filtered numbers using the reduce function
let sum = List.reduce (+) filteredNumbers
// Print the sum
printfn "Sum of filtered numbers: %d" sum
