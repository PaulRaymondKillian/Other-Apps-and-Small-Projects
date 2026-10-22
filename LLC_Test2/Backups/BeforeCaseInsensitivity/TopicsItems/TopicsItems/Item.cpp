#include <iostream>
#include "Item.h"
#include "Category.h"

using namespace std;


Item::Item() : SelectableObject()
{

}

Item::Item(string pName) : SelectableObject(pName)
{

}

void Item::InitItem()
{

}//InitItem

int Item::GetCount()
{
	return int(_MapCategories.size()); 
}//GetCount

void Item::AddCategory(Category* pCategory)
{
	_MapCategories[pCategory] += 1;
}//AddCategory


int Item::GetCategoryCount(Category* pCategory)
{
	return _MapCategories[pCategory];
}//GetItemCount