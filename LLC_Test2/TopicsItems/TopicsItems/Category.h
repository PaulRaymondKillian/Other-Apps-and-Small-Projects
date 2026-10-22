#ifndef _CATEGORY_h_included_
#define _CATEGORY_h_included_

#include <iostream>
#include <string>
#include <map>
#include "SelectableObject.h"

class Item; //Forward Declaration

using namespace std;

class Category : public SelectableObject
{ 
public:
	Category();
	Category(string pCategoryName);
	~Category();
	void InitCategory();
	int GetCount();
	void AddItem(Item* pItem);
	int GetItemCount(Item* pItem);
	map<Item*, int> GetAllItemsMap();
	static bool CompareCategories( Category *pLeftCat, Category *pRightCat );
	static int GetCount(vector<Category*> pCategories);
	void AddItems(map<Item*,int> pCategoriesMap);

private:
	//Item *_Items;

	map<Item*, int> _MapItems;

};
#endif