// Brandon Oden
// 1/19/16
// Calculate pay by doubling pay each day

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double pay, totalPay = 0.0;		// The amount paid each day, cumulative amount paid
	int daysWorked;		// Declaration of daysWorked

	cout << "Enter the number of days you will be working? ";
	cin >> daysWorked;	// daysWorked is defined
	cout << "Days" << setw(19) << "Pay" << endl;
	cout << "========================\n";

	int day;

	for (day = 1, pay = 0.05; day <= daysWorked; day++, pay += pay)
	{
		cout << setw(3) << day << setw(21) << setprecision(2) << fixed << pay << endl;
		totalPay += pay;
	}

	cout << "\nYour total pay is " << totalPay << endl;

	return 0;
}

