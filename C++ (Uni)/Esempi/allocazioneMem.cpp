#include <iostream>

using namespace std;

//heap memory
int *p_global = new int(2);

//data memory
double data = 0.5;
int global = 10;

void foo()
{
    //stack memory
    int local = 20;

    //heap memory
    int *dynamic = new int(30);
    delete dynamic;
    dynamic = NULL;

    cout << "foo()" << endl;
}

int *returnDynamicArray()
{
    int *x = new int[50000]{1, 2, 3, 4, 5};
    return x;
}

void furnariDynamic()
{
    int *x = returnDynamicArray();

    cout << x[3] << endl;

    delete[] x;
    x = nullptr;

    if (x)
    {
        cout << x[3] << endl;
    }
}

void memoryLeak()
{
    int *x;
    for (int i = 0; i < 10000; i++)
    {
        x = returnDynamicArray();
        delete[] x;
    }
}

int **furnariDynamicMatrix()
{
    int **v = new int *[3];
    for (int i = 0; i < 3; i++)
    {
        v[i] = new int[4];
        for (int j = 0; j < 4; j++)
        {
            v[i][j] = 0;
        }
    }
    return v;
}

void refFun(int *x)
{
    *x = 10;
}

void refFun2()
{
    int z = 2;
    int h = 7;

    refFun(&z);

    cout << z << endl;
}

int main()
{
    foo();
    furnariDynamic();
    memoryLeak();
    refFun2();

    return 0;
}