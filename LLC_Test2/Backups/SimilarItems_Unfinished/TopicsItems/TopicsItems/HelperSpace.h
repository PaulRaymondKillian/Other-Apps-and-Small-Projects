#ifndef _HELPERSPACE_h_included_
#define _HELPERSPACE_h_included_

#include <string>
#include <vector>
#include <sstream>
#include <algorithm>
//#include "Category.h"

namespace HelperSpace 
{ 
	static vector<string> SplitString(string s, char delim)
	{
		vector<string> elems; 
		stringstream ss(s); 
		string item; 
		while(getline(ss, item, delim)) 
		{ 
			elems.push_back(item); 
		}//while
		return elems; 
	};//SplitString

	static string ToString(int pInt)
	{
		stringstream ss;
		ss << pInt;
		return ss.str();
	};//ToString int

	static string ToString(double pDouble)
	{
		stringstream ss;
		ss << pDouble;
		return ss.str();
	};//ToString double

	static bool CompareStringsInsensitive( const string &pLeftString, const string &pRightString )
	{
		bool LeftGreater;
		bool Done = false;
		for( string::const_iterator LeftIter = pLeftString.begin(), RightIter = pRightString.begin(); 
									LeftIter != pLeftString.end() && RightIter != pRightString.end(); ++LeftIter, ++RightIter )
		{
			//Compare each character (in lowercase)
			if( tolower( *LeftIter ) < tolower( *RightIter ) )
			{
				LeftGreater = true;
				Done = true;
				break;
			}
			else if( tolower( *LeftIter ) > tolower( *RightIter ) )
			{
				LeftGreater = false;
				Done = true;
				break;
			}
		}//for

		//If iterating through characters did not find an answer, check the size of the strings.
		//This is needed for where one string is contained at the beginning of the second string.
		//Ex: "Thesis" and "The"
		if(!Done)
			if( pLeftString.size() < pRightString.size() )
				LeftGreater = true;
			else
				LeftGreater = false;

		return LeftGreater;
	};//CompareStringsInsensitive

	static bool EqualStringsInsensitive( const string &pLeftString, const string &pRightString )
	{
		bool StringsEqual = true;
		bool Done = false;
		for( string::const_iterator LeftIter = pLeftString.begin(), RightIter = pRightString.begin(); 
									LeftIter != pLeftString.end() && RightIter != pRightString.end(); ++LeftIter, ++RightIter )
		{
			//Compare each character (in lowercase)
			if( tolower( *LeftIter ) != tolower( *RightIter ) )
			{
				StringsEqual = false;
				Done = true;
				break;
			}
		}//for

		//If iterating through characters did not find an answer, check the size of the strings.
		//This is needed for where one string is contained at the beginning of the second string.
		//Ex: "Thesis" and "The"
		if(!Done)
			if( pLeftString.size() != pRightString.size() )
				StringsEqual = false;

		return StringsEqual;
	};//EqualStringsInsensitive

	//static bool CompareCategories( Category *pLeftCat, Category *pRightCat )
	//{
	//	bool LeftGreater = false;
	//	bool Done = false;

	//	if(pLeftCat->GetCount() > pRightCat->GetCount())
	//		LeftGreater = true;

	//	return LeftGreater;
	//};//CompareCategories

	static vector<string> Alphabetize(vector<string> pInputVector)
	{
		//<algorithm>Sort does not truly sort the vector. It gives a precedence to capital letters over lowercase.
		//Resolve this issue later so it truly alphabetizes the string vector
		sort(pInputVector.begin(), pInputVector.end(), CompareStringsInsensitive );	//Sort the vector alphabetically

		//HelperSpace::myMethod();

		return pInputVector;
	};//Alphabetize
};

#endif

