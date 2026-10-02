#include <iostream>
#include <iomanip>

using namespace std;

#define N 2
#define M 2
#define p 2

void fun1(int x[][N])
{
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            cout << setw(5) << x[i][j];
    cout << endl;
}

void fun2(int x[N][M])
{
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            cout << x[i] << "\t";
    cout << endl;
}

void fun3(int **x)
{
    for (int i = 0; i < N; i++)
        cout << x[i] << "\t";
    cout << endl;
}

void fun4(int x[][N][M])
{
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            for (int k = 0; k < M; k++)
                cout << x[i][j][k] << "\t";
    cout << endl;
}

int main()
{
    int x[][N] = {1, 2, 3, 4};
    fun1(x);
    cout << endl;
    fun2(x);
    cout << endl;
    fun3(x);
    cout << endl;

    int x[N][M][p]=
}