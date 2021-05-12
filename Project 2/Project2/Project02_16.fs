module Project02_16

open utils
//open Project02_15 // you can import functions from a previous project
//
// Primes t
// returns all the primes from 1 to t in a list, in ascending order.
// You can assume the input is greater than 0.
//
// Examples:
//          Primes 1 => []
//          Primes 2 => [2]
//          Primes 4 => [2;3]
//          Primes 11 => [2;3;5;7;11]
//



let rec Primes t =

    let isPrime i =

        let counter = 2;

        let rec helper a c = 
            let result = a % c
            match result with
            | _ when c=a -> true
            | 0 -> false
            | _ -> helper a (c+1)

        if i=1 then false 
        elif i=2 then true
        else helper i counter

    
    let rec blist m =
        let mark = m;
        let result = isPrime mark
    
        match result with
        | false when mark=t -> []
        | true when mark=t -> [t]
        | false -> blist (mark+1)
        | true -> mark::blist (mark+1)

    blist 0



//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 16: Primes"

    test (lazy (Primes 1)) [] NoException
    test (lazy (Primes 2)) [2] NoException
    test (lazy (Primes 4)) [2;3] NoException
    test (lazy (Primes 11)) [2;3;5;7;11] NoException
                
    printfn ""
    0 // return an integer exit code
    

