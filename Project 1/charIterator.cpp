// This file contains the implementation of the charIterator class
// This is a forward input/output iterator
// Use this as a reference when building your acronymIterator
// Do not modify this file

#include "charIterator.h"

characterParser::charIterator::charIterator(char* arr)
{
    curr = arr;
}

char& characterParser::charIterator::operator*()
{
    return *curr;
}

characterParser::charIterator& characterParser::charIterator::operator++()
{
    ++curr;
    return *this;
}

bool characterParser::charIterator::operator!=(const characterParser::charIterator& other)
{
    return curr != other.curr;
}

bool characterParser::charIterator::operator==(const characterParser::charIterator& other)
{
    return curr == other.curr;
}

