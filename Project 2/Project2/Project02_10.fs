module Project02_10

open utils

//
// flatten L
//
// Flatten a list of lists to a single list
//
// Returns list 
// 
// Examples: 
//          flatten [[]] => []   
//          flatten [[1]] => [1]   // int list list provided on input, int list produced as output
//          flatten [[1; 2]; [2; 3; 4]] => [1; 2; 2; 3; 4]
//			flatten [['o'; 'n']; [' ']; ['w'; 'i'; 'n'; 'g'; 's']] => ['o'; 'n'; ' '; 'w'; 'i'; 'n'; 'g'; 's']
// 
// You may not call List.concat directly, though you may use the operators :: and @.
// 
// 

let rec flatten L =
    match L with 
    |[] -> []
    |head::[] -> head
    |head::rest -> head@rest.Head@flatten rest.Tail


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 10: flatten"

    test (lazy (flatten [[]]  ))    []  NoException
    test (lazy (flatten [[1]] ))   [1]  NoException
    test (lazy (flatten [[1; 2]; [2; 3; 4]] ))  [1; 2; 2; 3; 4]  NoException
    test (lazy (flatten [['o'; 'n']; [' ']; ['w'; 'i'; 'n'; 'g'; 's']] ))  
        ['o'; 'n'; ' '; 'w'; 'i'; 'n'; 'g'; 's']  NoException
        
    printfn ""
    0 // return an integer exit code
    

