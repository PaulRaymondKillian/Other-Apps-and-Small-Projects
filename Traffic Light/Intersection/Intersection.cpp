/*------------------------------------------------------------------------

 -------------------------------------------------------------------------*/

#include <iostream>		// Include is like the package statement
#include <conio.h>		// Include Windows console IO header (non-Linux)
#include <math.h>
#include <ctime>
#include "Intersection.h"

using namespace std;	// Using statement is like Java's import statement


int main(int argc, char *argv[])	// Main - like in Java
{
//////////////////////////////
// Declare Methods

int calcNextMove( int row, int col, int direction, int speed, bool carOneAhead, bool carTwoAhead, bool light, int leftTurnSignal );


//////////////////////////////
// Begin Declaring Data

	//////////////////
	// Global Data
	int road[101][101][3] = {{0},{0},{0}};
	
	int timeOfDay = 0;
	int timeElapsed = 0;
	double trafficTimeMultiplier = 1;
	int maxTimeElapsed = 200;

	int totalCarsThrough = 0;	
	
	int nextMove = 0;
	
	const bool GREEN = true;
	const bool RED = false;

	const int speedSTOPPED = 0;
	const int speedSLOW = 1;
	const int speedFAST = 2;

	const int indexCAR = 0;
	const int indexSPEED = 1;
	const int indexLEFTTURNSIGNAL = 2;

	bool carOneAhead = false;
	bool carTwoAhead = false;

	int tempRandom = 0;
	const int tempRANDOMCHANCE = 70;

	const int noCAR = 0;

	const int noLEFTTURNSIGNAL = 0;
	const int yesLEFTTURNSIGNAL = 1;

	//////////////////
	// East-West Data
	bool eastwestLeftTurnLight = false;

	/////////////////
	// East Data
	const int eastStopHereOnRed = 49;

	const int eastDIRECTION = 1;

	const int eastLOWERLANE = 52;
	const int eastUPPERLANE = 51;
	const int eastLEFTTURNLANE = 50;

	bool eastSafeToTurnLeft = false;
	const int eastMOVEINTOLEFTLANESPOT = 41;

	const int eastSTOPHERE = 46;

	const int eastCAR = 1;

	int eastLeftTurnChance = 0;

	/////////////////
	// West Data
	const int westLOWERLANE = 48;
	const int westUPPERLANE = 47;

	bool trafficLight = false;


// End Declaring Data
/////////////////////////////


/////////////////////////////
// Begin Setting Up Intersection in Array
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
// End Setting Up Intersection in Array
/////////////////////////////

/////////////////////////////
// Begin Time Cycles on Road until Max Time Elapsed is Reached
	for( int x = 0; x < maxTimeElapsed; x++ )
	{


/////////////////////////////////
// Sweep Lower East-Bound Street
	for( int i = 100; i >= 0; i-- )			// Sweep through the street
	{

		if( road[i][eastLOWERLANE][indexCAR] == eastCAR )		// Check if car exists at that spot
		{


			//If car went through, add it to total and clear the road
			if( (i == 100 && road[i][eastLOWERLANE][indexSPEED] > speedSTOPPED) || (i == 99 && road[i][eastLOWERLANE][indexSPEED] == speedFAST) )
			{
				totalCarsThrough++;				//add a tally
				road[i][eastLOWERLANE][indexSPEED] = noCAR;		//clear the road
				road[i][eastLOWERLANE][indexCAR] = noCAR;			//no car, no speed obviously


			}//if
			else
			{
				/////////////////////////
				// Check if there are cars in front
				if( road[i+1][eastLOWERLANE][indexCAR] == eastCAR )
					carOneAhead = true;
				else
					carOneAhead = false;

				if( road[i+2][eastLOWERLANE][indexCAR] == eastCAR )
					carTwoAhead = true;
				else
					carTwoAhead = false;
				// End Check
				//////////////////////////

				//////////////////////////
				// Prepare and Execute Car Moving
				nextMove = calcNextMove( i, eastLOWERLANE, eastDIRECTION, road[i][eastLOWERLANE][indexSPEED], carOneAhead, carTwoAhead, trafficLight, noLEFTTURNSIGNAL );

				road[i][eastLOWERLANE][indexCAR] = noCAR;
				road[i][eastLOWERLANE][indexSPEED] = noCAR;
				road[i+nextMove][eastLOWERLANE][indexCAR] = eastCAR;

				if( nextMove == 1 )
					road[i+nextMove][eastLOWERLANE][indexSPEED] = speedFAST;
				else
					road[i+nextMove][eastLOWERLANE][indexSPEED] = nextMove;
				// End Execution of Car Moving
				///////////////////////////////

			}//else


		}//if

	}//for()
// End Lower East-Bound Street
//////////////////////////////////////


	//////////////////////////////
	// Begin Move into Left Turn Lane
	if( road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexCAR] == eastCAR && road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] == noCAR && !( road[eastMOVEINTOLEFTLANESPOT+1][eastUPPERLANE][indexCAR] && road[eastMOVEINTOLEFTLANESPOT+2][eastUPPERLANE][indexCAR] ) )
	{
		tempRandom = ( rand() % 100 );

		if( tempRandom > tempRANDOMCHANCE )
		{
			road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] = eastCAR;
			road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexCAR] = noCAR;
			road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexSPEED] = noCAR;

			road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexLEFTTURNSIGNAL] = noCAR;

		}//if
	}//if
	else
		if( road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexCAR] == eastCAR && road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexCAR] == noCAR && road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] == noCAR )
		{
			tempRandom = ( rand() % 100 );

			if( tempRandom > tempRANDOMCHANCE )
			{
				road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] = eastCAR;
				road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexCAR] = noCAR;
				road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexSPEED] = speedSTOPPED;

				road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexLEFTTURNSIGNAL] = noLEFTTURNSIGNAL;

			}//if
		}//if
		else
			if( road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexCAR] == eastCAR && road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] == eastCAR )
			{
				road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexLEFTTURNSIGNAL] = eastCAR;

			}//if
			else
				if( road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexCAR] == eastCAR && road[eastMOVEINTOLEFTLANESPOT][eastUPPERLANE][indexCAR] == noCAR && road[eastMOVEINTOLEFTLANESPOT][eastLEFTTURNLANE][indexCAR] == eastCAR )
				{
					road[eastMOVEINTOLEFTLANESPOT-1][eastUPPERLANE][indexLEFTTURNSIGNAL] = yesLEFTTURNSIGNAL;

				}//if
	// End Move into Left Turn Lane
	/////////////////////////


	////////////////////////
	// Begin Crossing Intersection from Left Turn Lane

//////
	if( road[50][47][indexCAR] == eastCAR )
	{
			road[50][47][indexCAR] = noCAR;
			road[51][46][indexCAR] = eastCAR;
	}//if

//////
	if( road[49][48][indexCAR] == eastCAR )
	{
			road[49][48][indexCAR] = noCAR;
			road[50][47][indexCAR] = eastCAR;
	}//if

//////
	if( road[48][49][indexCAR] == eastCAR )
	{
			road[48][49][indexCAR] = noCAR;
			road[49][48][indexCAR] = eastCAR;
	}//if

//////
	if( road[47][50][indexCAR] == eastCAR )
	{
			road[47][50][indexCAR] = noCAR;
			road[48][49][indexCAR] = eastCAR;
	}//if

//////
	if( road[46][eastLEFTTURNLANE][indexCAR] == eastCAR )
	{
		eastSafeToTurnLeft = true;

		for(  int i = 52; i <= 56; i++ )
			if( road[i][westUPPERLANE][indexCAR] == 1 )
				eastSafeToTurnLeft = false;

		for( int i = 50; i <= 54; i++ )
			if( road[i][westLOWERLANE][indexCAR] == 1 )
				eastSafeToTurnLeft = false;

		if( ( eastSafeToTurnLeft == true && trafficLight == GREEN ) || eastwestLeftTurnLight == GREEN )
		{
			road[46][eastLEFTTURNLANE][indexCAR] = noCAR;
			road[47][eastLEFTTURNLANE][indexCAR] = eastCAR;

		}//if

	}//if

	// End Crossing Intersection from Left Turn Lane
	/////////////////////////


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

				nextMove = calcNextMove( i, eastUPPERLANE, 1, road[i][eastUPPERLANE][indexSPEED], carOneAhead, carTwoAhead, trafficLight, road[i][eastUPPERLANE][indexLEFTTURNSIGNAL] );

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

	for( int i = 45; i >= 39; i-- )
	{
		if( road[i][eastLEFTTURNLANE][indexCAR] == 1 )
		{

			if( road[i+1][eastLEFTTURNLANE][indexCAR] == 1 )
				carOneAhead = true;
			else
				carOneAhead = false;


			nextMove = calcNextMove( i, eastLEFTTURNLANE, 1, 1, carOneAhead, 0, trafficLight, 0 );

			road[i][eastLEFTTURNLANE][indexCAR] = 0;
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



int calcNextMove( int row, int col, int direction, int speed, bool oneAhead, bool twoAhead, bool light, int leftTurnSignal )
{
	int streetLoc = row;
	int moveForward = 0;
	int stopSpot = 0;

	const bool RED = false;
	const bool GREEN = true;


	if( direction == 1 )
		stopSpot = 46;

	if( streetLoc == (stopSpot - 1) && light == RED && oneAhead == false )
	{
		moveForward = 1;
	}
	else
		if( leftTurnSignal == 1 )
		{
			moveForward = 0;
		}
		else
			if( streetLoc == stopSpot && light == RED )
			{
				moveForward = 0;
			}
			else
				if( twoAhead == true && oneAhead == false && speed == 0 && light == RED )
				{
					moveForward = 1;
				}
				else
					if( twoAhead == true && oneAhead == false && speed == 0 && light == GREEN )
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