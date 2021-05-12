module Project02_11

open utils

//
// zip L1 L2
//
// Zip two lists together, forming a list of pairs where the first element at index i is
// taken from the first list at index i, and the second element at index i is taken from
// the second list at index i.
//
// Returns a list of tuples (a*b) list where L1 has type a list and L2 has type b list
// 
// Examples: 
//          zip [] [] => []
//          zip [1] [1] => [(1, 1)]
//          zip [1; 2; 40] [3; 56; 6] => [(1, 3); (2, 56); (40, 6)]
//          zip [1; 2; 3] ['a'; 'b'; 'c'] => [(1, 'a'); (2, 'b'); (3, 'c')]
//          
// You may not call List.zip directly in your solution.
// 
// 

let rec zip L1 L2 =
   
      if  L1 = [] && L2 = [] then []
      else ((List.head L1), (List.head L2))::(zip (List.tail L1) (List.tail L2))

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 11: zip"

    test (lazy (zip [] []))  []  NoException   
    test (lazy (zip [1] [1]))  [(1, 1)]  NoException
    test (lazy (zip [1; 2; 40] [3; 56; 6]))  [(1, 3); (2, 56); (40, 6)]  NoException
    test (lazy (zip [1; 2; 3] ['a'; 'b'; 'c']))  [(1, 'a'); (2, 'b'); (3, 'c')]  NoException
    
    printfn ""
    0 // return an integer exit code
    

