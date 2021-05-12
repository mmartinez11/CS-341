module utils
// Exceptions defined here.
open System
type  NoException = | NoException // a hack to type check the test function

let test (expr : Lazy<'a>) expectedResult (expectException:'b) =
    // A function for writing test cases.
    // expr is the expression that you want to test.
    // If there is no exception, this function compares the value of
    // evaluating expr with expected_result; otherwise it checks if
    // the type of exception thrown is the same type of expectException, and expectResult is ignored.
    // You should put NoException for expectException if you don't expect one.
    
    // You can twist this function for testing purpose.
    
    // expr should be lazy (...) for catching exceptions
    let res =
        try
            Some(expr.Force())
        with
            | ex -> 
                if (expectException.GetType() = typeof<NoException>) then printfn "Expecting value, but caught exception with error message: %s" ex.Message 
                else if (expectException.GetType() = ex.GetType()) then printfn "Result is correct! Caught expected exception with error message: %s" ex.Message
                else printfn "Caught unexpected exception with error message: %s" ex.Message
                None
    match res with
    | None -> ()
    | Some _res ->
        if _res = expectedResult then
            Console.WriteLine("Result is correct!")
        else
            Console.WriteLine("Result is wrong!   expected value: " + expectedResult.ToString() + ", your code produced: " + _res.ToString())