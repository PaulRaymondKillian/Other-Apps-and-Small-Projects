#include "ItemsContainer.h"
#include "Item.h"


using namespace std;

int main ()
{
	cout << "Language Computer Corporation Test by Paul Killian (2/21/12) Version 1.4" << endl << endl;

	//This program assumes the file is in the directory of the executable.
	string FilePath = "words_and_topics3.tsv";

	//Add code later to allow user to input own file if desired...

	ItemsContainer *Container = new ItemsContainer();
	Container->LoadInputFile(FilePath);

	cout << "Task#1 - Total Number of Lines in File: " << Container->GetItemsCount() << "\n";
	cout << "Total Number of Topics: " << Container->GetCategoryCount() << "\n";
	cout << "\nTask#2 - Most Common Liness: \n" << Container->GetMostCommonItemsAsString(10) << "\n";
	cout << "\nTask#3 - Most Common Topics: \n" << Container->GetMostCommonCategoriesAsString(10) << "\n";
	//cout << "\nTask#4 - Most Common Words Sorted Alphabetically: \n" << Container->GetMostCommonWordsAsString(10) << "\n";
	//cout << "\nTask#5 - Most Common Words Per Most Common Topics: \n" << Container->GetMostCommonWordsFromMostCommonTopics(10, 10) << "\n";
	//cout << "\nTask#6 - Probability of Most Common Words Per Most Common Topics: \n" << Container->GetMostCommonWordsFromMostCommonTopics(10, 10, true, false) << "\n";
	//cout << "\nTask#7 - Probability of Most Common Topics Per Most Common Words: \n" << Container->GetMostCommonWordsFromMostCommonTopics(10, 10, false, true) << "\n";

	//ostringstream ss;
	//ss << Container->GetProbabilityOfTopic("nasa", "Currently");
	//cout << ss.str();

	cout << "\nPress Enter to Exit...";
	cin.ignore (std::cin.rdbuf()->in_avail() + 1);

  return 0;
}