/*
2.Due stringhe si dicono sorelle se hanno lo stesso
numero di vocali. Scrivere un metodo che prenda in
input una matrice A di puntatori a stringhe, e
restituisca un boolean che indichi se esiste una
colonna di A in cui sono puntate almeno due stringhe
sorelle.
*/

#include <iostream>

using namespace std;

bool isSiblings(string **A, int rows, int colns)
{
    for (int i = 0; i < colns; i++)
    {
        int c1 = 0;
        for (int j = 0; j < rows; j++)
        {
            int c2 = 0;
            for (int k = 0; k < rows; k++)
            {
                if (A[j][i][k] == A[k][i][k])
                    c2++;
            }
            if (c1 == c2)
                return true;
            c1 = c2;
        }
    }
    return false;
}

int main()
{
    string **A = new string *[3];
    for (int i = 0; i < 3; i++)
    {
        A[i] = new string[3];
        for (int j = 0; j < 3; j++)
        {
            cin >> A[i][j];
        }
    }
    if (isSiblings(A, 3, 3))
        cout << "true";
    else
        cout << "false";
    return 0;
}