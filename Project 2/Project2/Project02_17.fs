module Project02_17

open utils

//
// stringToCharList:
//
// Given a string s, expands the string into a list of characters.
// Example: stringToCharList "apple" => ['a';'p';'p';'l';'e']
//
let stringToCharList (s: string) =
    Seq.toList s


//
// isMatch str
// returns true if str has matching parentheses, and false otherwise 
//
// Examples:
//          isMatch ""              => true
//          isMatch "("             => false
//          isMatch ")("            => false
//          isMatch "outer (middle({<inner))" => true
//          isMatch "outer (middle(inner})" => false
//


let isMatch str =
    false         //   TO BE IMPLEMENTED


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 17: isMatch"

    test (lazy (isMatch ""              )) true NoException
    test (lazy (isMatch "("             )) false NoException
    test (lazy (isMatch "()"            )) true NoException
    test (lazy (isMatch ")("            )) false NoException
    test (lazy (isMatch "outer (middle({<inner))" )) true NoException
    test (lazy (isMatch "outer (middle(inner})" )) false NoException
                
    printfn ""
    0 // return an integer exit code
    

