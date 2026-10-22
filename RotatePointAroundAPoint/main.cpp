#include <iostream>
#include <cmath>
#include <math.h>

#define _USE_MATH_DEFINES 

using namespace std;

struct POINT
{
	float x,y;
};

POINT rotate_point(float cx, float cy, float angle, POINT p) 
{
	float s = sin(angle);   
	float c = cos(angle);    

	// translate point back to origin:   
	p.x -= cx;   
	p.y -= cy;    

	// rotate point   
	float xnew = p.x * c - p.y * s;   
	float ynew = p.x * s + p.y * c;    

	// translate point back:   
	p.x = xnew + cx;   
	p.y = ynew + cy; 

	return p;
}

int main( int argc, const char* argv[] )
{
	cout << "asdfasdfads";
	POINT p1,p2;
	p1.x = 100;
	p1.y = 100;
	p2.x = 50;
	p2.y = 100;

	p2 = rotate_point(p1.x,p1.y, -3*(3.14159)/4,p2);

	cout << p2.x << "," << p2.y;
	char a; 
	cin >> a;
}


