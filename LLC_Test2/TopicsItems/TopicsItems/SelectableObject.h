#ifndef _SELECTABLEOBJECT_h_included_
#define _SELECTABLEOBJECT_h_included_

#include <vector>
#include <string>

using namespace std;

class SelectableObject
{ 
public:
	SelectableObject();
	SelectableObject(string pName);
	~SelectableObject();
	void InitSelectableObject(string pName);
	string GetName();

	//Selected Methods are used for determine if an item has been already used during a process
	//bool IsSelected();
	bool IsSelected();
	bool IsSelected(string pSelectedAssociation);
	void ResetSelected();
	void SetSelected();
	void SetSelected(string pSelectedAssociation);

private:
	string _Name;
	vector<string> _SelectedAssociations;

};
#endif