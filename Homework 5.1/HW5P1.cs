using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class HW5P1
    {
        static void F1()
        {
            Console.WriteLine("The user selected function 1.");
        }

        static void F2()
        {
            Console.WriteLine("The function selected was function 2.");
        }

        static void F3(int i)
        {
            Console.WriteLine(String.Format("The user's input was {0}", i));
        }

        static void F4()
        {
            Console.WriteLine(4);
        }

        static void F5()
        {
            Console.WriteLine(11 / 2);
        }

        static void F6()
        {
            Console.Write("This is function {0}\n", 6);
        }

        static void F7()
        {
            Console.WriteLine("The user chose function 7.");
        }

        static void F8()
        {
            Console.WriteLine("The user's selection was function 8.");
        }

        static void F9()
        {
            Console.WriteLine("Number 9");
        }

        static void F10()
        {
            Console.WriteLine("Last function");
        }


        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            int input = Int32.Parse(stringInput);

            while (input != 0)
            {
                // Use a switch case to call the function the user chose
                // If it was none of the options, output "Invalid choice"

                switch(input)
                {
                    case 1:
                        F1();
                        break;
                    case 2:
                        F2();
                        break;
                    case 3:
                        F3(input);
                        break;
                    case 4:
                        F4();
                        break;
                    case 5:
                        F5();
                        break;
                    case 6:
                        F6();
                        break;
                    case 7:
                        F7();
                        break;
                    case 8:
                        F8();
                        break;
                    case 9:
                        F9();
                        break;
                    case 10:
                        F10();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }


                stringInput = Console.ReadLine();
                input = Int32.Parse(stringInput);
            }
        }
    }
}
