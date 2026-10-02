#include <iostream>
#include <array>

using namespace std;

void Esembio(int p[])
{
    p[0] = 90;
}

void Esembio(int *p, int i)
{
    p += i;
    *p = 90;
}

int main()
{

    int v[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    array<int, 10> a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    Esembio(v, 2);
    Esembio(&a[5]);

    // Stampa v
    cout << "V: ";
    for (int i = 0; i < sizeof(v) - 1; i++)
        cout << v[i] << " ";

    cout << endl;

    // Stampa a
    cout << "A: ";
    for (int i = 0; i < sizeof(a) - 1; i++)
        cout << a[i] << " ";

    cout << endl;

    return 0;
}