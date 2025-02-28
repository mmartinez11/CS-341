﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class HW5P2
    {
        static Microsoft.FSharp.Collections.FSharpList<HW5P2Lib.HW5P2.Article> alldata;

                static void F1()
                {
                    Console.WriteLine("Enter id of article: ");

                    // Take the user's input, get an integer to pass to F# code
                    // Call the library function
                    // Output the result
                    

                    string stringInput = Console.ReadLine();
                    int input = Int32.Parse(stringInput);

                    var result = HW5P2Lib.HW5P2.getTitle(input, alldata);

                    Console.WriteLine(String.Format("1. Title: {0}", result));
                    return;
                }
        
                static void F2()
                {
                    Console.WriteLine("Enter id of article: ");
                    // Take the user's input, get an integer to pass to F# code
                    // Call the library function
                    // Output the result
                    //"2. Number of Words in The Article: {0}"
                    
                    string stringInput = Console.ReadLine();
                    int input = Int32.Parse(stringInput);

                    var result = HW5P2Lib.HW5P2.wordCount(input, alldata);

                    Console.WriteLine(String.Format("2. Number of Words in The Article: {0}", result));
                    
                }

                static void F3()
                {
                    Console.WriteLine("Enter id of article: ");
                    // Take the user's input, get an integer to pass to F# code
                    // Call the library function
                    // Output the result
                    // "3. Month of Chosen Article: {0}"


                    string stringInput = Console.ReadLine();
                    int input = Int32.Parse(stringInput);

                    var result = HW5P2Lib.HW5P2.getMonthName(input, alldata);


                    Console.WriteLine(String.Format("3. Month of Chosen Article: {0}", result));
                }

                static Microsoft.FSharp.Collections.FSharpList<string> F4()
                {
                    // Call the library function, and return result to be output in main
                    return HW5P2Lib.HW5P2.publishers(alldata);
                }

                static Microsoft.FSharp.Collections.FSharpList<string> F5()
                {
                    // Call the library function, and return result to be output in main
                    return HW5P2Lib.HW5P2.countries(alldata);
                }   

                static double F6()
                {
                    // Call the library function, and return result to be output in main
                    return HW5P2Lib.HW5P2.avgNewsguardscoreForArticles(alldata);
                }

                static Microsoft.FSharp.Collections.FSharpList<Tuple<string, int>> F7()
                {
                    // Call the library function, and return result to be output in main
                    return HW5P2Lib.HW5P2.numberOfArticlesEachMonth(alldata);
                }

                static Microsoft.FSharp.Collections.FSharpList<Tuple<string, double>> F8()
                {
                    // Call the library function, and return result to be output in main
                    return HW5P2Lib.HW5P2.reliableArticlePercentEachPublisher(alldata);
                }

                static void F9()
                {
                    // Call the library function to get the list of (string, double) for each country's average
                    Microsoft.FSharp.Collections.FSharpList<Tuple<string, double>> result = HW5P2Lib.HW5P2.averageguardscore(alldata);
                    Microsoft.FSharp.Collections.FSharpList<string> lines1 = HW5P2Lib.HW5P2.printNamesAndFloats(result);


                    Console.WriteLine("9. Average News Guard Score for Each Country: ");
                    // Call the library function transforming the list of pairs into a list of strings
                    // Output the list of strings, one per line
                    foreach (string line in lines1)
                        Console.Write(line);

                }

                static void F10()
                {
                    // Call the library function to get the List of (string, double) pairs
                    Microsoft.FSharp.Collections.FSharpList<Tuple<string, double>> result = HW5P2Lib.HW5P2.avgNewsguardscoreEachBias(alldata);

                    Console.WriteLine("10. The Average News Guard Score for Each Political Bias Category: ");
                    // Call the library function to construct the histogram
                    // output the string generated by the F# code

                    string output = HW5P2Lib.HW5P2.buildHistogramFloat(result, "");
                    Console.WriteLine(output);

                }
     

        static void Main(string[] args)
        {
            // read the csv file
            Console.WriteLine("Enter name of the csv file containing employee data: ");
            string filename = Console.ReadLine();
            alldata = HW5P2Lib.HW5P2.readfile(filename);

            Console.WriteLine("Which task to perform (0 for quit): ");
            string stringInput = Console.ReadLine();
            int input = Int32.Parse(stringInput);

            while (input != 0)
            {
                // Use a switch case to call the function the user chose
                // If it was none of the options, output "Invalid choice"
                                switch (input)
                                {
                                        case 1:
                                            F1();
                                            break;
                    
                                        case 2:
                                            F2();
                                            break;
                                        case 3:
                                            F3();
                                            break;
                                        case 4:
                                            Microsoft.FSharp.Collections.FSharpList<string> publisherNames = F4();
                                            Console.WriteLine("4. Unique Publishers: ");
                                            Console.WriteLine(String.Join("\n", publisherNames));
                                            break;
                                        case 5:
                                            Microsoft.FSharp.Collections.FSharpList<string> countryNames = F5();
                                            Console.WriteLine("5. Unique Countries: ");
                                            Console.WriteLine(String.Join("\n", countryNames));
                                            break;
                                        case 6: 
                                            double overallguard = F6();
                                            Console.WriteLine(String.Format("6. Average News Guard Score for All Articles: {0}", overallguard)); 
                                            break;
                                        case 7:
                                            Microsoft.FSharp.Collections.FSharpList<Tuple<string, int>> nArticles = F7();
                                            Console.WriteLine("7. Number of Articles for Each Month:");
                                            string output = HW5P2Lib.HW5P2.buildHistogram(nArticles, alldata.Length, "");
                                            Console.WriteLine(output);
                                            break;
                                        case 8:
                                            Microsoft.FSharp.Collections.FSharpList<Tuple<string, double>> reliablepct = F8();
                                            Console.WriteLine("8. Percentage of Articles That Are Reliable for Each Publisher: ");
                                            Microsoft.FSharp.Collections.FSharpList<string> lines1 = HW5P2Lib.HW5P2.printNamesAndPercentages(reliablepct);
                                            foreach (string line in lines1)
                                                Console.Write(line);
                                            break;
                                        case 9:
                                            F9(); // Implement the output entirely in function 9.  Refer to 8 for how to output a list of strings.
                                            break;
                                        case 10:
                                            F10(); // Implement the output entirely in function 10.  Refer to 7 for how to build a histogram.
                                            break;
                    
                                        default:
                                            Console.WriteLine("Invalid choice");
                                            break;
                                 }

                Console.WriteLine("\nWhich task to perform (0 for quit): ");
                stringInput = Console.ReadLine();
                input = Int32.Parse(stringInput);
            }
        }
    }
}