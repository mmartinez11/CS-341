module Project02_20

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
// RegEx s pattern
// Return whether the string s matches the string pattern.
// The rules for a pattern are provided in the document.
//
// Examples:
//          RegEx ""       ""     => true
//          RegEx "a"      "a"    => true
//          RegEx "abc"    "aBc"  => false
//          RegEx "abc"    "abcd" => false
//          RegEx "B"      "Bo+"  => false
//          RegEx "Bo"     "Bo+"  => true
//          RegEx "Boooooz" "Bo+o+z"  => true
//          RegEx "Bo"     "Bo+o" => false
//          RegEx "Bot"    "Bo+t" => true
//          RegEx "Boz"    "B?z"  => true
//

let rec RegEx s pattern =
    true         // To be implemented


//[<EntryPoint>]
let main argv =
    printfn "Testing Exercise 20: RegEx"

    test (lazy (RegEx ""       ""))        true  NoException
    test (lazy (RegEx "a"      "a"))       true  NoException
    test (lazy (RegEx "abc"    "aBc"))     false NoException
    test (lazy (RegEx "abc"    "abcd"))    false NoException
    test (lazy (RegEx "B"      "Bo+"))     false NoException
    test (lazy (RegEx "Bo"     "Bo+"))     true  NoException
    test (lazy (RegEx "Boooooz" "Bo+o+z")) true  NoException
    test (lazy (RegEx "Bo"     "Bo+o"))    false NoException
    test (lazy (RegEx "Bot"    "Bo+t"))    true  NoException
    test (lazy (RegEx "Boz"    "B?z" ))    true  NoException
                
    printfn ""
    0 // return an integer exit code
    

