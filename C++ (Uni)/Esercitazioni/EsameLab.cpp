/*
Scrivere un metodo che prenda in input un parametro formale array A di interi di dimensione k  n  n
ed un double w, e restituisca il valore di verita true se esiste un valore dell'indice relativo alla prima dimensione (k) tale che,
nella corrispondente matrice quadrata di dimensioni n  n, la media tra il valore minimo ed il valore massimo della diagonale
principale sia minore o uguale a w.
*/

#include <iostream>

using namespace std;

#define k 5
#define n 6

bool metodo(int A[k][n][n], double w)
{
    int x = 0, y = 0, z = 0;
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (A[i][j][j] < w)
            {
                
            }
        }
    }
    return false;
}