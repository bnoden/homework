// Brandon Oden
// Lab #02 Grade Average Program
// 1/17/16

#include <iostream>
using namespace std;

const int NUMBER_OF_GRADES = 4;	// The number of grades to be entered

int main()
{
	double grade[NUMBER_OF_GRADES];	// To hold grades
	double gradeTotal = 0, gradeAverage;	// For the sum and average of all grades

	cout << "Please enter the first grade: ";
	cin >> grade[0];
	cout << "Please enter the second grade: ";
	cin >> grade[1];
	cout << "Please enter the third grade: ";
	cin >> grade[2];
	cout << "Please enter the fourth grade: ";
	cin >> grade[3];
	
	for (int i = 0; i < NUMBER_OF_GRADES; i++)
	{
		gradeTotal += grade[i];
	}

	gradeAverage = gradeTotal / NUMBER_OF_GRADES;

	cout << "\nThe average grade is: " << gradeAverage << endl;

	return 0;
}

