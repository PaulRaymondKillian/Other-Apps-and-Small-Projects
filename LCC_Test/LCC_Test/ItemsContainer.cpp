#include "ItemsContainer.h"

using namespace std;

ItemsContainer::ItemsContainer()
{
	InitItemsContainer();
}//Default Constructor

ItemsContainer::ItemsContainer(string pFilePath)
{
	InitItemsContainer();
	LoadInputFile(pFilePath);

}//Constructor

//Called by every constructor to set init variables
void ItemsContainer::InitItemsContainer()
{
	_CountItems = 0;
	_CountCategories = 0;
	_Categories = vector<ItemCategory*>();
}//InitItemsContainer

void ItemsContainer::LoadInputFile(string pFilePath)
{
	_CountItems = ReadFileIntoItems(pFilePath);
}//LoadInputFile


//Reads the inputted file, returns the number of items in file (number of lines in the file)
int ItemsContainer::ReadFileIntoItems(string pFilePath)
{
	int count = 0;
	string s = "";
	string line;
	vector<string> split;

	//ifstream qFile(pFilePath.c_str()); //G++ compiler doesnt like this method of opening file
    ifstream File;
	File.open(pFilePath.c_str());

    while (File.peek() != EOF) 
	{
        getline(File, line);
        split = SplitString(line, '\t');

		if(split.size() == 2)
		{

		AddItem(split[0], split[1]);

		//cout << _Categories[count].Output();
		count++;
		}
    }
		File.close();
    
	return count;
}//ReadFile

ItemCategory* ItemsContainer::GetCategory(string pTopic, bool AddCategoryIfNotExist=false)
{
	ItemCategory *SelectedCategory;
	bool FoundCategory = false;

	//Seach vector for the category
	for(unsigned int i=0; i< _Categories.size(); i++)
	{
		if(_Categories[i]->GetCategoryName() == pTopic)
		{
			SelectedCategory = _Categories[i];
			FoundCategory = true;
			break;	//exit for loop
		}
	}//for

	if(!FoundCategory && AddCategoryIfNotExist)
		SelectedCategory = AddCategory(pTopic);

	return SelectedCategory;
}//GetCategory

ItemCategory* ItemsContainer::AddCategory(string pTopic)
{
	ItemCategory *newCategory = new ItemCategory(pTopic);
	_Categories.push_back(newCategory);

	_CountCategories++;

	return newCategory;
}//AddCategory

void ItemsContainer::AddItem(string pWord, string pTopic)
{
	GetCategory(pTopic, true)->AddItem(pWord, true);
}//AddItem

void ItemsContainer::ResetSelectedItems()
{
	for(unsigned int i=0; i<_Categories.size(); i++)
		{
			if(_Categories[i]->IsSelected())
				_Categories[i]->ResetSelected();

			for(unsigned int j=0; j<_Categories[i]->_Items.size(); j++)
			{
				if(_Categories[i]->_Items[j]->IsSelected())
					_Categories[i]->_Items[j]->ResetSelected();

			}//for Categories-Items
		}//for Categories
}//ResetSelectedItems

int ItemsContainer::GetItemsCount()
{
	return _CountItems;
}//GetItemsCount

int ItemsContainer::GetCategoryCount()
{
	return _CountCategories;
}//GetCategoryCount

vector<Item*> ItemsContainer::GetMostCommonItems(int pCount)
{
	vector<Item*> MostCommonItems = vector<Item*>();
	int CurrentHighestCount;
	Item *CurrentHighestItem;

	for(int count=0; count < pCount; count++)
	{
		CurrentHighestCount = 0;
		for(unsigned int i=0; i<_Categories.size(); i++)
		{
			for(unsigned int j=0; j<_Categories[i]->_Items.size(); j++)
			{
				if(_Categories[i]->_Items[j]->GetCount() > CurrentHighestCount && !_Categories[i]->_Items[j]->IsSelected())
				{
					CurrentHighestCount = _Categories[i]->_Items[j]->GetCount();
					CurrentHighestItem = _Categories[i]->_Items[j];
				}
			}//for Categories-Items
		}//for Categories
		
		CurrentHighestItem->SetSelected();				//Item is selected, set it
		MostCommonItems.push_back(CurrentHighestItem);	//Add selected item to temp vector

	}//for count

	ResetSelectedItems();	//Reset the selected items for future processing

	return MostCommonItems;
}//GetMostCommonItems

string ItemsContainer::GetMostCommonItemsAsString(int pCount)
{
	string s = "";
	vector<Item*> MostCommonItems = GetMostCommonItems(pCount);

	for(int i=0; i<pCount; i++)
	{
		s += "Count: " + MostCommonItems[i]->GetCountAsString() + " - Topic: " + MostCommonItems[i]->GetTopic() + ", Word: " + MostCommonItems[i]->GetWord() + "\n";
	}//for

	ResetSelectedItems();	//Reset the selected items for future processing

	return s;
}//GetMostCommonItems

vector<ItemCategory*> ItemsContainer::GetMostCommonCategories(int pCount)
{
	vector<ItemCategory*> MostCommonItems = vector<ItemCategory*>();
	int CurrentHighestCount;
	ItemCategory *CurrentHighestCategory;

	for(int count=0; count < pCount; count++)
	{
		CurrentHighestCount = 0;
		for(unsigned int i=0; i<_Categories.size(); i++)
		{
			if(_Categories[i]->GetCount() > CurrentHighestCount && !_Categories[i]->IsSelected())
			{
				CurrentHighestCount = _Categories[i]->GetCount();
				CurrentHighestCategory = _Categories[i];
			}
		}//for Categories

		CurrentHighestCategory->SetSelected();
		MostCommonItems.push_back(CurrentHighestCategory);

	}//for count

	ResetSelectedItems();	//Reset the selected items for future processing

	return MostCommonItems;

}//GetMostCommonCategories
string ItemsContainer::GetMostCommonCategoriesAsString(int pCount)
{
	string s = "";

	vector<ItemCategory*> MostCommonItems = GetMostCommonCategories(pCount);

	for(int i=0; i<pCount; i++)
	{
		s += "Count: " + MostCommonItems[i]->GetCountAsString() + " - Topic: " + MostCommonItems[i]->GetCategoryName() + "\n";
	}//for

	ResetSelectedItems();	//Reset the selected items for future processing

	return s;
}//GetMostCommonCategories

vector<string> ItemsContainer::GetMostCommonWords(int pCount)
{
	vector<string> MostCommonWords;
	map<string, int> WordMap;
	int CurrentHighestValue = 0;
	string CurrentHighestWord;
	map<string,int>::iterator CurrentHighestIterator;

	for(unsigned int i=0; i<_Categories.size(); i++)
	{
		for(unsigned int j=0; j<_Categories[i]->_Items.size(); j++)
		{
			WordMap[_Categories[i]->_Items[j]->GetWord()] += _Categories[i]->_Items[j]->GetCount();
		}//for Categories-Items
	}//for Categories

	for(int count=0; count<pCount; count++)
	{
		CurrentHighestValue = -1;
		for(map<string,int>::iterator itr = WordMap.begin();itr!=WordMap.end();itr++)
		{
			if( itr->second >= CurrentHighestValue)
			{
				CurrentHighestValue = itr->second;
				CurrentHighestWord = itr->first;
				CurrentHighestIterator = itr;
			}
		}

		MostCommonWords.push_back(CurrentHighestWord);

		//Use the below code to concatenate a string, where order is by value rather than alphabetically
		//stringstream ss;
		//ss << CurrentHighestValue;
		//s += "Count: " + ss.str() + ": " + CurrentHighestWord + "\n";

		WordMap[CurrentHighestWord] = -1;	//Set value to -1 to remove from search list
	}

	MostCommonWords = HelperSpace::Alphabetize(MostCommonWords); //Sort the vector alphabetically

	return MostCommonWords;
}
string ItemsContainer::GetMostCommonWordsAsString(int pCount)
{
	string s = "";
	vector<string> MostCommonWords = GetMostCommonWords(pCount);

	for(unsigned int i=0; i<MostCommonWords.size(); i++)
		s += MostCommonWords[i] + "\n";

	return s;
}//GetMostCommonWords

vector<Item*> ItemsContainer::GetMostCommonWords(string pTopic, int pCount)
{
	vector<Item*> MostCommonItems = vector<Item*>();
	ItemCategory *SelectedCategory;
	Item *CurrentHighestItem;
	int CurrentHighestValue = 0;

	SelectedCategory = GetCategory(pTopic);

	for(int count=0; count<pCount; count++)
	{
		CurrentHighestValue = 0;
		for(unsigned int i=0; i<SelectedCategory->_Items.size(); i++)
		{
			if(SelectedCategory->_Items[i]->GetCount() >= CurrentHighestValue && !SelectedCategory->_Items[i]->IsSelected())
			{
				CurrentHighestItem = SelectedCategory->_Items[i];
				CurrentHighestValue = CurrentHighestItem->GetCount();
			}
		}//for SelectedCategory
		CurrentHighestItem->SetSelected();
		MostCommonItems.push_back(CurrentHighestItem);
	}//for count

	return MostCommonItems;

}//GetMostCommonWords

string ItemsContainer::GetMostCommonWordsAsString(string pTopic, int pCount)
{
	string s = "";
	vector<Item*> MostCommonItems = GetMostCommonWords(pTopic, pCount);
	
	for(unsigned int i=0; i<MostCommonItems.size(); i++)
	{
		s += "Count: " + MostCommonItems[i]->GetCountAsString() + " - " + MostCommonItems[i]->GetWord() + "\n";
	}

	return s;
}//GetMostCommonWords(pTopic, pCount)

string ItemsContainer::GetMostCommonWordsFromMostCommonTopics(int pCountTopics, int pCountWords, 
														bool pIncProbTopicPerWord, bool pIncProbWordPerTopic)
{
	string s = "";
	vector<ItemCategory*> MostCommonCategories = GetMostCommonCategories(pCountTopics);
	vector<Item*> MostCommonWords;

	for(unsigned int i=0; i<MostCommonCategories.size(); i++)
	{
		s += "\nCategory Count: " + MostCommonCategories[i]->GetCountAsString() + " - " + MostCommonCategories[i]->GetCategoryName();
		MostCommonWords = GetMostCommonWords(MostCommonCategories[i]->GetCategoryName(), pCountWords);
		for(unsigned int j=0; j<MostCommonWords.size(); j++)
		{
			s += "\n\t" + MostCommonWords[j]->GetCountAsString() + " - " + MostCommonWords[j]->GetWord();

			if(pIncProbTopicPerWord)
			{
				ostringstream ss;
				ss << GetProbabilityOfTopicPerWord(MostCommonCategories[i]->GetCategoryName(), MostCommonWords[j]->GetWord());
				s += "\tProb Topic Per Word: " + ss.str();
			}

			if(pIncProbWordPerTopic)
			{
				ostringstream ss;
				ss << GetProbabilityOfWordPerTopic(MostCommonCategories[i]->GetCategoryName(), MostCommonWords[j]->GetWord());
				s += "\tProb Word Per Topic: " + ss.str();
			}
		}//for - MostCommonWords
	}//for - MostCommonCategories

	return s;
}//GetMostCommonWordsFromMostCommonTopics

double ItemsContainer::GetProbabilityOfTopicPerWord(string pTopic, string pWord)
{

	double Probability = 0;
	int CountOfWordInTopic = 0;
	int CountOfWordInAll = 0;

	CountOfWordInTopic = GetCategory(pTopic)->GetCountOfWord(pWord);

	for(unsigned int i=0; i<_Categories.size(); i++)
		CountOfWordInAll += _Categories[i]->GetCountOfWord(pWord);

	if(CountOfWordInAll > 0)
		Probability = double(CountOfWordInTopic) / double(CountOfWordInAll);

	return Probability;

}//GetProbabilityOfTopic

double ItemsContainer::GetProbabilityOfWordPerTopic(string pTopic, string pWord)
{
	double Probability = 0;
	ItemCategory *SelectedCategory = NULL;

	SelectedCategory = GetCategory(pTopic);

	if(SelectedCategory)
		Probability = double(SelectedCategory->GetCountOfWord(pWord)) / double(SelectedCategory->GetCount());

	return Probability;

}//GetProbabilityOfWordPerTopic