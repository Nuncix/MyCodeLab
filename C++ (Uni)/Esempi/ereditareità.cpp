#include <iostream>
using namespace std;

class A
{
    int x;
    //B b;
public:
    A()
    {
        x = 10;
    }

    void f() { cout << "A.f(), x=" << x << endl; }
    int getX() { return x; }
};

class B : public A
{
    int y;

public:
    B()
    {
        y = 18;
    }
    void g() { cout << "B.g(), y=" << y << endl; }
    int getY() { return y; }
};

int main()
{
    A a;
    a.f();

    B b;
    cout << "b.getX()=" << b.getX() << endl;
    b.f();
    b.g();

    cout << "a.getX()" << a.getX() << endl;

    return 0;
}