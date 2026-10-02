/*
4.Scrivere un metodo che prenda in input una matrice
di puntatori a stringhe P di dimensioni nm, due short a
e b, ed una stringa s. Il metodo restituisca il valore
booleano true se esiste almeno una colonna in P tale
che la stringa s sia sottostringa di un numero
compreso tra a e b (inclusi) di stringhe della colonna
stessa. Si assuma 0 < a b < n
*/

#include <iostream>
#include <string>

using namespace std;

bool check(string **P, short a, short b, string s)
{
    for (short i = 0; i < b; i++)
    {
        int c = 0;
        for (short j = 0; j < a; j++)
        {
            if (P[i][j].find(s) != string::npos)
            {
                c++;
            }
        }
        if (c >= a && c <= b)
        {
            return true;
        }
    }
    return false;
}

int main()
{
    short n, m, a, b;
    cin >> n >> m >> a >> b;
    string **P = new string *[n];
    for (short i = 0; i < n; i++)
    {
        P[i] = new string[m];
        for (short j = 0; j < m; j++)
        {
            cin >> P[i][j];
        }
    }
    string s;
    cin >> s;
    if (check(P, a, b, s))
    {
        cout << "true" << endl;
    }
    else
    {
        cout << "false" << endl;
    }
    return 0;
}