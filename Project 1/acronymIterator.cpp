//
// Project 1
// CS 341 Spring 2021
// <<Manuel M Martinez>>
//
// Populate this file with the function definitions for the acronymIterator class
#include <ctype.h>
#include "acronymIterator.h"

//When (.begin) is called it will return the first valid char 
characterParser::acronymIterator::acronymIterator(char* arr)
{
    curr = arr;

    //Makes sure that the array is not out of bounds
    int x = (int)*curr;

    //While loop will look for the first valid char in the string
    while(x != 0){

        if(x < 65 || x > 122){
            ++curr;
        }
        else if(x > 90 && x < 97){
            ++curr;
        }
        else{
            break;
        }
        x = (int)*curr;
    }
}

//When iterator is dereferenced it returns an upper case char
char& characterParser::acronymIterator::operator*()
{
    *curr = toupper(*curr);
    return *curr;
}

characterParser::acronymIterator& characterParser::acronymIterator::operator++()
{
    //Check that the value is not out of bounds
    int x = (int)*curr;
    int y = -99;

    while(x != 0)
    {   //Check for special characters
        if(*curr == ' ' || *curr == '(' || *curr == '"'){

            ++curr;
            y = (int)*curr;
            
            //check if the following charecter is valid
            if(*curr != ' ' && *curr != '(' && *curr != '"'){

                if((y > 64 && y < 91) || (y > 96 && y < 123))
                {
                    --curr;
                    break;
                }
            }
            --curr;
        }
        ++curr;
        //Check value is not out of bounds
        x = (int)*curr;
        if(x == 0)
        {
            --curr;
            break;
        }
    }

    //Return valid value
    ++curr;
    return *this;
}

bool characterParser::acronymIterator::operator!=(const characterParser::acronymIterator& other)
{
    return curr != other.curr;
}

bool characterParser::acronymIterator::operator==(const characterParser::acronymIterator& other)
{
    return curr == other.curr;
}
