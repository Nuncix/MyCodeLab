#include <iostream>

using namespace std;

int main()
{
    int n, m;
    cout << "inserisci numero righe: ";
    cin >> n;

    cout << "inserisci numero colonne: ";
    cin >> m;

    int mat[n][m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            cout << "inserisci elemento x[" << i << "][ " << j << "]: ";
            cin >> mat[i][j];
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            cout << "x[" << i << "][ " << j << "]: " << mat[i][j] << endl;
        }
    }

    return 0;
}