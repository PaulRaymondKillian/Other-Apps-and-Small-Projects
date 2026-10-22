#ifndef _ITEM_h_included_
#define _ITEM_h_included_

#include <iostream>
#include <string>
#include <map>
#include "SelectableObject.h"
#include "HelperSpace.h"

class Category; //Forward Declaration

using namespace std;
using namespace HelperSpace;

class Item : public SelectableObject
{ 
public:
	Item();
	Item(string pName, map<string, Item*> pOtherItemsMap);
	~Item();
	void InitItem(string pName, map<string, Item*> pOtherItemsMap);
	void QualifySimilarItems(string pName, map<string, Item*> pOtherItemsMap);
	int GetCount();
	void AddCategory(Category* pCategory);
	int GetCategoryCount(Category* pCategory);
	void AddSimilarItem(Item* pSimilarItem);

private:
	//Category *_Categories;

	map<Category*, int> _MapCategories;
	vector<Item*> _SimilarItems;
};
#endif