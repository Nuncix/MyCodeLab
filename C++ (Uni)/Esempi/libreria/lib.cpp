#include <iostream>
#include <string>

using namespace std;

int somma(int a, int b)
{
    return a + b;
}

int pow(int base, int esponente)
{
    int prodotto = 1;
    for (int i = 0; i < esponente; i++)
    {
        prodotto *= base;
    }
    return prodotto;
}

void print(string s) // void: non restituisce nulla
{
    cout << s << endl;
    return;
    cout << "Non mi restituisce nulla" << endl;
}
