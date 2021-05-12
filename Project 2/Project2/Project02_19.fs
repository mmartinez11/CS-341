module Project02_19

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

open utils
//
// allMatches s
// returns the content in the first pair of matching parentheses
//
// Examples:
// 	   allMatches ""   => []
//     allMatches "()" => [""]
//     allMatches "phrase (comment)" => ["comment"]
//     allMatches "phrase (comment) Furthermore (details)" => ["comment";"details"]
//     allMatches "krepe((choko(kream)))"=> 
//         ["(choko(kream))"; "choko(kream)"; "kream"]
//     allMatches "krepe((choko()(kream)))"=> 
//         ["(choko()(kream))"; "choko()(kream)"; ""; "kream"]


let allMatches s = 
    []          //   TO BE IMPLEMENTED

//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 19: allMatches"

    test (lazy (allMatches ""   )) [] NoException
    test (lazy (allMatches "()" )) [""] NoException
    test (lazy (allMatches "phrase (comment)" )) ["comment"] NoException
    test (lazy (allMatches "phrase (comment) Furthermore (details)" )) ["comment";"details"] NoException
    test (lazy (allMatches "krepe((choko(kream)))" )) ["(choko(kream))"; "choko(kream)"; "kream"] NoException
    test (lazy (allMatches "krepe((choko()(kream)))" )) ["(choko()(kream))"; "choko()(kream)"; ""; "kream"] NoException
                
    printfn ""
    0 // return an integer exit code
    

