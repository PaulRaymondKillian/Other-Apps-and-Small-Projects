#include <iostream>
#include "Category.h"
#include "Item.h"

using namespace std;


Category::Category() : SelectableObject()
{

}

Category::Category(string pName) : SelectableObject(pName)
{

}

void Category::InitCategory()
{

}

int Category::GetCount()
{
	//return int(_MapItems.size());
	int count = 0;

	for(map<Item*, int>::iterator iter = _MapItems.begin(); iter != _MapItems.end(); ++iter)
		count += (*iter).second;

	return count;
}//GetCount

void Category::AddItem(Item* pItem)
{
	_MapItems[pItem] += 1;
}//AddItem

int Category::GetItemCount(Item* pItem)
{
	return _MapItems[pItem];
}//GetItemCount

map<Item*, int> Category::GetAllItemsMap()
{
	return _MapItems;
}//GetItemsMap

bool Category::CompareCategories( Category *pLeftCat, Category *pRightCat )
{
	bool LeftGreater = false;
	bool Done = false;

	if(pLeftCat->GetCount() > pRightCat->GetCount())
		LeftGreater = true;

	return LeftGreater;
}//CompareCategories

int Category::GetCount(vector<Category*> pCategories)
{
	int count = 0;

	for(vector<Category*>::iterator iter = pCategories.begin(); iter!= pCategories.end(); ++iter)
		count += (*iter)->GetCount();

	return count;
}//GetCount<vector>

void Category::AddItems(map<Item*,int> pItemsMap)
{
	for(map<Item*,int>::iterator iter = pItemsMap.begin(); iter != pItemsMap.end(); ++iter)
		_MapItems[(*iter).first] += (*iter).second;
}//AddItems - map<Category*,int>