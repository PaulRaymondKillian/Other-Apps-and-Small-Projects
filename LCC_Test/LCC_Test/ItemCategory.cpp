#include "ItemCategory.h"

using namespace std;


ItemCategory::ItemCategory()
{
	InitItemCategory();
}//Default Constructor

ItemCategory::ItemCategory(string pName)
{
	InitItemCategory();
	_Name = pName;
}//Constructor

void ItemCategory::InitItemCategory()
{
	_Name = "N/A";
	_CountItems = 0;
	_Items = vector<Item*>();
	_Selected = false;
}//InitItemCategory

Item* ItemCategory::AddItem(string pWord, bool pIncreaseCountIfExists = false)
{
	//Item *newItem = new Item(pWord, _Name);
	Item *newItem = GetItem(pWord, pIncreaseCountIfExists);

	if(newItem->GetCount() == 1)
	{
		_Items.push_back(newItem);
		_CountItems += 1;
	}
	
	return newItem;
}//AddItem

string ItemCategory::GetCategoryName()
{
	return _Name;
}//GetCategoryName

Item* ItemCategory::GetItem(string pWord, bool pIncreaseCountIfExists = false)
{
	Item *SelectedItem;
	bool FoundItem = false;

	//Search vector for item
	for(unsigned int i=0; i<_Items.size(); i++)
	{
		if(_Items[i]->GetWord() == pWord)
		{
			SelectedItem = _Items[i];
			FoundItem = true;

			if( pIncreaseCountIfExists)
				SelectedItem->IncreaseCount();

			//cout << pWord << "," << _Name << " - ";
			break;
		}
	}//for

	if(!FoundItem)
		SelectedItem = new Item(pWord, _Name);

	return SelectedItem;
}//GetItem

int ItemCategory::GetCount()
{	return _CountItems;	}

string ItemCategory::GetCountAsString()
{
	stringstream ss;
	ss << GetCount();
	return ss.str();
}//GetCountAsString

int ItemCategory::GetCountOfWord(string pWord)
{
	int count = 0;

	for(unsigned int i=0; i<_Items.size(); i++)
		if(_Items[i]->GetWord() == pWord)
			count = _Items[i]->GetCount();

	return count;
}//GetCountOfWord

bool ItemCategory::IsSelected()
{	
	return _Selected;	
}

void ItemCategory::ResetSelected()
{	_Selected = false;	}

void ItemCategory::SetSelected()
{	_Selected = true;	}

