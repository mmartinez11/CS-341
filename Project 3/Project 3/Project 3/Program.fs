module Project03

open FSharp.Data

//************PROVIDED CODE IN THIS SECTION SHOULD REQUIRE NO CHANGES, THOUGH ALLOWED********************
type Article(a,b,c,d,e,f,g,h,i,j,k,l,m) =
    member this.news_id = a
    member this.url = b
    member this.publisher = c
    member this.publish_date = d
    member this.author = e
    member this.title = f
    member this.image = g
    member this.body_text = h
    member this.news_guard_score = i
    member this.mbfc_level = j
    member this.political_bias = k
    member this.country = l
    member this.reliablity = m

//
// doubleOrNothing
//
// Given a string containing a double numeric value
// or being an empty string
// returns the double equivalent, with the empty string
// treated as the value 0.0
//
let doubleOrNothing s = 
    match s with
    | "" -> 0.0
    | x -> double x

//
// stringToInteger
//
// Given a string containing an integer value
// or being an empty string
// returns the integer equivalent, with the empty string
// treated as the value 0
//
let stringToInteger s = 
    match s with
    | "" -> 0
    | x -> int x

//
// charListToString
//
// Given a list of characters, return a string 
// containing those characters in order
//
let charListToString L =
    let sb = System.Text.StringBuilder()
    L |> List.iter (fun c -> ignore (sb.Append (c:char)))
    sb.ToString()

//
// stringToCharList
//
// Given a string, return a list of characters 
// containing the characters of the string in order
//
let stringToCharList s =
    Seq.toList s

// Functions to help print items in the correct format

//
// printAllItemsInList
//
// Given a list of strings, print out those strings without quotes
//
let rec printAllItemsInList L =
    List.iter (printfn "%s") L

//Added By Myself
let rec printAllItemsInListC L =
    List.iter (printfn "%c") L

//Added By Myself
let rec recCountVals twoData =
    match twoData with
    | [] -> 0
    | head::rest -> 1 + recCountVals rest 

 //Added By Myself
let getNum twoRows num = 

        let x = (num |> float)
        let y = (twoRows |> float)

        let z = x / y
        ((z * 100.0) |> int)

//Added By Myself
let getNumTwo twoRows num = 

        let x = (num |> float)
        let y = (twoRows |> float)

        let z = (x / y) * 100.0
        z


//
// printStringsAndIntegers
//
// Given a list of pairs between strings and ints,
// print out those strings and integers in a nice format
//
let rec printStringsAndIntegers L =
    List.iter (fun (s,i) -> printfn "%s: %d" s i) L

//
// printNamesAndFloats
//
// Given a list of pairs between strings and floats,
// print out those strings and floats in a nice format
//
let rec printNamesAndFloats L =
    List.iter (fun (s,f) -> printfn "%s: %.3f" s f) L

//
// printNamesAndPercentages
//
// Given a list of pairs between strings and floats,
// print out those strings and floats with a percent sign
//
let rec printNamesAndPercentages L =
    List.iter (fun (s,f) -> printfn "%s: %.3f %%" s f) L

//
// printStars
//
// Given an int n, prints out n stars on the same line.
//
let rec printStars n =
    match n with
    | 0 -> ()
    | 1 -> printf "*"
    | _ -> printf "*"
           printStars (n-1)



//***************************YOUR CODE SHOULD BEGIN HERE******************************
// Implement functions for 10 questions 


// 1. Given a news id, write a function to return
//    its corresponding news title.
//DONE
let rec getTitle index allData =
    
    match allData with
    | [] -> "No ID Found"//Replace with Exception
    | (head:Article)::rest when head.news_id <> index -> getTitle index rest
    | (head:Article)::_ -> head.title


// 2. Given a news id, write a function to return 
//    the length (number of words) of its corresponding news body text.
//    Words are separated by space or line separator "\n".
let wordCount index allData =

        let rec getCount bound =
            
            match bound with
            | [] -> 1
            | head::rest when head = ' ' && rest.Head <> ' ' && rest.Head <> '\n' -> 1 + getCount rest
            | head::rest when head = '\n' && rest.Head <> ' ' && rest.Head <> '\n'-> 1 + getCount rest
            | head::rest -> 0 + getCount rest

        let rec getCharList vindex aData =

            match aData with
            | [] -> "No ID Found"//Replace with Exception
            | (head:Article)::rest when head.news_id = vindex -> head.body_text
            | (head:Article)::rest -> getCharList vindex rest

        let sList = getCharList index allData

        let cList = stringToCharList sList
        
        getCount cList


// 3. Given a news id , write a function to return
//    its corresponding publish month as a string.
//    For example, return “January” for 2020-01-21, return “June” for 2020-06-23.
let getMonthName index allData =

    let rec findMonth bound =
        
        match bound with
        | head::rest when head = '1' && rest.Head = '0' -> "October"
        | head::rest when head = '1' && rest.Head = '1' -> "November"
        | head::rest when head = '1' && rest.Head = '2' -> "December"
        | head::_ when head = '1' -> "January"
        | head::_ when head = '2' -> "February"
        | head::_ when head = '3' -> "March"
        | head::_ when head = '4' -> "April"
        | head::_ when head = '5' -> "May"
        | head::_ when head = '6' -> "June"
        | head::_ when head = '7' -> "July"
        | head::_ when head = '8' -> "August"
        | head::_ when head = '9' -> "September"
        |_ -> "Error"


    let rec findDate vindex aData =

        match aData with
        | [] -> "No ID Found" //Replace with Exception
        | (head:Article)::rest when head.news_id = vindex -> head.publish_date
        | (head:Article)::rest -> findDate vindex rest

    let sDate = findDate index allData
    let cDate = stringToCharList sDate

    findMonth cDate


// 4. Write a function to return a list of unique news publishers.
//    Each publisher is represented by its original name in the string format.
//    The order of the publishers in the output list is the same as the order in the CSV data.
let publishers allData =

    let (x:Article) = List.head allData
    let holder = x.publisher::[]

    let rec count L item =
        match L with
        | [] -> 0
        | head::rest when head <= item && head >= item -> 1 + count rest item
        | head::rest -> 0 + count rest item

    let rec findList aData holderList =
    
        match aData with 
        | [] -> holderList
        | (head:Article)::rest -> let cMany = count holderList head.publisher
                                  let q = head.publisher::[]
                                  if cMany = 0 
                                  then findList rest (holderList@q)
                                  else findList rest holderList
   
    findList allData holder


// 5. Write a function to return a list of unique countries.
//    Each country is represented by its original name in the string format.
//    The order of the countriesin the output list is the same as the order in the CSV data.
let countries allData =

    let (x:Article) = List.head allData
    let holder = x.country::[]

    let rec count L item =
        match L with
        | [] -> 0
        | head::rest when head <= item && head >= item -> 1 + count rest item
        | head::rest -> 0 + count rest item

    let rec findList aData holderList =
    
        match aData with 
        | [] -> holderList
        | (head:Article)::rest -> let cMany = count holderList head.country
                                  let q = head.country::[]
                                  if cMany = 0 
                                  then findList rest (holderList@q)
                                  else findList rest holderList
   
    findList allData holder



// 6. Write a function to return the average news_guard_score among all news articles.
let avgNewsguardscoreForArticles allData =

    let rec sum holder =
        match holder with
        | []    -> 0.0
        | (e:Article)::rest -> (e.news_guard_score |> float) + sum rest

    let rec length holder2 =
        match holder2 with
        | []    -> 0
        | e::rest -> 1 + length rest
    
    let rec average L =
        let sumT = sum L
        let lenghtT = length L
    
        sumT / (lenghtT |> float)
    
    average allData




// 7. Write a function to return a list containing the amount of news for each month,
//    from January to December. Each month and its corresponding news amount is represented by a tuple.
//    You need to print this information as a histogramin the console.
//    The histogram can be represented by stars (*).
//    Each star (*) should represents 1% of overall amount of data.
//    More instructions to print the histogram can be found in the project description.
let numberOfArticlesEachMonth allData = 

    let rec count L item =
      
        let getVal cL =
            match cL with
            | [] -> -99
            | head::rest when rest.Head <> '/' -> let s = charListToString (head::rest.Head::[])
                                                  let v = stringToInteger s
                                                  v
            | head::_ -> let s = charListToString (head::[])
                         let v = stringToInteger s
                         v

        let (x:Article) = List.head L
        let cList = stringToCharList x.publish_date
        let vall = getVal cList

        match L with
        | [] -> 0
        | head::rest when rest = [] && vall = item -> 1
        | head::rest when rest = [] && vall <> item -> 0
        | head::rest when vall = item -> 1 + count rest item
        | head::rest -> 0 + count rest item

    let c = 2
    let h = [("January", count allData 1)]

    let rec findPArt aList percentL counter =

        match counter with
        | 2 -> let holder = percentL@[("February", count allData counter)]
               findPArt aList holder (counter+1)
        | 3 -> let holder = percentL@[("March", count allData counter)]
               findPArt aList holder (counter+1)
        | 4 -> let holder = percentL@[("April", count allData counter)]
               findPArt aList holder (counter+1)
        | 5 -> let holder = percentL@[("May", count allData counter)]
               findPArt aList holder (counter+1)
        | 6 -> let holder = percentL@[("June", count allData counter)]
               findPArt aList holder (counter+1)
        | 7 -> let holder = percentL@[("July", count allData counter)]
               findPArt aList holder (counter+1)
        | 8 -> let holder = percentL@[("August", count allData counter)]
               findPArt aList holder (counter+1)
        | 9 -> let holder = percentL@[("September", count allData counter)]
               findPArt aList holder (counter+1)
        | 10 -> let holder = percentL@[("October", count allData counter)]
                findPArt aList holder (counter+1)
        | 11 -> let holder = percentL@[("November", count allData counter)]
                findPArt aList holder (counter+1)
        | 12 -> let holder = percentL@[("December", count allData counter)]
                findPArt aList holder (counter+1)
        | _ -> percentL

    findPArt allData h c
    

// 8. Write a function to return a list of unique publishers
//    and the percentage of news which are marked as reliable (1) published by each publisher.
//    Each publisher and its reliable news percentage are represented by a tuple, e.g., (“CNN”, 65.233).
//    The order of the tuples are the same as the order of publishers in the CSV data.
let reliableArticlePercentEachPublisher allData pList nRows =

    let rec count L item =
        match L with
        | [] -> 0
        | (head:Article)::rest when head.publisher = item -> 1 + count rest item
        | head::rest -> 0 + count rest item

    let rec countRate L2 item2 =
        match L2 with
        | [] -> 0
        | (head:Article)::rest when head.publisher = item2 && head.reliablity = 1 -> 1 + countRate rest item2
        | head::rest -> 0 + countRate rest item2
    
    let f = List.head pList
    let e = List.tail pList

    let c = count allData f
    let n = countRate allData f

    let k = getNumTwo c n
    let firstVal = [(f, k)]

    let rec makeListP prest holderList = 
        
        match prest with
        | [] -> holderList
        | head::rest -> let cu = count allData head
                        let nn = countRate allData head
                        let kk = getNumTwo cu nn
                        let rVal = holderList@[(head,kk)]
                        makeListP rest rVal

    makeListP e firstVal
    //[("publisher", 0.0)]




// 9. Write a function to return a list of unique counties and their average news_guard_score.
//    The output is a list of tuples, e.g., [(“USA”, 92.5), (“Russia”, 35.222)].
//    The order of the tuples are the same as the order of countries in the CSV data.
let avgNewsguardscoreEachCountry allData =

    let rec count L item =
        match L with
        | [] -> 0.0
        | (head:Article)::rest when head.country = item -> 1.0 + count rest item
        | head::rest -> 0.0 + count rest item

    let rec countRate L2 item2 =
        match L2 with
        | [] -> 0.0
        | (head:Article)::rest when head.country = item2 -> head.news_guard_score + countRate rest item2
        | head::rest -> 0.0 + countRate rest item2

    let pList = countries allData
    let o = (count allData pList.Head) * 100.0

    let f = ((countRate allData pList.Head) / o) * 100.0

    let firstVal = [(pList.Head, f)]

    let rec makeListP prest holderList = 
    
        match prest with
        | [] -> holderList
        | head::rest -> let cu = (count allData head) * 100.0
                        let nn = ((countRate allData head) / cu) * 100.0
                        let rVal = holderList@[(head,nn)]
                        makeListP rest rVal

    makeListP pList.Tail firstVal



// 10. The political_bias column has multiple values, write a function to categorize them and 
//     return a list of tuples with each category and its average news_guard_score.
//     The order of the tuples are the same as the order of political_bias in the CSV data.
//     Similar to Question 7, you need to print the output as a histogram. You can reuse the code from Question 7.
let avgNewsguardscoreEachBias allData =
    [("bias", 0.0)]



//
// buildHistogram
// Takes a list of (string,int) pairs
// prints out string nicely spaced
// followed by a number of stars
// spacing to line up the format of the output and display as a graph
//
// You will want to modify this function to produce the correct output
//
let rec buildHistogram L nRows =

    match L with
    | [] -> ()
    | (category,number)::tl -> printf " %15s : " category
                               let numStars = getNum nRows number
                               printStars numStars
                               printf "%d" number
                               printfn ""
                               buildHistogram tl nRows

//
// buildHistogram
// Takes a list of (string,float) pairs
// prints out string nicely spaced
// followed by a number of stars
// spacing to line up the format of the output and display as a graph
//
// You will want to modify this function to produce the correct output
//
let rec buildHistogramFloat L =
    match L with
    | [] -> ()
    | (category,number)::tl -> printf " %15s : " category
                               let numStars = (int number) // or some function of number
                               printStars numStars
                               printf "%.3f" number
                               printfn ""
                               buildHistogramFloat tl


//***********************************APPLICATION START****************************************
  // This is where your application begins, you can change any of the code below this point as well as above
  // Application begins by requesting name of the file
  // see notes on piazza for HW3 about putting the data file in the correct location
  // then requests the task to perform
  // The following match has each task twice, once in the specific task case and once
  // in the run all tasks case
  // Make sure any changes you make are reflected in both cases.

[<EntryPoint>]
let main argv =
    // input file name, to read the data
    printf "Enter name of the csv file containing employee data: "

    // Read the name of the file from standard input
    let filename = System.Console.ReadLine()

    // Use a built-in library to process the CsvFile into a collection of fields
    let contents = CsvFile.Load(filename)

    // List comprehension magic to build a list of Article objects
    // See definition of Article class at the top (type Article)
    let data = [for x in contents.Rows
                 do
                    Article(stringToInteger (x.GetColumn 0),
                            x.GetColumn 1,
                            x.GetColumn 2,
                            x.GetColumn 3,
                            x.GetColumn 4,
                            x.GetColumn 5,
                            x.GetColumn 6,
                            x.GetColumn 7,
                            doubleOrNothing (x.GetColumn 8),
                            x.GetColumn 9,
                            x.GetColumn 10,
                            x.GetColumn 11,
                            stringToInteger (x.GetColumn 12))]

    // Debug information, to get you started and check that the data was loaded correctly
    // Comment out these two lines when submitting the project
    printfn "This is the data you have loaded."
    List.iter (fun (x:Article) -> printfn "%A" x.title) data
    
    printf "Which task to perform (0 for all): "
    let taskNumber = stringToInteger (System.Console.ReadLine())

    printfn ""

    match taskNumber with
    | 1 ->  //1. print title
            printf "Enter id of article: "
            let id = stringToInteger (System.Console.ReadLine())

            printfn ""
            let title = getTitle id data
            printfn "1. Title: %s" title
    | 2 ->  //2. word count
            printf "Enter id of article: "
            let id = stringToInteger (System.Console.ReadLine())

            printfn ""
            let word_count = wordCount id data
            printfn "2. Number of Words in The Article: %d" word_count
    | 3 ->  // 3. printmonth
            printf "Enter id of article: "
            let id = stringToInteger (System.Console.ReadLine())

            printfn ""
            let actualmonth = getMonthName id data
            printfn "3. Month of Chosen Article: %s" actualmonth
    | 4 ->  // 4. unique publishers
            let publisherNames = publishers data
            printfn "4. Unique Publishers: " 
            printAllItemsInList publisherNames
    | 5 ->  // 5. unique countries
            let countryNames = countries data
            printfn "5. Unique Countries: " 
            printAllItemsInList countryNames
    | 6 ->  // 6. average news guard score for all the articles
            let overallguard = avgNewsguardscoreForArticles data
            printfn "6. Average News Guard Score for All Articles: %.3f" overallguard
    | 7 ->  // 7. number of articles for each month
            let nArticles = numberOfArticlesEachMonth data
            let numRows = recCountVals data
            printfn "7. Number of Articles for Each Month:" 
            buildHistogram nArticles numRows
    | 8 ->  // 8. percentage of articles that are reliable for each publisher
            let publisherList = publishers data
            let numberRows = recCountVals data
            let reliablepct = reliableArticlePercentEachPublisher data publisherList numberRows
            printfn "8. Percentage of Articles That Are Reliable for Each Publisher: " 
            printNamesAndPercentages reliablepct
    | 9 ->  // 9. for each country, print the average news guard score
            let countryNames = countries data
            let averageguard = avgNewsguardscoreEachCountry data
            printfn "9. Average News Guard Score for Each Country: " 
            printNamesAndFloats averageguard

    | 10 -> // 10. categorize articles by political bias, then get the average news guard score for each category
            let bias = avgNewsguardscoreEachBias data
            printfn "10. The Average News Guard Score for Each Political Bias Category: " 
            buildHistogramFloat bias

    | 0 | _ ->  // ALL
                printf "Enter id of article: "
                let id = stringToInteger (System.Console.ReadLine())

                 //1. print title
                printfn ""
                let title = getTitle id data
                printfn "1. Title: %s" title

                //2. word count
                printfn ""
                let word_count = wordCount id data
                printfn "2. Number of Words in The Article: %d" word_count

                // 3. printmonth
                printfn ""
                let actualmonth = getMonthName id data
                printfn "3. Month of Chosen Article: %s" actualmonth

                // 4. unique publishers
                printfn ""
                let publisherNames = publishers data
                printfn "4. Unique Publishers: " 
                printAllItemsInList publisherNames

                // 5. unique countries
                printfn ""
                let countryNames = countries data
                printfn "5. Unique Countries: " 
                printAllItemsInList countryNames

                // 6. average news guard score for all the articles
                printfn ""
                let overallguard = avgNewsguardscoreForArticles data
                printfn "6. Average News Guard Score for All Articles: %.3f" overallguard

                // 7. number of articles for each month
                printfn ""
                let nArticles = numberOfArticlesEachMonth data
                let numRows = recCountVals data
                printfn "7. Number of Articles for Each Month:" 
                buildHistogram nArticles numRows

                // 8. percentage of articles that are reliable for each publisher
                printfn ""
                let publisherList = publishers data
                let numberRows = recCountVals data
                let reliablepct = reliableArticlePercentEachPublisher data publisherList numberRows
                printfn "8. Percentage of Articles That Are Reliable for Each Publisher: " 
                printNamesAndPercentages reliablepct 

                // 9. for each country, print the average news guard score
                printfn ""
                let averageguard = avgNewsguardscoreEachCountry data
                printfn "9. Average News Guard Score for Each Country: " 
                printNamesAndFloats averageguard

                // 10. categorize articles by political bias, then get the average news guard score for each category
                printfn ""
                let bias = avgNewsguardscoreEachBias data
                printfn "10. The Average News Guard Score for Each Political Bias Category: " 
                buildHistogramFloat bias

    0
