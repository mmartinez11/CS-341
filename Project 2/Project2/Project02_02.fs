module Project02_02

open utils

//
// min L
//
// Returns minimum element of L, or raise System.ArgumentException if L is empty.
// 
// Examples: min []          =>  raises an exception
//           min [-2; 4]     => -2
//           min [34]        => 34
//           min [10; 9; 9; 101] => 9 
//           min ['d', 'r', 'b'] => b
//
// You may not call List.min directly in your solution.
// 

let rec min L =

    match L with
    | [] -> raise(System.ArgumentException("List Is Empty"))
    | head::[] -> head
    | head::tail -> let other = min tail
                    if head < other then head else other


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 02: min"
    test (lazy (min []))       0   (System.ArgumentException())
    test (lazy (min [-2; 4]))  -2  NoException
    test (lazy (min [34]))     34  NoException
    test (lazy (min [10; 10; 9; 101]))  9 NoException
    test (lazy (min ['d'; 'r'; 'b']))  'b' NoException
    printfn ""
    0 // return an integer exit code
    


