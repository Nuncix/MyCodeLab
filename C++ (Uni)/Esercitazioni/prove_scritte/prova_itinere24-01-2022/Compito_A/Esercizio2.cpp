#include <iostream>
#include <string>

#define n 5
#define m 8

using namespace std;

int fun(string ***A, short k, short r, short s)
{
    int colPal = 0;
    for (int i = 0; i < m; i++)
    {
        int col = 0;
        for (int j = 0; j < n; j++)
        {
            bool pal = false;
            if (A[i][j])
            {
                string g = *(A[i][j]);
                if (g.length() >= s && g.length() <= r)
                {
                    for (int k = 0; k < g.length() / 2; k++)
                    {
                        if (!(g[k] == g[g.length() - 1 - k]))
                        {
                            pal = false;
                            break;
                        }
                        else
                            pal = true;
                    }
                }
            }
            col = pal ? col + 1 : col;
        }
        colPal = col >= k ? colPal + 1 : colPal;
    }
    return colPal;
}

int main()
{
    string ***A = new string **[m];
    for (int i = 0; i < m; i++)
    {
        A[i] = new string *[n];
    }
    A[0][0] = new string("cazzozzac");

    if (A[0][0])
    {
        cout << "ciao" << endl;
    }
    fun(A, 2, 20, 2);

    return 0;
}