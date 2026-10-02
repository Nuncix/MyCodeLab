#include <iostream>

using namespace std;

int sumDouble(double a, double b)
{
    return a + b + 0.5;
}

double frazIntera(unsigned int x, unsigned int y)
{
    return y ? (double)x / (double)y : -1;
}

int sumArrToInt(double v[])
{
    double t = 0.5;
    for (int i = 0; i < sizeof(v) - 1; i++)
        t += v[i];
    return t;
}

int sumArrToIntPtr(double *v)
{
    double t = 0.5;
    for (int i = 0; i < sizeof(v) - 1; i++)
    {
        t += *v;
        v++;
    }
    return t;
}

double aveArr(int v[])
{
    double t = 0;
    for (int i = 0; i < sizeof(v) - 1; i++)
        t += v[i];
    return t / sizeof(v);
}

int main()
{
    double a = 5.7, b = 3.2;
    cout << sumDouble(a, b) << endl;

    unsigned int x = 10, y = 5;
    cout << frazIntera(x, y) << endl;

    int dim = 4;
    double v1[4] = {1.2, 2.3, 3.4, 4.5};
    cout << sumArrToIntPtr(v1) << endl;

    int v2[10] = {5, 4, 33, 7, 81, 12, 3, 2, 1, 0};
    cout << aveArr(v2) << endl;

    return 0;
}