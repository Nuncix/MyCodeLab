#include <iostream>

using namespace std;

#define M 3
#define N 3
#define K 3

int main()
{
    int m[][N][K] = {1, 2, 3, 4, 5, 6, 7, 8, 9};

    // 1.2.3 -> [1][3]
    // 4.5.6 -> [1][3]
    // 7.8.9 -> [1][3]

    cout << m[1][0][1] << endl;
}