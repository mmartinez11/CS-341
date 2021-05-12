module Project02_12

open utils

//
// unzip L
//
// Unzip a list of pairs to a pair of lists.  Reversing the zip procedure, takes a list of
// tuples and separates it into two component lists, returning both in a single tuple.
//
// Returns tuple of lists
// 
// Examples: 
//          unzip [] => ([], [])
//          unzip [(1, 3); (2, 56); (40, 6)] => ([1; 2; 40], [3; 56; 6])
//          unzip [(1, 'a'); (2, 'b'); (3, 'c')] => ([1; 2; 3], ['a'; 'b'; 'c'])
//
// You may not call List.unzip directly in your solution.
//
//

let rec unzip L =
    match L with
    | [] -> ([],[])
    | (a,b)::[] -> ([a],[b])
    | (a,b)::tl -> let (c,d) =  (unzip tl)
                   (a::c,b::d)


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 12: unzip"

    test (lazy (unzip []))   ([], [])  NoException   
    test (lazy (unzip [(1, 3); (2, 56); (40, 6)]))  ([1; 2; 40], [3; 56; 6])  NoException
    test (lazy (unzip [(1, 'a'); (2, 'b'); (3, 'c')]))  ([1; 2; 3], ['a'; 'b'; 'c'])  NoException   
        
    printfn ""
    0 // return an integer exit code
    

