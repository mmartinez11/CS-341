// The main file for Project 1, contains the code to be executed
// You can modify the contents when testing, the autograder may use a different main to test your class

#include <iostream>
#include <algorithm>
#include <string>
#include "characterParser.h"
#include "charIterator.h"
#include "acronymIterator.h"

// Do not modify main at all
int main()
{
    std::string s;
    // reads one line at a time until no input is provided (pressing enter on an empty line, or EOF if input is piped in)
    while (std::getline(std::cin, s) && (s.length() > 0))
    {
        // Create a character parser object from one line of input
        characterParser myParser(s);

        // Echo the input, check that printAllCharacters still outputs every character
        std::cout << "Input is : ";
        myParser.printAllCharacters();

        // Using std::find_if to check basic iterator behavior
        auto a = std::find_if(myParser.begin(), myParser.end(), [](char c) {return c == 'A'; });
        if (a != myParser.end())
        {
            std::cout << "One of the words begins with an a or A";
        }
        else
        {
            std::cout << "None of the words begin with an a or A";
        }
        std::cout << std::endl;

        // Using std::count_if to check that iterator_traits are defined correctly (example employing using keyword provided)
        auto c = std::count_if(myParser.begin(),
            myParser.end(),
            [](char c) { return (c == 'A') || (c == 'E') || (c == 'I') || (c == 'O') || (c == 'U'); }
        );
        std::cout << "There are " << c << " vowels in the acronym" << std::endl;

        // Use the new acronymIterator to output the acronym
        std::cout << "Input as Acronym : ";
        for (char c : myParser)
        {
            std::cout << c;
        }
        std::cout << std::endl;
        std::cout << std::endl;
    }
    return 0;
}