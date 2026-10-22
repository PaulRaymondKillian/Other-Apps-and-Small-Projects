#ifndef _NODE_h_included_
#define _NODE_h_included_

#include <iostream>

using namespace std;

class Node
{ 
	string _Message;
	Node *_NextNode;
  public:
	Node();
	Node(string pString);
	void SetNextNode(Node *pNextNode);
	Node* GetNextNode();
	string GetMessage();
};
#endif