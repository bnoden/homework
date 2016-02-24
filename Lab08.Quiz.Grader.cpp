// Brandon Oden
// Lab08 Quiz Grader
// 1/21/16

#include <iostream>
using namespace std;

void inputAnswers(int[]);
int numberCorrect(int[], int[]);
void numberIncorrect(int[], int[]);

const int TOTAL_ANSWERS = 10;

int main()
{
	int correctAnswers[] = { 5, 22, 35, 0, 16, 28, 4, 3, 42, 51 };
	int givenAnswers[TOTAL_ANSWERS];
	int numRight;
	inputAnswers(givenAnswers);
	numRight = numberCorrect(correctAnswers, givenAnswers);

	cout << "\nYour quiz grade is " << numRight * TOTAL_ANSWERS << "%" << endl;
	
	return 0;
}

void inputAnswers(int givenAnswers[])
{
	for (int i = 0; i < TOTAL_ANSWERS; i++)
	{
		cout << "Please enter your answer for question #" << i + 1 << " ";
		cin >> givenAnswers[i];
	}
}

int numberCorrect(int correctAnswers[], int givenAnswers[])
{
	int numRight = 0;
	
	for (int i = 0; i < TOTAL_ANSWERS; i++)
		if (correctAnswers[i] == givenAnswers[i])
			numRight += 1;

	return numRight;
}