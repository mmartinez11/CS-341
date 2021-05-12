module Project02_09

open utils

//
// fold F accumulator L
//
// Applies a function f to each element of the collection, threading an accumulator argument through the computation.
//
// Returns a value 
// 
// Examples: 
//          fold (fun x y -> x&&y) true [] => true
//          fold (fun x y -> x) "first" [1;2;3] => "first"
//          fold (fun x y -> x+(string y)) "Hello " ['W';'o';'r';'l';'d'] => "Hello World"
//          fold (fun x y -> x+y) -60 [23; 43; 6] => 12
//          fold (fun x y -> x*y) 1 [23; 5; 80] => 9200
//          fold (fun x y -> x*(1.0+(double y)/100.0)) 100.0 [10; -5; -5] => 99.275
//          
// You may not call List.fold directly in your solution.
// 

let rec fold F start L =
    
    //let newList = start::L

    match L with
    | [] -> start
    | head::[] -> F start head
    | head::rest -> fold F (F start head) rest 
     

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 09: fold"

    test (lazy (fold (fun x y -> x&&y) true []))  true  NoException
    test (lazy (fold (fun x y -> x) "first" [1;2;3]))  "first"  NoException
    test (lazy (fold (fun x y -> x+(string y)) "Hello " ['W';'o';'r';'l';'d']))  "Hello World"  NoException
    test (lazy (fold (+) -60 [23; 43; 6]))  12  NoException
    test (lazy (fold (*) 1 [23; 5; 80]))  9200  NoException
    test (lazy (fold (fun x y -> x*(1.0+(double y)/100.0)) 100.0 [10; -5; -5]))  99.275  NoException
        
    printfn ""
    0 // return an integer exit code
    

