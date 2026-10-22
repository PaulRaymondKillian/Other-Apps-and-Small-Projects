#include "World.h"
#include "Sky.h"
#include "Land.h"
#include "GUI.h"
#include <iostream>
#include <vector>

using namespace std;



/*
At first, we let the user select the driver type, then start up the engine, set
a caption, and get a pointer to the video driver.
*/
int main()
{

	int planeX = 300;
	int planeY = 300;

	World* world = new World();
	World* world2 = new World();
	Sky* sky = new Sky();
	Sky* sky2 = new Sky();
	Land* land = new Land();
	Land* land2 = new Land();
	GUI* gui = new GUI();
	GUI* gui2 = new GUI();

	vector<Environment*> EnvironmentList;	//A vector of pointers to a base-class
	EnvironmentList.push_back(sky);
	EnvironmentList.push_back(sky2);
	EnvironmentList.push_back(land);
	EnvironmentList.push_back(gui);
	EnvironmentList.push_back(gui);
	EnvironmentList.push_back(land);
	


	EnvironmentList[0]->DrawEnvironment();
	EnvironmentList[1]->DrawEnvironment();
	EnvironmentList[2]->DrawEnvironment();
	EnvironmentList[3]->DrawEnvironment();
	EnvironmentList[4]->DrawEnvironment();
	EnvironmentList[5]->DrawEnvironment();

	cout << endl << EnvironmentList.size() << endl;

	for(int i=0; i<EnvironmentList.size();i++)
		EnvironmentList[i]->DrawEnvironment();
	
	char a;
	cin >> a;
	return 0;
}

/*
That's all. I hope it was not too difficult.
**/
