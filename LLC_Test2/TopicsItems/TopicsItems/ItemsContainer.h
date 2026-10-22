#ifndef _ITEMSCONTAINER_h_included_
#define _ITEMSCONTAINER_h_included_

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <map>
#include "Category.h"
#include "Item.h"
#include "HelperSpace.h"

using namespace std;
using namespace HelperSpace;

struct Pair
{
	Category *_Category;
	Item *_Item;
};//STRUCTURE - Pair

class ItemsContainer
{ 
public:
	ItemsContainer();
	~ItemsContainer();
	void InitContainer();
	void LoadInputFile(string pFilePath);
	int ReadFileIntoItems(string pFilePath);
	Category* GetCategory(string pCatName, bool CreateIfNotExist=false);
	Item* GetItem(string pItemName, bool CreateIfNotExist=false);
	void AddItem(string pCatName, string pItemName);
	int GetItemsCount();
	vector<Pair> GetMostFrequentPairs(int pCount);//, bool pIsCaseInsensitive=false);
	string GetMostFrequestPairsAsString(int pCount);//, bool pIsCaseInsensitive=false, bool IncludeCount=false, bool pIncludeProbability=false);
	vector<Category*> GetMostFrequentCategories(int pCount, bool pIsCaseInsensitive=false);
	string GetMostFrequentCategoriesAsString(int pCount, bool pIsCaseInsensitive=false, bool pIncludeCount=false);
private:
	//set<Category*> _SetCategories;
	//vector<Category*> _OrderedCategories;
	//vector<Item*> _OrderedItems;

	map<string, Category*> _MapCategories;
	map<string, Item*> _MapItems;
	int _CountItems;

};
#endif