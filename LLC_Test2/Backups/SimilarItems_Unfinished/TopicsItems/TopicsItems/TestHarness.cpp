#include <iostream>
#include "ItemsContainer.h"

using namespace std;

int main()
{
	cout << "Language Computer Corporation Test by Paul Killian (2/21/12) Version 1.4" << endl << endl;

	//This program assumes the file is in the directory of the executable.
	string FilePath = "words_and_topics2.tsv";

	//Add code later to allow user to input own file if desired...

	ItemsContainer *Container = new ItemsContainer();
	Container->LoadInputFile(FilePath);

	cout << "Task#1 - Total Number of Lines in File: " << Container->GetItemsCount() << "\n";
	//Container->GetMostFrequentPairs(10);
	Container->GetMostFrequentCategories(10, true);
	//cout << "\nTask#2 - Most Common Liness: \n" << Container->GetMostCommonItemsAsString(10) << "\n";







	cout << "\nPress Enter to Exit...";
	cin.ignore (std::cin.rdbuf()->in_avail() + 1);

	return 0;
}
 

