module Project02_06

open utils

//
// map F L
//
// Maps function F to L - Returns list produced by mapping function F over L
// 
// Examples: map (fun x -> x + 1) []                  => []
//           map (fun x -> x + 1) [23]                => [24]
//           map (fun x -> x - 1) [23; 43]            => [22; 42]
//           map (fun i -> (char i)) [99; 97; 115; 116] => ['c';'a';'s';'t']
//           map (fun c -> (char ((int c)+1))) ['a';'b';'c']  => ['b';'c';'d']
// 
// You may not call List.map directly in your solution.
// 

let rec map F L =
    match L with
    | [] -> []
    | head::rest -> F head::map F rest


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 06: map"
    test (lazy (map (fun x -> x + 1) [] ))  []  NoException
    test (lazy (map (fun x -> x + 1) [23]))  [24]  NoException
    test (lazy (map (fun x -> x - 1) [23; 43])) [22; 42]  NoException
    test (lazy (map (fun i -> (char i)) [99; 97; 115; 116]))  ['c';'a';'s';'t']  NoException
    test (lazy (map (fun c -> (char ((int c)+1))) ['a';'b';'c']))  ['b';'c';'d'] NoException
    
    printfn ""
    0 // return an integer exit code
    

