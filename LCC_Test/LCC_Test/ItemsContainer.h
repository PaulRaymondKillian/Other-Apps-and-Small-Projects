#ifndef _ITEMSCONTAINER_h_included_
#define _ITEMSCONTAINER_h_included_

#include <fstream>
#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <map>
#include <algorithm>

#include "Item.h"
#include "ItemCategory.h"
#include "HelperSpace.h"

using namespace std;
using namespace HelperSpace;

class ItemsContainer
{ 
  public:
	ItemsContainer();
	ItemsContainer(string pFilePath);
	~ItemsContainer();
	void InitItemsContainer();
	void LoadInputFile(string pFilePath);
	void AddItem(string pWord, string pTopic);
	void ResetSelectedItems();
	ItemCategory* GetCategory(string pTopic, bool AddCategoryIfNotExist);
	ItemCategory* AddCategory(string pTopic);
	int ReadFileIntoItems(string pFilePath);
	int GetItemsCount();
	int GetCategoryCount();
	vector<Item*> GetMostCommonItems(int pCount);
	string GetMostCommonItemsAsString(int pCount);
	vector<ItemCategory*> GetMostCommonCategories(int pCount);
	string GetMostCommonCategoriesAsString(int pCount);
	vector<string> GetMostCommonWords(int pCount);
	string GetMostCommonWordsAsString(int pCount);
	vector<Item*> GetMostCommonWords(string pTopic, int pCount);
	string GetMostCommonWordsAsString(string pTopic, int pCount);
	string GetMostCommonWordsFromMostCommonTopics(int pCountTopics, int pCountWords, bool pIncProbTopicPerWord=false, bool pIncProbWordPertopic=false);
	double GetProbabilityOfTopicPerWord(string pTopic, string pWord);
	double GetProbabilityOfWordPerTopic(string pTopic, string pWord);

  private:
	vector<ItemCategory*> _Categories;
	int _CountCategories;
	int _CountItems;

};
#endif