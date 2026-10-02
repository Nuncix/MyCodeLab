/*
3.Scrivere un metodo che prenda in input un
parametro formale matrice quadrata Q di interi ed un
double w, e restituisca un valore booleano true se
esiste almeno una colonna della matrice Q tale che il
rapporto tra la somma degli elementi della colonna
stessa e la somma degli elementi della diagonale
secondaria di Q sia maggiore di w.
*/
#include <iostream>

using namespace std;

#define N 3

bool check(int Q[N][N], double w)
{
    double sumRow = 0;
    double sumDiag = 0;

    for (int i = 0; i < N; i++)
    {
        sumDiag += Q[i][N - i];
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            sumRow += Q[i][j];
        }
        if (sumRow / sumDiag > w)
        {
            return true;
        }
        sumRow = 0;
    }
    return false;
}

int main()
{
    int Q[N][N] = {
        {8, 2, 3},
        {4, 5, 6},
        {7, 8, 9}};

    double w = 0.5;

    cout << check(Q, w) << endl;

    return 0;
}