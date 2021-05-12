﻿#light

module hw03

//
// length:
//
// Computes the length of a list.
// Example: length [15;8;25;17;12] => 5
//
let rec length L =
    match L with
    | []    -> 0
    | e::rest -> 1 + length rest

//
// sum
//
// Computes the sum of the values in a list of integers.
// Example: sum [15;8;25;17;12] => 77
//
let rec sum L =
  match L with
  | []    -> 0
  | e::rest -> e + sum rest

//
// average
//
// Computes the floating point average of the values in a list of integers.
// You will need to convert ints to floats before dividing the sum by length to find the average.
// Example: average [15;8;25;17;12] => 15.4
//
let rec average L =
    let sumT = sum L
    let lenghtT = length L

    (sumT |> float) / (lenghtT |> float)



       // Replace with your implementation of average
       // Note that doubles and ints are not compatible types, 
       // but you can use (double) value to construct a double value from an int


[<EntryPoint>]
let main argv =
    printf "filename> "
    let filename   = System.Console.ReadLine()
    let data_array = System.IO.File.ReadAllLines(filename)
    let data_list  = Array.toList data_array
    //
    // convert strings to integers:
    //
    let values = List.map (fun s -> int s) data_list
    printfn "%A" values
    //
    let len = length values
    printfn "%A" len
    //
    let total = sum values
    printfn "%A" total
    //
    let avg = average values
    printfn "%A" avg
    //
    0
