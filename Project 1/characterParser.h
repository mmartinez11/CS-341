//
// Project 1
// CS 341 Spring 2021
// << Your Name Here >>
//
// The header file for the characterParser class, a collection of characters
// This class comes with an iterator provided, charIterator
// You are to implement the acronymIterator, then change this class to use
//  acronymIterator as the default iterator for the class

#pragma once

#include <iostream>
#include <string>
#include <cstring>
#include <cstdio>
#include <algorithm>

class characterParser
{
private:
    char* array;
    int length;

public:
    // Default constructor
    //
    // Constructs an empty string
    characterParser();

    // Parametrized constructor
    //
    //  Builds a characterParser deep copied from a char *
    characterParser(char* str);

    // Parametrized constructor
    //
    //  Builds a characterParser deep copied from a std::string
    characterParser(std::string str);

    // This iterator has been provided for you
    // and iterates over every character in the container
    class charIterator;

    class acronymIterator;


    // begin()
    //
    //  Returns an charIterator pointing to the first element of the string.
    charIterator begin();

    // end()
    //
    //  Returns an charIterator pointing "after" the last element of the string.
    charIterator end();

    // printAllCharacters()
    //
    //  Sends all the characters in the CharacterParser container to standard input in order
    //  Adds a new line at the end of the output
    void printAllCharacters();

};