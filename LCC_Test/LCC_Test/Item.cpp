#include "Item.h"

using namespace std;


Item::Item()
{
	_Word = "";
	_Topic = "";
	_Count = 0;
	_Selected = false;
}//Default Constructor

Item::Item(string pWord, string pTopic)
{
	_Word = pWord;
	_Topic = pTopic;
	_Count = 1;
	_Selected = false;
}//Constructor

void Item::SetValues(string pWord, string pTopic) //to be used with default constructor
{
	_Word = pWord;
	_Topic = pTopic;
	_Count = 0;
}//SetValues
	
void Item::IncreaseCount()
{	_Count++;	}//IncreaseCount

int Item::GetCount()
{	return _Count;	}

string Item::GetCountAsString()
{
	stringstream ss;
	ss << GetCount();
	return ss.str();
}//GetCountAsString

string Item::GetWord()
{	return _Word;	}

string Item::GetTopic()
{	return _Topic;	}

string Item::Output()
{	
	//there has to be a better way to do the below, but the G++ compiler doesnt like the typical VC++ method and I am short on time...
	string s;
	s.append(_Word);
	s.append(",");
	s.append(_Topic);

	return s;	
}

bool Item::IsSelected()
{	
	return _Selected;	
}

void Item::ResetSelected()
{	_Selected = false;	}

void Item::SetSelected()
{	_Selected = true;	}

//void Item::SetNextNode(Item *pNextNode)
//{
//	_NextNode = pNextNode;
//}//SetNextNode
//
//Item* Item::GetNextNode()
//{
//	return _NextNode;
//}//GetNextNode
//
//string Item::GetMessage()
//{
//	return _Message;
//}//GetMessage