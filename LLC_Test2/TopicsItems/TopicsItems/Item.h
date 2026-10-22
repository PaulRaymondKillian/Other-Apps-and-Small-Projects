#ifndef _ITEM_h_included_
#define _ITEM_h_included_

#include <iostream>
#include <string>
#include <map>
#include "SelectableObject.h"

class Category; //Forward Declaration

using namespace std;

class Item : public SelectableObject
{ 
public:
	Item();
	Item(string pName);
	~Item();
	void InitItem();
	int GetCount();
	void AddCategory(Category* pCategory);
	int GetCategoryCount(Category* pCategory);

private:
	//Category *_Categories;

	map<Category*, int> _MapCategories;
};
#endif