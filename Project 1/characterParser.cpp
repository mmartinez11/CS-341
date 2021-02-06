//
// Project 1
// CS 341 Spring 2021
// << Your Name Here >>
//
// The source file implementing the characterParser class, a collection of characters
// You are to implement the acronymIterator, then change this class to use
//  acronymIterator as the default iterator for the class

#include "characterParser.h"
#include "charIterator.h"
#include "acronymIterator.h"

// Default constructor
//
// Constructs an empty string
characterParser::characterParser()
    : array(nullptr), length(0)
{    }

// Parametrized constructor
//
//  Builds a characterParser deep copied from a char *
characterParser::characterParser(char* str)
{
    int len = std::strlen(str);
    array = new char[len + 1];
    std::strncpy(array, str, len);
    // If on windows:     strncpy_s(array, len + 1, str, len);
    array[len] = '\0';
    length = len;
}

// Parametrized constructor
//
//  Builds a characterParser deep copied from a std::string
characterParser::characterParser(std::string str)
{
    int len = str.length();
    array = new char[len + 1];
    std::strncpy(array, str.c_str(), len);
    // If on windows:    strncpy_s(array, len + 1, str.c_str(), len);
    array[len] = '\0';
    length = len;
}

// begin()
//
//  Returns an charIterator pointing to the first element of the string.
characterParser::charIterator characterParser::begin()
{
    return charIterator(array);
}

// end()
//
//  Returns an charIterator pointing "after" the last element of the string.
characterParser::charIterator characterParser::end()
{
    return charIterator(array + length);
}

// printAllCharacters
//
// Prints every character in the characterParser
// Requires modification after the default iterator has been changed
void characterParser::printAllCharacters()
{
    for (char c : *this)
    {
        std::cout << c;
    }
    std::cout << std::endl;
}


