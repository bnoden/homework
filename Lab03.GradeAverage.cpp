// Brandon Oden
// Lab 06
// 1/20/16
// Compute how many feet an object falls in given number of seconds

#include <iostream>
#include <iomanip>
using namespace std;

double FallingDistance(int, double);

int main()
{
	cout << "Seconds        Distance" << endl;
	cout << "========================" << endl;

	int seconds;
	double feet = 0.0;

	for (seconds = 1; seconds <= 10; seconds++)
		cout << setw(3) << seconds << setw(16) << setprecision(2) << fixed << FallingDistance(seconds, feet) << endl;

	return 0;
}

double FallingDistance(int time, double distance)
{
	distance = 0.5 * 32.2 * (time * time);
	return distance;
}