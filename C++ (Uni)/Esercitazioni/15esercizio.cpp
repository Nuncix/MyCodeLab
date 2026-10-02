#include <iostream>

using namespace std;

#define m 2
#define n 3

float *esercizio(int *q[n][m], float a, float b)
{
    float *out = new float[m];

    int A = int(a + 0.5);

    int B = int(b + 0.5);

    for (int j = 0; j < m; j++)
    {
        out[j] = 0;
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            if (q[i][j]) //controllo numeri mancanti
            {
                int x = *q[i][j];
                if (x >= a && x <= b)
                {
                    out[j] += x;
                    num++;
                }
            }
        }
        out[j] /= num;
    }
    return out;
}

int main(){
    
}