//
// Homework 1
// CS 341 Spring 2021
// << Manuel M Martinez >>
//
#include <fstream>
#include <iostream>
#include <string>

#include <algorithm>

using namespace std;

int main()
{
	string data;
	string fileName;
	 
	getline(cin,fileName);
	
	fileName.erase(fileName.begin(), find_if(fileName.begin(), fileName.end(), bind1st(not_equal_to<char>(), ' ')));
	fileName.erase(find_if(fileName.rbegin(), fileName.rend(), bind1st(not_equal_to<char>(), ' ')).base(), fileName.end());
	
	ifstream infile;
	infile.open(fileName);
	
	
	if(!infile.good()){
		
		cout << "|" << fileName << "|" << endl;
		cout << "ERROR!" << endl;
		return -1;
	}
	
	while(getline(infile, data))
	{
		cout << data;
		
		if(!infile.eof())
		{
			cout << endl;
		}
	}
	
	return 0;
}