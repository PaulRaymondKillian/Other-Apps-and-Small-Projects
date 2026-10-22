#ifndef _ITEM_h_included_
#define _ITEM_h_included_

#include <iostream>
#include <sstream>

using namespace std;

class Item
{ 

  public:
	Item();
	Item(string pWord, string pTopic);
	~Item();

	void SetValues(string pWord, string pTopic); //to be used with default constructor
	void IncreaseCount();

	//Selected Methods are used for determine if an item has been already used during a process
	bool IsSelected();
	void ResetSelected();
	void SetSelected();

	int GetCount();
	string GetCountAsString();
	string GetWord();
	string GetTopic();
	string Output();	//Replace with ToString()/<< override later

  private:
	string _Word;
	string _Topic;
	int _Count;
	bool _Selected;
};
#endif