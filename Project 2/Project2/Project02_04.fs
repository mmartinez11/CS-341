module Project02_04

open utils

//
// find L item
//
// Finds the first occurance of item in L and returns the index,
// or raise a System.ArgumentException if there isn't any.
//
// Examples: find [] 0 => raises a System.ArgumentException
// find [94] 2 => raises a System.ArgumentException
// find [94] 94 => 0
// find [3; 45; 6; 3] 6 => 2
// find [3; 45; 6; 3] 3 => 0
// find ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 'a' => raises a System.ArgumentException
// find ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 'y' => '5'
// You may not call List.find, List.pick, List.tryFind, List.nth, .[], etc directly
// in your solution, but you can call the nth function you implemented in exercise#03.
//

let rec find L item =
    match L with
    | [] -> raise(System.ArgumentException("Index Not Found"))
    | head::_ when head <= item && head >=item -> 0
    | head::rest -> 1 + find rest item

    
//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 04: find"
        
    test (lazy (find [] 0))    0 (System.ArgumentException())
    test (lazy (find [94] 2))  0 (System.ArgumentException())
    test (lazy (find [94] 94)) 0 NoException
    test (lazy (find [3; 45; 6; 3] 6)) 2 NoException
    test (lazy (find [3; 45; 6; 3] 3)) 0 NoException
    test (lazy (find ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 'a')) 0 (System.ArgumentException())
    test (lazy (find ['q'; 'w'; 'e'; 'r'; 't'; 'y'] 'y')) 5 NoException
      
    printfn ""
    0 // return an integer exit code
    

