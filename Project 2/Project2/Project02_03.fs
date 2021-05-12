module Project02_03

open utils

//
// nth L n
//
// Returns nth element of L, or raise System.IndexOutOfRangeException if n is out of boundary
// 
// Examples: nth []   0       => raises an exception
//           nth [94] 2      => raises an exception
//           nth [94]  0      => 94
//           nth [94]  -1      => raises an exception 
//           nth [1; 45; 6] 1 => 45
//           nth [1; 45; 6] 5 => raises an exception
//           nth ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 5 => 'y'
// You may not call List.nth, List.Item, .[], etc directly in your solution.
// 

let rec nth L n =
    
    match L with 
    | [] -> raise(System.IndexOutOfRangeException("Index Not Found"))
    | head::_ when n < 0 -> raise(System.IndexOutOfRangeException("Index Not Found"))
    | head::rest when n > 0 -> nth rest (n-1)
    | head::_ -> head

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 03: nth"
    test (lazy (nth [] 0 ))       0   (System.IndexOutOfRangeException())
    test (lazy (nth [94] 2))       2   (System.IndexOutOfRangeException())
    test (lazy (nth [94]  0))       94  NoException
    test (lazy (nth [94]  -1))       -1   (System.IndexOutOfRangeException())
    test (lazy (nth [1; 45; 6] 1))       45   NoException
    test (lazy (nth [1; 45; 6] 5))       0   (System.IndexOutOfRangeException())
    test (lazy (nth ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 5))       'y'   NoException
    printfn ""
    0 // return an integer exit code
    

