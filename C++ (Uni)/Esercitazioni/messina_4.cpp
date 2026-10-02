#include <iostream>

using namespace std;

#define n 3
#define m 4

bool funzione(string ***P, string s, short a, short b)
{
    for (int i = 0; i < n; i++)
    {
        int cnt = 0;
        for (int j = 0; j < m; j++)
        {
            
            string s1 = *(P[i][j]);
            if (s1.find(s) != string::npos)
                cnt++;
        }
        if (cnt >= a && cnt <= b)
            return true;
    }
    return false;
}

int main()
{
    string s = "franco";
    int a = 1, b = 8;
    
    string ***P;
    P = new string **[n];
    for (int i = 0; i < n; i++)
    {
        P[i] = new string *[m];
        for (int j = 0; j < m; j++)
        {
            P[i][j] = new string(s);
        }
    }
    
    cout << funzione(P, s, a, b);

    return 0;
}