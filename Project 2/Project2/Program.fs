module main

open System
//open Project02  // uncomment to use functions in the _ALL file in this file

[<EntryPoint>]
let main argv =
    printfn "Uncomment the lines in Program.fs as you want to test your functions"
    // uncomment a line if you're ready to test the function in that file
    // comment out a line if you don't want to execute it
    ignore (Project02_01.main [])//Full +5
    ignore (Project02_02.main [])//Full +5
    ignore (Project02_03.main [])//Full +5
    ignore (Project02_04.main [])//Full +5
    ignore (Project02_05.main [])//Full +5
    ignore (Project02_06.main [])//Full +5
    ignore (Project02_07.main [])//Illegal -5
    ignore (Project02_08.main [])//Full +5
    ignore (Project02_09.main [])//Full +5
    ignore (Project02_10.main [])//Full +5
    ignore (Project02_11.main [])//Late +2.5
    ignore (Project02_12.main [])//Late +2.5
    ignore (Project02_13.main [])//Full +5
    ignore (Project02_14.main [])//Broken -5
    ignore (Project02_15.main [])//Full +5
    ignore (Project02_16.main [])//Full +5
    //ignore (Project02_17.main [])
    //ignore (Project02_18.main [])
    //ignore (Project02_19.main [])
    //ignore (Project02_20.main [])
    0 // return an integer exit code
