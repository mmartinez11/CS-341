module Project02_07

open utils

//
// iter F L
//
// Applies function F to the elements of L
// 
// Examples: iter (fun x -> printfn "%A squared is %A" x (x*x) ) [1; 2] => 1 squared is 1
//                                                                         2 squared is 4
//           iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']     => true
//           iter (fun x -> printfn "Iterating...") []              =>       // No output
// 
// You may not call List.iter directly in your solution.
// 

let iter F L =
   for i in L do F i


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 07: iter"

    // This one is trickier to test because there is no return value to be checked.
    iter (fun x -> printf "%c" x) ['t'; 'r'; 'u'; 'e']
    printfn ""
    printfn "Pass if the above outputs true"
    printfn ""
    0 // return an integer exit code
    

