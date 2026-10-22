#include <iostream>
#include "Item.h"
#include "Category.h"

using namespace std;


Item::Item() : SelectableObject()
{

}

Item::Item(string pName, map<string, Item*> pOtherItemsMap) : SelectableObject(pName)
{
	InitItem(pName, pOtherItemsMap);
}

void Item::InitItem(string pName, map<string, Item*> pOtherItemsMap)
{
	QualifySimilarItems(pName, pOtherItemsMap);
}//InitItem

void Item::QualifySimilarItems(string pName, map<string, Item*> pOtherItemsMap)
{
	for(map<string, Item*>::iterator iter = pOtherItemsMap.begin(); iter != pOtherItemsMap.end(); ++iter)
	{
		if((*iter).first != pName)
		{
			//Item *i = (*iter).second;
			//string s = (*iter).second->GetName();
			if( EqualStringsInsensitive((*iter).second->GetName(), pName))
			{
				//_SimilarItems.push_back((*iter).second);
				AddSimilarItem((*iter).second);
				(*iter).second->AddSimilarItem(this);
			}
		}
	}
}//QualifySimilarItems

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

void Item::AddSimilarItem(Item* pSimilarItem)
{
	_SimilarItems.push_back(pSimilarItem);
}