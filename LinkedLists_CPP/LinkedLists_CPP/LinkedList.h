#ifndef _LINKEDLIST_h_included_
#define _LINKEDLIST_h_included_

#include <iostream>
#include "Node.h"

using namespace std;

class LinkedList
{ 
	Node *_StartNode;
	Node *_EndNode;
	Node *_CurrentNode;
  public:
	//Constructors
	LinkedList();
	LinkedList(string pMessage);

	//List Modifications Methods
	void AddNode(string pMessage);
	Node* GetNode(int pIndex0);
	void RemoveNode(Node* pNode);

	//List Output Methods
	string OutputListValues();

};
#endif