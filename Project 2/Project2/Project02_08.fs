module Project02_08

open utils

//
// reduce F L
//
// Reduces L to a single value by applying function F
// 
// Examples: reduce (fun x y -> x+y) []             => Unhandled Exception: System.ArgumentException
//           reduce (fun x y -> 2*x + y) [4]        => 4
//           reduce (fun x y -> 2*x + y) [4;5]        => 13
//           reduce (fun x y -> x) ["Sentences"; "are"; "captialized"]        => "Sentences"
//           reduce (fun x y -> x*y) [23; 4]        => 92
//           reduce (fun x y -> x+y) [23; 43; -60]  => 6 
//           reduce (fun x y -> if x > y then x else y) 
//                  ['c'; 'a'; 'n'; 'a'; 'd'; 'a']  => 'n' 
// 
// You may not call List.reduce directly in your solution.
// 
// 

let rec reduce F L =
    
    match L with
    | [] -> raise(System.ArgumentException("Error"))
    | head::[] -> head 
    | head::rest -> let holder = (F head rest.Head)::rest.Tail
                    reduce F holder
     
                    
//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 08: reduce"

    test (lazy (reduce (fun x y -> x + y) []))  0  (System.ArgumentException())
    test (lazy (reduce (fun x y -> 2*x + y) [4]))  4  NoException
    test (lazy (reduce (fun x y -> 2*x + y) [4;5]))  13  NoException
    test (lazy (reduce (fun x y -> x) ["Sentences"; "are"; "captialized"]))  "Sentences"  NoException
    test (lazy (reduce (*) [23; 4]))  92  NoException
    test (lazy (reduce (+) [23; 43; -60]))  6  NoException
    test (lazy (reduce (fun x y -> if x > y then x else y) 
                 ['c'; 'a'; 'n'; 'a'; 'd'; 'a']))  'n'  NoException

    printfn ""
    0 // return an integer exit code
    
