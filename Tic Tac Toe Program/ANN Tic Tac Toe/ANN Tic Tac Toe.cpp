#include <iostream> 
#include <string.h> 
#include <conio.h>
#include <iomanip>
#include <fstream>
#include <ctime>
#include <cstdlib>

using namespace std; 



int main(int argc, char** argv) 
{ 
	double chromosomes[100][16] = {0};

	int board [9] = {0};

	


	srand((unsigned)time(0));
	//Populate Chromosomes
	for( int i = 0; i < 100; i++)
	{
		for( int j = 0; j < 16; j++ )
		{
			double tempRandomNum = rand();
			double tempRandomDen = rand();

			double tempRandom = ( ( tempRandomNum / (tempRandomDen + 1) ) );

			int tempRandPosNeg = rand()  % 10;

			if( tempRandPosNeg < 5 )
				tempRandom = -tempRandom;

			chromosomes[i][j] = tempRandom;

		}//for

	}//for


	//Output Chromosomes to Screen
	for( int i = 0; i < 100; i++ )
	{
		for( int j = 0; j < 16; j++ )
		{
			cout << chromosomes[i][j] << "	";
		}//for
		cout << endl;
	}//for


	int input;
	cin >> input;


   return 0; 
} 