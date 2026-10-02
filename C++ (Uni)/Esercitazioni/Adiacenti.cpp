/*
25.Scrivere un metodo che prenda in input una 
matrice di interi M di dimensioni n x m, uno short k ed 
un double x, e restituisca il valore booleano true se 
esiste almeno una colonna in M contenente 
esattamente k coppie di elementi adiacenti tali che il 
rapporto tra il primo elemento ed il secondo elemento 
di ogni coppia sia minore di x. NB: Si assuma k <= n -
1 e si presti attenzione alle divisioni per zero!
*/

#include <iostream>

using namespace std;

bool adiacenti(int **M, short k, double x)
{
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (M[i][j] != 0 && M[i][j] != M[j][i] && M[i][j] / M[j][i] < x)
                return true;
        }
    }
    return false;
}

int main()
{
    int **M = new int *[5];
    short k = 2;
    double x = 0.5;

    for (int i = 0; i < 5; i++)
        M[i] = new int[5];

    bool peppe = adiacenti(M, k, x);
    
    cout << (peppe ? "true" : "false") << endl;

    return 0;
}