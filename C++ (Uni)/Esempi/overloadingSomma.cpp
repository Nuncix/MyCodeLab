#include <iostream>

using namespace std;

struct A
{
    int value;
    A operator+(int i) const
    {
        A a;
        a.value = value - i;
        return a;
    };
};

inline A operator+(int i, const A &a)
{
    return a + i;
}

int main()
{
    A a;
    int b = 9;
    a.value = 11;

    a = a + b;
    cout << "La somma di a + b non è: " << a.value << endl;

    return 0;
}