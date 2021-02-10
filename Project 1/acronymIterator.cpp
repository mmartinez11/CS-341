//
// Project 1
// CS 341 Spring 2021
// <<Manuel M Martinez>>
//
// Populate this file with the function definitions for the acronymIterator class
#include <ctype.h>
#include "acronymIterator.h"

characterParser::acronymIterator::acronymIterator(char* arr)
{
    curr = arr;

    int x = (int)*curr;

    while(x != 0)
    {
        if(x < 65 || x > 122)
        {
            ++curr;
        }
        else if(x > 90 && x < 97)
        {
            ++curr;
        }
        else
        {
            break;
        }

        x = (int)*curr;
    }

}

char& characterParser::acronymIterator::operator*()
{
    *curr = toupper(*curr);
    return *curr;
}

characterParser::acronymIterator& characterParser::acronymIterator::operator++()
{
    int x = (int)*curr;
    int y = -99;

    while(x != 0)
    {   
        if(*curr == ' ' || *curr == '(' || *curr == ')' || *curr == '"')
        {
            ++curr;
            y = (int)*curr;
            
            if(*curr != ' ' && *curr != '(' && *curr != ')' && *curr != '"')
            {
                if((y > 64 && y < 91) || (y > 96 && y < 123))
                {
                    --curr;
                    break;
                }
            }

            --curr;
        }

        ++curr;
        x = (int)*curr;
        if(x == 0)
        {
            --curr;
            break;
        }
    }

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
