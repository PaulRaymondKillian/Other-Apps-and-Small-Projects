#include <iostream>
#include "Node.h"
using namespace std;


Node::Node()
{
	_Message = "";
}

Node::Node(string pString)
{
	_Message = pString;
}

void Node::SetNextNode(Node *pNextNode)
{
	_NextNode = pNextNode;
}//SetNextNode

Node* Node::GetNextNode()
{
	return _NextNode;
}//GetNextNode

string Node::GetMessage()
{
	return _Message;
}//GetMessage