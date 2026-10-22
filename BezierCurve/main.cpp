#include <iostream>

using namespace std;

struct Point
{ float x,y; };

Point coordlist[4];
float t,k;


int main()
{
	k = 0.025;

	coordlist[0].x = 0;
	coordlist[0].y = 0;
	coordlist[1].x = 25;
	coordlist[1].y = 100;
	coordlist[2].x = 500;
	coordlist[2].y = 500;
	coordlist[3].x = 400;
	coordlist[3].y = 475;

	//Calculate and draw bezier curve 
		double x1,x2,y1,y2; 
		x1 = coordlist[0].x; 
		y1 = coordlist[0].y; 
		for(t=k;t<=1+k;t+=k){ 
			//use Berstein polynomials 
			x2=(coordlist[0].x+t*(-coordlist[0].x*3+t*(3*coordlist[0].x- 
			coordlist[0].x*t)))+t*(3*coordlist[1].x+t*(-6*coordlist[1].x+ 
			coordlist[1].x*3*t))+t*t*(coordlist[2].x*3-coordlist[2].x*3*t)+ 
			coordlist[3].x*t*t*t; 
			y2=(coordlist[0].y+t*(-coordlist[0].y*3+t*(3*coordlist[0].y- 
			coordlist[0].y*t)))+t*(3*coordlist[1].y+t*(-6*coordlist[1].y+ 
			coordlist[1].y*3*t))+t*t*(coordlist[2].y*3-coordlist[2].y*3*t)+ 
			coordlist[3].y*t*t*t; 
			//draw curve 
			//offscreenG.drawLine((int)x1,(int)y1,(int)x2,(int)y2); 
			x1 = x2; 
			y1 = y2; 
			cout << y2 << endl;//", " << y2 << endl;
		} 

		char z;
		cin >> z;

	return 0;
}