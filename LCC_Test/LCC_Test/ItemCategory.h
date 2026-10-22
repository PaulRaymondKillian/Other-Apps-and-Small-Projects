#ifndef _ITEMCATEGORY_h_included_
#define _ITEMCATEGORY_h_included_

#include <iostream>
#include <vector>
#include <string>
#include <sstream>

#include "Item.h"

using namespace std;

class ItemCategory
{ 

  public:
	ItemCategory();
	ItemCategory(string pName);
	~ItemCategory();
	void InitItemCategory();
	Item* AddItem(string pWord, bool pIncreaseCountIfExists);
	string GetCategoryName();
	Item* GetItem(string pName, bool pIncreaseCountIfExists);
	int GetCount();
	string GetCountAsString();
	int GetCountOfWord(string pWord);

	//Selected Methods are used for determine if an item has been already used during a process
	bool IsSelected();
	void ResetSelected();
	void SetSelected();

	vector<Item*> _Items;
  private:
	string _Name;
	int _CountItems;
	bool _Selected;

};
#endif