module Project02_18

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
// charListToString
//
// The opposite of stringToCharList --- given a list of characters, returns
// the list as a string.  Example: charListToString ['t';'h';'e'] => "the"
//
let charListToString L =
    let sb = System.Text.StringBuilder()
    L |> List.iter (fun c -> ignore (sb.Append (c:char)))
    sb.ToString()  
  
  
//
// firstMatch s
// returns a string containing the content within the first pair of matching parentheses
//  first means started first with a '(' not ended first with a ')'
//
// Examples:
// 	      firstMatch ""   => ""
//        firstMatch "()" => ""
//        firstMatch "phrase (comment)" => "comment"
//        firstMatch "phrase (comment) Furthermore (details)" => "comment"
//        firstMatch "krepe((choko)(kream))" => "(choko)(kream)"
//

let firstMatch s =
    ""          //   TO BE IMPLEMENTED
  

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 18: firstMatch"

    test (lazy (firstMatch ""   )) "" NoException
    test (lazy (firstMatch "()" )) "" NoException
    test (lazy (firstMatch "phrase (comment)" )) "comment" NoException
    test (lazy (firstMatch "phrase (comment) Furthermore (details)" )) "comment" NoException
    test (lazy (firstMatch "krepe((choko)(kream))" )) "(choko)(kream)" NoException
                
    printfn ""
    0 // return an integer exit code
    

