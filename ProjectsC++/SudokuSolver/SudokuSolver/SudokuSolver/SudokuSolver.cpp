// SudokuSolver.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <vector>
#include <string>
#include <fstream>

using namespace std;

void makeMeOlder(int*){}

int main()
{
	int ivan = 19;
	string whatever = "whatever";
	int* ivanPtr = &ivan;

	cout << "id of ivan is: " << &ivan << endl;
	cout << "id of whatever is: " << &whatever << endl;

	cout << ivanPtr << endl;
	cout << *ivanPtr << endl;

	ivan = 10;
	ivanPtr = &ivan;

	cout << "New pointer: " << ivanPtr << endl;
	cout << "New value: " << *ivanPtr << endl;

	return 0;
}
