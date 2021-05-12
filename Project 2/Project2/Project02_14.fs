module Project02_14

open utils

//
// GCDList L
//
// Returns the greatest common divisor of a list of positive integers
// 
// Examples: 
//          GCDList [5;10]   => 5
//          GCDList [54; 24] => 6 
//          GCDList [54; 24; 9] => 3 
//          GCDList [341341341; 341341; 341; 2013; 1234321] => 11
//

let GCDList L =
    
    let valu = 0

    let rec gcd a b =
        match a with
        | 0 -> b
        | _ when b=0 -> a
        | _ when a>b -> gcd (a-b) b
        | _ -> gcd a (b-a)

    let rec helper2 list v =

        let value = v

        match list with
        | [] -> value
        | head::[] -> let holder = gcd v head
                      helper2 [] holder                           
        | head::rest when valu <> 0 -> let holder = gcd v head
                                       helper2 rest holder
        | head::rest -> let holder = gcd head rest.Head
                        helper2 rest.Tail holder

    helper2 L valu 

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 14: GCDList"

    test (lazy (GCDList [5; 10])) 5 NoException
    test (lazy (GCDList [54; 24])) 6 NoException
    test (lazy (GCDList [54; 24; 9])) 3 NoException
    test (lazy (GCDList [341341341; 341341; 341; 2013; 1234321])) 11 NoException
                
    printfn ""
    0 // return an integer exit code
    

