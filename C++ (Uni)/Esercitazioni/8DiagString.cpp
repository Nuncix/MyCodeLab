/*
8.Scrivere un metodo che prenda in input una matrice
quadrata di puntatori a stringhe Q ed una stringa s. Il
metodo restituisca il valore booleano true se e solo se
il numero di stringhe che contengono s, presenti nella
diagonale principale di Q, e maggiore del numero di
stringhe che contengono s presenti nella diagonale
secondaria di Q.
*/
#include <string>
#define N 4

using namespace std;

bool fun(string **Q, string s)
{
    int c1 = 0, c2 = 0;
    for (int i = 0; i < N; i++)
    {
        int c3 = 0;
        for (int j = 0; j < s.length(); j++)
        {
            if (Q[i][i][j] == s[j])
                c3++;
        }
        if (c3 == s.length())
            c1++;

        c3 = 0;
        for (int j = 0; j < s.length(); j++)
        {
            if (Q[N - i][i][j] == s[j])
                c3++;
        }
        if (c3 == s.length())
            c2++;
    }
    if (c1 > c2)
        return true;
    return false;
}

int main()
{
}