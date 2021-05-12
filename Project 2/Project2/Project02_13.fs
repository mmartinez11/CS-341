module Project02_13

open utils

//
// GCD A B
//
// Returns the greatest common divisor of A and B
// Takes two integers as input, returns an integer
// Two co-prime numbers will have a GCD of 1
// 
// Examples: 
//          GCD 5 10  => 5
//          GCD 54 24 => 6 
//          GCD 341341341 341341 => 341
//

let rec GCD A B =

    let rec helper a b =
        match a with
        | 0 -> b
        | _ when b=0 -> a
        | _ when a>b -> helper (a-b) b
        | _ -> helper a (b-a)

    helper A B

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 13: GCD"

    test (lazy (GCD 5 10)) 5 NoException
    test (lazy (GCD 54 24)) 6 NoException
    test (lazy (GCD 341341341 341341)) 341 NoException
                
    printfn ""
    0 // return an integer exit code
    

