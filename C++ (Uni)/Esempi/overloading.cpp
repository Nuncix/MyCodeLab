#include <iostream>

using namespace std;

class Point2D
{
	double x, y;

public:
	Point2D(double _x, double _y) : x(_x), y(_y) {}
	Point2D() : x(0), y(0) {}
	double getX() const { return x; }
	double getY() const { return y; }
	Point2D sum(Point2D p)
	{
		return Point2D(x + p.x, y + p.y);
	}

	friend Point2D sum(Point2D p1, Point2D p2);
	friend Point2D operator+(Point2D p1, Point2D p2);
};

void print(Point2D p)
{
	cout << "(" << p.getX() << ", " << p.getY() << ")" << endl;
}

Point2D sum(Point2D p1, Point2D p2)
{
	return Point2D();
}

int main()
{
	Point2D p1(3.2, 5.4);
	Point2D p2();
}

class C
{
	string s;
	int x;

public:
	C(string _s, int _x) : s(_s), x(_x) {}
	string getS() { return s; }
	int getX() { return x; }
	friend C operator+(C c1, C c2);
	void print()
	{
		cout << s << ": " << x << endl;
	}
};