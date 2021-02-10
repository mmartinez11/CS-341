//
// Project 1
// CS 341 Spring 2021
// <<Manuel M Martinez>>
//
//Populate this file with the functions definitions for the acronymIterator class

#pragma once
#include "characterParser.h"
#include <iterator>

class characterParser::acronymIterator
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
	
		acronymIterator(char* arr);

    	char& operator*();

    	acronymIterator& operator++();

    	bool operator!=(const acronymIterator& other);

    	bool operator==(const acronymIterator& other);


};


