module Project02_15

open utils

//
// isPrime i
//
// return true if i is prime, false otherwise
// A number is prime if it satisfies two conditions: 
//   1. The number is an integer greater than 1 (natural number excluding 1).   
//   2. The number n has only two integral solutions to the equation n = a * b ; a=n and b=1  OR  a=1 and b=n.
//     Alternative definitions you may find useful: 
//          The number is not formed as a product of two smaller natural numbers.
//          The number has a GCD of 1 with all natural numbers smaller than it.
//
// 
// Examples: 
//          isPrime 1 => false 
//          isPrime 2 => true
//          isPrime 4 => false
//          isPrime 7919 => true
//          isPrime 57714373 => false
//


let isPrime i =

    let counter = 2;

    let rec m t c = 
        let result = t % c
        match result with
        | _ when c=t -> true
        | 0 -> false
        | _ -> m t (c+1)

    if i=1 then false 
    elif i=2 then true
    else m i counter
    
    

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 15: isPrime"

    test (lazy (isPrime 1)) false NoException
    test (lazy (isPrime 2)) true NoException
    test (lazy (isPrime 4)) false NoException
    test (lazy (isPrime 7919)) true NoException
    test (lazy (isPrime 57714373)) false NoException
                
    printfn ""
    0 // return an integer exit code
    

