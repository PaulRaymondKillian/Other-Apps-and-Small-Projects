#include "SelectableObject.h"

using namespace std;


SelectableObject::SelectableObject()
{
	InitSelectableObject("N/A");
}

SelectableObject::SelectableObject(string pName)
{
	InitSelectableObject(pName);
}

SelectableObject::~SelectableObject()
{ 
}

void SelectableObject::InitSelectableObject(string pName)
{
	_Name = pName;
}//InitItem

string SelectableObject::GetName()
{
	return _Name;
}//GetItemName

bool SelectableObject::IsSelected()
{
	bool IsSelected = false;
	if(int(_SelectedAssociations.size()) > 0)
		IsSelected = true;
	return IsSelected;
}//IsSelected

bool SelectableObject::IsSelected(string pSelectedAssociations)
{
	bool IsSelected = false;
	for(vector<string>::iterator iter = _SelectedAssociations.begin(); iter != _SelectedAssociations.end(); ++iter)
		if( (*iter) == pSelectedAssociations)
		{
			IsSelected = true;
			break;
		}

	return IsSelected;
}//IsSelected

void SelectableObject::ResetSelected()
{
	_SelectedAssociations.clear();
}//ResetSelected

void SelectableObject::SetSelected()
{
	SetSelected("__#AnyValue#__");
}//SetSelected

void SelectableObject::SetSelected(string pSelectedAssociation)
{
	_SelectedAssociations.push_back(pSelectedAssociation);
}//SetSelected