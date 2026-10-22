#include <iostream> 
#include <string.h> 
#include <conio.h>
#include <iomanip>
#include <fstream>

using namespace std; 



int main(int argc, char** argv) 
{ 
	ofstream outStream;			//create new ofstream
	ifstream inStream ("Moves.txt");
	int row;					//value to store the x-coordinate
	int col;					//value to store the y-coordinate
	outStream.open("Numbers.txt");
	int line;
	int moveIndex = -1;
	int moves[9][10000] = {0};
	int totalMoves = 0;

	int board[3][3] =  {{0,0,0},
						{0,0,0},
						{0,0,0}};


	while( !(inStream.eof()) )
	{
		moveIndex++;
		for( int i = 0; i < 9; i++ )
		{
			inStream >> line;

			moves[ i ][ moveIndex ] = line;
			
		}
	}
	

	for( int i = 0; i < 10000; i++ )
	{
		totalMoves++;
		cout << "Move #: " << totalMoves << endl;

		board[0][0] = moves[0][i];
		board[0][1] = moves[1][i];
		board[0][2] = moves[2][i];
		board[1][0] = moves[3][i];
		board[1][1] = moves[4][i];
		board[1][2] = moves[5][i];
		board[2][0] = moves[6][i];
		board[2][1] = moves[7][i];
		board[2][2] = moves[8][i];

		for( int j = 0; j < 3; j++ )
		{
			for( int h = 0; h < 3; h++ )
				cout << board[h][j];
		
			cout << endl;
		}

		cout << "col (1-3): ";
		cin >> col;
		cout << "row (1-3):";
		cin >> row;


		////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////
		if( board[col-1][row-1] != 0 )
		{
			cout << "*** Position Occupied, Enter new Move***" << endl;

			cout << "col (1-3): ";
			cin >> col;
			cout << "row (1-3):";
			cin >> row;
		}

		if( board[col-1][row-1] != 0 )
		{
			cout << "*** Position Occupied, Enter new Move***" << endl;

			cout << "col (1-3): ";
			cin >> col;
			cout << "row (1-3):";
			cin >> row;
		}

		if( row > 3 || row < 0 || col > 3 || col < 0 )
		{
			cout << "*** Move Invalid, Enter new Move***" << endl;

			cout << "col (1-3): ";
			cin >> col;
			cout << "row (1-3):";
			cin >> row;
		}

		if( row > 3 || row < 0 || col > 3 || col < 0 )
		{
			cout << "*** Move Invalid, Enter new Move***" << endl;

			cout << "col (1-3): ";
			cin >> col;
			cout << "row (1-3):";
			cin >> row;
		}
		////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////

		outStream << board[0][0] << " " << board[1][0] << " " << board[2][0] << " " 
					<< board[0][1] << " " << board[1][1] << " " << board[2][1] << " "
					<< board[0][2] << " " << board[1][2] << " " << board[2][2] << " "
					<< row - 1 << " " << col - 1 << endl;

		board[row-1][col-1] = 1;

		cout << board[0][0] << board[1][0] << board[2][0] << endl 
				<< board[0][1] << board[1][1] << board[2][1] << endl
				<< board[0][2] << board[1][2] << board[2][2];

		cout << endl << endl;

	}//for


	cin >> row;

    outStream.close();
	inStream.close();


   return 0; 
} 