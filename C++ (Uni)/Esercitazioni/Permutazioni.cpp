/*
input k che stampa le permutazioni di un insieme dato
*/

#include <iostream>

using namespace std;

int calcoloPermutazioni(int k, int n)
{
    if (k == 1)
    {
        return n;
    }
    return calcoloPermutazioni(k - 1, n) * (n - k + 1);
}

int main()
{
    int k, n;
    cin >> k >> n;
    cout << calcoloPermutazioni(k, n) << endl;
    return 0;
}