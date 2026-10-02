/*
6.Scrivere un metodo che prenda come parametro
formale un cubo (array tridimensionale) C di stringhe,
e restituisca in output una stringa contenente tutte le
desinenze di due caratteri delle stringhe sulla faccia
superiore del cubo C.
*/

#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "Inserisci dimensione cubo: ";
    cin >> n;
    string C[n][n][n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                cout << "Inserisci carattere: ";
                cin >> C[i][j][k];
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                if (i == 0 && j == 0 && k == 0)
                {
                    cout << C[i][j][k] << C[i][j][k + 1] << C[i][j + 1][k + 1] << C[i][j + 1][k] << C[i + 1][j][k] << C[i + 1][j][k + 1] << C[i + 1][j + 1][k + 1] << C[i + 1][j + 1][k] << endl;
                }
                else if (i == 0 && j == 0 && k == n - 1)
                {
                    cout << C[i][j][k] << C[i][j][k - 1] << C[i][j + 1][k - 1] << C[i][j + 1][k] << C[i + 1][j][k] << C[i + 1][j][k - 1] << C[i + 1][j + 1][k - 1] << C[i + 1][j + 1][k] << endl;
                }
                else if (i == 0 && j == n - 1 && k == 0)
                {
                    cout << C[i][j][k] << C[i][j][k + 1] << C[i][j - 1][k + 1] << C[i][j - 1][k] << C[i + 1][j][k] << C[i + 1][j][k + 1] << C[i + 1][j - 1][k + 1] << C[i + 1][j - 1][k] << endl;
                }
            }
        }
    }
}