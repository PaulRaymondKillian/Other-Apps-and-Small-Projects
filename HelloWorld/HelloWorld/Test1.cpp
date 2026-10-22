////Self Test 1: Reversing an inputted string with C++ compatible with STL and CVV/G++ compiler
////Note: Develop several methods to yield the same result.
//
//#include <iostream>
//#include <string>
//#include <sstream>
//#include <vector>
//
//
//using namespace std;
//
////BEGIN: Method PROTOS
//
////Main Methods
//string ReverseString_UsingVector(string pString);
//string ReverseString_UsingStringStream(string pString);
//string ReverseString_UsingSecondString(string pString);
//string ReverseStrings(string pString);
//
////Helper Methods
//vector<string> &split(const string &s, char delim, vector<string> &elems);
//vector<string> split(const string &s, char delim);
//vector<string> split2(string s, char delim);
////END: Method PROTOS
//
//int main ()
//{
//	string input;
//	string inputRev;
//	string inputRev2;
//	string inputRev3;
//	string inputStrings = "Hello this is a string!";
//	string inputStringsRev;
//	//string inputStringRev2;
//
//	cout << "Start of Program\n";
//	
//	cout << "Please input a string: ";
//	//cin >> input; //This method does not get the entire line
//	getline(cin, input);
//
//	cout << input << endl;
//
//	inputRev = ReverseString_UsingVector(input);
//	inputRev2 = ReverseString_UsingStringStream(inputRev);
//	inputRev3 = ReverseString_UsingSecondString(inputRev2);
//	inputStringsRev = ReverseStrings(inputStrings);
//	//inputStringsRev2 = ReverseStrings2(inputStrings);
//
//	cout << inputRev << endl << inputRev2 << endl << inputRev3 << endl << inputStringsRev;
//
//	cout << "\nPress Enter to Exit...";
//	cin.ignore (std::cin.rdbuf()->in_avail() + 1);
//
//	
//	return 0;
//}
//
////This method destroys the input and only uses a single string to process
//string ReverseString_UsingVector(string pString)
//{
//	vector<char> temp;
//
//	for(int i=pString.length()-1; i>=0; i--)	//using a signed int 'i'
//		temp.push_back(pString[i]);
//
//
//	for(unsigned int i=0; i < temp.size(); i++)	//using an unsigned int 'i'
//		pString.at(i) = temp[i];
//
//	return pString;
//}//ReverseString
//
////Does not destroy the input string
//string ReverseString_UsingStringStream(string pString)
//{
//	stringstream ss; 
// 
//	for(int i=pString.length()-1; i>=0; i--)
//		ss << pString[i];
//
//
//	return ss.str();
//
//}//ReverseString
//
////Does not destroy the input string
//string ReverseString_UsingSecondString(string pString)
//{
//	string SecondString = "";
// 
//	for(int i=pString.length()-1; i>=0; i--)
//		SecondString += pString[i];
//
//
//	return SecondString;
//
//}//ReverseString
//
//string ReverseStrings(string pString)
//{
//	string SecondString = "";
//	//vector<string> s = split(pString, ' '); 
//	vector<string> s = split2(pString, ' '); 
//
//	for(int i=s.size()-1; i>=0; i--)
//	{
//		SecondString += s[i];
//		if( i != 0 )
//			SecondString += " ";
//	}
//
//	return SecondString;
//}//ReserverStrings
//
//vector<string> &split(const string &s, char delim, vector<string> &elems) { 
//    stringstream ss(s); 
//    string item; 
//    while(getline(ss, item, delim)) { 
//        elems.push_back(item); 
//    } 
//    return elems; 
//} 
//
//vector<string> split(const string &s, char delim) { 
//    vector<string> elems; 
//    return split(s, delim, elems); 
//} 
//
//vector<string> split2(string s, char delim) { 
//    vector<string> elems; 
//	stringstream ss(s); 
//    string item; 
//    while(getline(ss, item, delim)) { 
//        elems.push_back(item); 
//    } 
//    return elems; 
//} 
//
