#include <iostream>
#include "LinkedList.h"
#include "Node.h"

using namespace std;

int main()
{
  cout << "Hello World!" << endl;   
  cout << "Welcome to C++ Programming" << endl; 

  LinkedList *a = new LinkedList("1");
  a->AddNode("2");
  a->AddNode("3");
  a->AddNode("4");
  a->AddNode("5");


  cout << endl << a->OutputListValues().c_str() << endl;
  cout << a->GetNode(3)->GetMessage().c_str() << endl;

  a->RemoveNode(a->GetNode(3));

  cout << endl << a->OutputListValues().c_str() << endl;

  //Node *n = new Node();

  cout << "Done.";
  int x;
  cin >> x;

  return 0;
}
 

