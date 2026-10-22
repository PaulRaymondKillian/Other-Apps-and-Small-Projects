#include <iostream>
#include "ItemsContainer.h"
using namespace std;

ItemsContainer::ItemsContainer()
{
	InitContainer();
}

void ItemsContainer::InitContainer()
{
	_CountItems = 0;
}//Init Container

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

		count++;
		}
    }
		File.close();
    
	return count;
}//ReadFile

Category* ItemsContainer::GetCategory(string pCatName, bool pCreateIfNotExist)
{
	Category* Cat = NULL;

	Cat = _MapCategories[pCatName];

	//for(vector<Category*>::iterator iter = _Categories.begin(); iter != _Categories.end(); ++iter)
	//	if( (*iter)->GetName() == pCatName)
	//	{
	//		Cat = *iter;
	//		break;
	//	}

	if(!Cat && pCreateIfNotExist)
	{
		Cat = new Category(pCatName);
		//_Categories.push_back(Cat);
		_MapCategories[pCatName] = Cat;
	}

	return Cat;
}//GetCategory

Item* ItemsContainer::GetItem(string pItemName, bool CreateIfNotExist)
{
	Item* It = NULL;

	It = _MapItems[pItemName];
	//for(vector<Item*>::iterator iter = _Items.begin(); iter != _Items.end(); ++iter)
	//	if( (*iter)->GetName() == pItemName)
	//	{
	//		It = *iter;
	//		break;
	//	}

	if(!It)
	{
		It = new Item(pItemName);
		//_Items.push_back(It);
		_MapItems[pItemName] = It;
	}

	return It;
}//GetCategory

void ItemsContainer::AddItem(string pCatName, string pItemName)
{
	Category *SelectedCategory = NULL;
	SelectedCategory = GetCategory(pCatName, true);

	Item *SelectedItem = NULL;
	SelectedItem = GetItem(pItemName, true);

	if(SelectedCategory && SelectedItem)
	{
		SelectedCategory->AddItem(SelectedItem);
		SelectedItem->AddCategory(SelectedCategory);
		
		//Remove sort here... if we sort on every addition, that is a lot of sorting. We should only sort when the order list is needed: Sort uses O(n*logn) time 
		//sort(_OrderedCategories.begin(), _OrderedCategories.end(), CompareCategories);
	}

}//AddItem

int ItemsContainer::GetItemsCount()
{
	return _CountItems;
}//GetItemsCount

//This should run in O(n), Linear time
//Note: This is better than keeping an ordered vector using <algorithm> sort because that sort requires O(nlogn), loglinear time, 
//		while iterating through an unordered list requries only O(n) time, given that there are less than n-iterations.
vector<Pair> ItemsContainer::GetMostFrequentPairs(int pCount)
{
	vector<Pair> MostFrequentPairs;
	int CurrentHighestValue;
	Category *CurrentHighestCat;
	Item *CurrentHighestItem;
	Category *CurrentCat;

	for(int count = 0; count < pCount; count++)
	{	
		CurrentHighestValue = 0;
		//For though each category
		for(map<string, Category*>::iterator iterCat = _MapCategories.begin(); iterCat != _MapCategories.end(); ++iterCat)
		{	//Go through each item of the category
			CurrentCat = (*iterCat).second;
			map<Item*, int> Items = CurrentCat->GetAllItemsMap();
			//I am not fond of this part, because it requires private knowledge of the implementation of the Category object
			for(map<Item*, int>::iterator iterItem = Items.begin(); iterItem != Items.end(); ++iterItem)
			{
				if( (*iterItem).second > CurrentHighestValue && !(*iterItem).first->IsSelected(CurrentCat->GetName()))
				{
					CurrentHighestCat = (*iterCat).second;
					CurrentHighestItem = (*iterItem).first;
					CurrentHighestValue = (*iterItem).second;
				}
			}//for - Map Items
		}//for - Map Categories
		Pair newPair;
		newPair._Category = CurrentHighestCat;
		newPair._Item = CurrentHighestItem;
		MostFrequentPairs.push_back(newPair);

		//Set this pair as selected
		CurrentHighestCat->SetSelected(CurrentHighestItem->GetName());
		CurrentHighestItem->SetSelected(CurrentHighestCat->GetName());
	}//for - count

	return MostFrequentPairs;
}//GetMostFrequentPairs

//This should run in O(n), Linear time
//Note: This is better than keeping an ordered vector using <algorithm> sort because that sort requires O(nlogn), loglinear time, 
//		while iterating through an unordered list requries only O(n) time, given that there are less than n-iterations..
vector<Category*> ItemsContainer::GetMostFrequentCategories(int pCount)
{
	vector<Category*> SelectedCategories;
	int CurrentHighestCount;
	Category *CurrentHighestCat = NULL;

	for(int i=0; i<pCount; i++)
	{
		CurrentHighestCount = 0;
		for(map<string, Category*>::iterator iter = _MapCategories.begin(); iter != _MapCategories.end(); ++iter)
			if( (*iter).second->GetCount() > CurrentHighestCount && !(*iter).second->IsSelected())
			{
				CurrentHighestCat = (*iter).second;
				CurrentHighestCount = CurrentHighestCat->GetCount();
			}
		SelectedCategories.push_back(CurrentHighestCat);
		CurrentHighestCat->SetSelected();
	}
	
	//Reset all selected
	for(vector<Category*>::iterator iter = SelectedCategories.begin(); iter != SelectedCategories.end(); ++iter)
		(*iter)->ResetSelected();

	return SelectedCategories;

}//GetTopRankedCategories