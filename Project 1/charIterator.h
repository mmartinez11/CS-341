// This file contains the definitions for the charIterator provided as the default iterator for characterParser
// Use this as a reference when building your acronymIterator
// Do not modify this file

#pragma once
#include <iterator>
#include "characterParser.h"

class characterParser::charIterator
{
public:
    using iterator_category = std::forward_iterator_tag;
    using value_type = char;
    using difference_type = std::ptrdiff_t;
    using pointer = char*;
    using reference = char&;

private:
    char* curr;

public:
    charIterator(char* arr);

    char& operator*();

    charIterator& operator++();

    bool operator!=(const charIterator& other);

    bool operator==(const charIterator& other);

};