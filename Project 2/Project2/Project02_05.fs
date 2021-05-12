module Project02_05

open utils

//
// count L item
//
// Returns the number of times item appears in L
// 
// Examples: count [] 5 => 0 
//           count [10; 0; -15] 0  => 1
//           count [3; 45; 6; 3] 3  => 2
//           count ['f'; 'i'; 'n'; 'a'; 'l'; ' ' 
//                  'f'; 'a'; 'n'; 't'; 'a'; 's'; 'y'] 'f')) => 2
// You may not call List.find, List.pick, List.tryFind, List.nth, .[], etc directly in your solution, but you can call the nth function you implemented in exercise#03.
//

let rec count L item =
    match L with
    | [] -> 0
    | head::rest when head <= item && head >= item -> 1 + count rest item
    | head::rest -> 0 + count rest item
    
//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 05: count"
        
    test (lazy (count [] 5)) 0 NoException
    test (lazy (count [10; 0; -15] 0))  1 NoException
    test (lazy (count [3; 45; 6; 3] 3)) 2 NoException
    test (lazy (count ['f'; 'i'; 'n'; 'a'; 'l'; ' ' 
                       'f'; 'a'; 'n'; 't'; 'a'; 's'; 'y'] 'f')) 2 NoException
      
    printfn ""
    0 // return an integer exit code
    

