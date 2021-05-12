module Project02_01

open utils

//
// max L
//
// Returns maximum element of L, or raise System.ArgumentException if L is empty.
// 
// Examples: max []          => raise System.ArgumentException
//           max [-2; 4]     => 4
//           max [34]        => 34
//           max [10; 10; 9] => 10
//           max ['a'; 'e'; 'c'] => e
// 
// You may not call List.max directly in your solution.
// 

let rec max L =
   
    match L with 
    | [] -> raise(System.ArgumentException("List Is Empty"))
    | head::[] -> head
    | head::tail -> let other = max tail
                    if head > other then head else other

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 01: max"
    test (lazy (max []))       0  (System.ArgumentException())
    test (lazy (max [-2; 4]))  4  NoException
    test (lazy (max [34]))     34 NoException
    test (lazy (max [10; 10; 9]))  10 NoException
    test (lazy (max ['a'; 'e'; 'c']))  'e' NoException
    printfn ""
    0 // return an integer exit code
    

