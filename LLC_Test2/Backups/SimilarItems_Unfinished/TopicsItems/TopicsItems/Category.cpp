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
	return int(_MapItems.size());
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