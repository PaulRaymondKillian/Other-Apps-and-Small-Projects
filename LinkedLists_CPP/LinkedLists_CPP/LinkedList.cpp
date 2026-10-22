#include <iostream>
#include "LinkedList.h"
#include "Node.h"

using namespace std;

LinkedList::LinkedList()
{
	_StartNode = new Node("");
	_EndNode = _StartNode;
	_CurrentNode = _StartNode;
}
LinkedList::LinkedList(string pMessage)
{
	_StartNode = new Node(pMessage);
	_EndNode = _StartNode;
	_CurrentNode = _StartNode;
}

void LinkedList::AddNode(string pMessage)
{
	Node *newNode = new Node(pMessage);
	_EndNode->SetNextNode(newNode);
	_EndNode = newNode;
}//AddNode

Node* LinkedList::GetNode(int pIndex0)
{
	Node *tempNode = _StartNode;
	for(int i=0; i<pIndex0; i++)
		tempNode = tempNode->GetNextNode();

	return tempNode;
}//GetNode

void LinkedList::RemoveNode(Node* pNode)
{
	Node *tempNode = _StartNode;
	int Counter = 0;
	int MaxCount = 1000;
	
	if (pNode == _StartNode)
	{
		//If removing first node, do special
		_StartNode = _StartNode->GetNextNode();
	}
	else
	{
		if (pNode == _EndNode)
		{	//If this node is equal to the end node

		}
		else
		{
			while(tempNode->GetNextNode() != pNode)
			{
				//Do this to prevent null ref
				if(tempNode->GetNextNode() != _EndNode)
					tempNode = tempNode->GetNextNode();
				//else
					//throw new exception("Node not found");

				Counter++;
				//if( Counter >= MaxCount )
					//throw new exception("Node not found");
			}

			//tempNode should now equal the node prior to the node to be deleted
			tempNode->SetNextNode(tempNode->GetNextNode()->GetNextNode());
		}
	}

}//RemoveNode


string LinkedList::OutputListValues()
{
	string Values = "";
	Node *iterateNode = _StartNode;
	int Counter = 0;
	int MaxCount = 1000;

	while(iterateNode != _EndNode)
	{
		Values.append(iterateNode->GetMessage());
		Values.append(",");
		Counter += 1;
		if (Counter >= MaxCount)
			break;

		iterateNode = iterateNode->GetNextNode();
	}
	//Still need to add the message from the last node
	Values += iterateNode->GetMessage();


	//Values = _StartNode->GetMessage();

	return Values;
}//OutputListValues

 