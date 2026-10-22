/*------------------------------------------------------------------------

 -------------------------------------------------------------------------*/

#include <iostream>		// Include is like the package statement
#include <conio.h>		// Include Windows console IO header (non-Linux)
#include <math.h>
#include <ctime>
#include "Street.h"

using namespace std;	// Using statement is like Java's import statement


int main(int argc, char *argv[])	// Main - like in Java
{
//////////////////////////////
// Declare Methods

int calcNextMove( int row, int col, int direction, int speed, bool carOneAhead, bool carTwoAhead, bool light );


//////////////////////////////
// Begin Declaring Data

	int road[101][101][2] = {{0},{0},{0}};

	int nextMove = 0;

	bool trafficLight = false;
	const bool GREEN = true;
	const bool RED = false;

	int timeOfDay = 0;
	int timeElapsed = 0;
	double trafficTimeMultiplier = 1;
	int maxTimeElapsed = 100;

	int totalCarsThrough = 0;

	const int speedSTOPPED = 0;
	const int speedSLOW = 1;
	const int speedFAST = 2;

	const int indexCAR = 0;
	const int indexSPEED = 1;

	bool carOneAhead = false;
	bool carTwoAhead = false;

	const int stopHereOnRed = 49;

	int tempRandom = 0;

	const int eastLOWERLANE = 52;
	const int eastUPPERLANE = 51;
	const int eastLEFTTURNLANE = 50;

	const int eastSTOPHERE = 46;


// End Declaring Data
/////////////////////////////

	srand((unsigned)time(0));

	for( int i = 0; i < 101; i++ )
		for( int k = 0; k < 101; k++ )
		{
			if( i == 52 || i == 51 || i == 48 || i == 47 || k == 52 || k == 51 || k == 48 || k == 47 )
				road[i][k][indexCAR] = 0;
			else if( ( i == 49 && k >=41 && k <= 46 ) || ( i == 50 && k >=53 && k <= 58 ) || ( k == 50 && i >=41 && i <= 46 ) || ( k == 49 && i >=53 && i <= 58 ) )
					road[i][k][indexCAR] = 0;
				else
					road[i][k][indexCAR] = 8;

		}//for


	for( int x = 0; x < maxTimeElapsed; x++ )
	{


/////////////////////////////////
// Sweep Lower East-Bound Street
	for( int i = 100; i >= 0; i-- )			// Sweep through the street
	{

		if( road[i][eastLOWERLANE][indexCAR] == 1 )		// Check if car exists at that spot
		{

			//If car went through, add it to total and clear the road
			if( (i == 100 && road[i][eastLOWERLANE][indexSPEED] > 0) || (i == 99 && road[i][eastLOWERLANE][indexSPEED] == 2) )
			{
				totalCarsThrough++;				//add a tally
				road[i][eastLOWERLANE][indexSPEED] = 0;		//clear the road
				road[i][eastLOWERLANE][indexCAR] = 0;			//no car, no speed obviously

			}//if
			else
			{
				if( road[i+1][eastLOWERLANE][indexCAR] == 1 )
					carOneAhead = true;
				else
					carOneAhead = false;

				if( road[i+2][eastLOWERLANE][indexCAR] == 1 )
					carTwoAhead = true;
				else
					carTwoAhead = false;

				nextMove = calcNextMove( i, eastLOWERLANE, 1, road[i][eastLOWERLANE][indexSPEED], carOneAhead, carTwoAhead, trafficLight );

				road[i][eastLOWERLANE][indexCAR] = 0;
				road[i][eastLOWERLANE][indexSPEED] = 0;
				road[i+nextMove][eastLOWERLANE][indexCAR] = 1;

				if( nextMove == 1 )
					road[i+nextMove][eastLOWERLANE][indexSPEED] = 2;
				else
					road[i+nextMove][eastLOWERLANE][indexSPEED] = nextMove;

			}//else


		}//if

	}//for()

// End Lower East-Bound Street
//////////////////////////////////////


	//////////////////////////
	// Go in Left Turn Lane //
	//////////////////////////
	if( road[41][eastUPPERLANE][indexCAR] == 1 || ( road[40][eastUPPERLANE][indexCAR] == 1 && road[41][eastUPPERLANE][indexCAR] == 0 ) )
	{
		tempRandom = ( rand() % 100 ) ;

		if( tempRandom > 70 )
		{
			road[40][eastLEFTTURNLANE][indexCAR] = 1;
			road[40][eastUPPERLANE][indexCAR] = 0;
			road[40][eastUPPERLANE][indexSPEED] = 0;
		}//if	
	}//if


//////////////////////////////////////
// Upper East-Bound Street

	for( int i = 100; i >= 0; i-- )			// Sweep through the street
	{

		if( road[i][eastUPPERLANE][indexCAR] == 1 )		// Check if car exists at that spot
		{

			//If car went through, add it to total and clear the road
			if( (i == 100 && road[i][eastUPPERLANE][indexSPEED] > 0) || (i == 99 && road[i][eastUPPERLANE][indexSPEED] == 2) )
			{
				totalCarsThrough++;				//add a tally
				road[i][eastUPPERLANE][indexSPEED] = 0;		//clear the road
				road[i][eastUPPERLANE][indexCAR] = 0;			//no car, no speed obviously


			}//if
			else
			{
				if( road[i+1][eastUPPERLANE][indexCAR] == 1 )
					carOneAhead = true;
				else
					carOneAhead = false;

				if( road[i+2][eastUPPERLANE][indexCAR] == 1 )
					carTwoAhead = true;
				else
					carTwoAhead = false;

				nextMove = calcNextMove( i, eastUPPERLANE, 1, road[i][eastUPPERLANE][indexSPEED], carOneAhead, carTwoAhead, trafficLight );

				road[i][eastUPPERLANE][indexCAR] = 0;
				road[i][eastUPPERLANE][indexSPEED] = 0;
				road[i+nextMove][eastUPPERLANE][indexCAR] = 1;

				if( nextMove == 1 )
					road[i+nextMove][eastUPPERLANE][indexSPEED] = 2;
				else
					road[i+nextMove][eastUPPERLANE][indexSPEED] = nextMove;

			}//else


		}//if

	}//for()


// End Upper East-Bound Street
//////////////////////////////////////

//////////////////////////////////////
// East Left Turn Lane

	for( int i = 46; i >= 41; i-- )
	{
		if( road[i][eastLEFTTURNLANE][indexCAR] == 1 )
		{
				if( road[i+1][eastLEFTTURNLANE][indexCAR] == 1 )
					carOneAhead = true;
				else
					carOneAhead = false;

				nextMove = calcNextMove( i, eastLEFTTURNLANE, 1, speedSLOW, carOneAhead, 0, trafficLight );

				road[i][eastLEFTTURNLANE][indexCAR] = 0;
				road[i][eastLEFTTURNLANE][indexSPEED] = 0;
				road[i+nextMove][eastLEFTTURNLANE][indexCAR] = 1;

		}//if

	}//for


// End East Left Turn Lane
/////////////////////////////////////

		tempRandom = ( rand() % 100 ) ;
		if( tempRandom > 60 )
		{
			road[0][eastLOWERLANE][indexCAR] = 1;
			road[0][eastLOWERLANE][indexSPEED] = 2;
		}


		tempRandom = ( rand() % 100 ) ;
		if( tempRandom > 60 )
		{
			road[0][eastUPPERLANE][indexCAR] = 1;
			road[0][eastUPPERLANE][indexSPEED] = 2;
		}

		for( int w = 0; w < 101; w++ )
			cout << (w % 10 );

		cout << endl;

		for( int z = 0; z < 101; z++ )
		{
			for( int y = 0; y < 101; y++ )
			{
				if( road[y][z][indexCAR] == 8 )
					cout << " ";
				else
					cout << road[y][z][indexCAR];
			}
			cout << endl;
		}

		cout << "Time Elapsed: " << timeElapsed << " Road: " << endl;
		cout << endl << "Total Cars: " << totalCarsThrough << " tempRandom: " << tempRandom << endl;

		int a = 0;
		cin >> a;
		cout << endl << endl;

		if( a == 1 )
			trafficLight = RED;
		else
			trafficLight = GREEN;

		timeElapsed++;

	}//for()


    return 0;
}



int calcNextMove( int row, int col, int direction, int speed, bool oneAhead, bool twoAhead, bool light )
{
	int streetLoc = row;
	int moveForward = 0;
	int stopSpot = 0;

	const bool RED = false;


	if( direction == 1 )
		stopSpot = 46;

	if( streetLoc == (stopSpot - 1) && light == RED && oneAhead == false )
	{
		moveForward = 1;
	}
	else
		if( streetLoc == stopSpot && light == RED )
		{
			moveForward = 0;
		}
		else
			if( twoAhead == true && oneAhead == false && speed == 0 )
			{
				moveForward = 0;
			}
			else
				if( twoAhead == true && oneAhead == false )
				{
					moveForward = 1;
				}
				else
					if( oneAhead == true )
					{
						moveForward = 0;	//Car stops because it cant go further
					}
					else
						if( oneAhead == false && twoAhead == false && speed == 1 )
						{
							moveForward = 1;
						}
						else
							if( oneAhead == false && twoAhead == false && speed == 2 )
							{
								moveForward = 2;
							}
							else
								if( oneAhead == false && twoAhead == false && speed == 0 )
								{
									moveForward = 1;
								}

	return moveForward;

}//calcNextMove