#include <iostream>

using namespace std;

bool esercizio25(int ***M, int n, int m, short k, double x) {
    for(unsigned short j = 0; j < m; j++) {
        unsigned short c = 0;
        for(unsigned short i = 0; i < n - 1; i++)
            if((M[i][j]) && (M[i+1][j]) && (M[i+1][j][0] != 0) && ((double)M[i][j][0]/M[i+1][j][0]) < x) c++;
        if(c == k) return true;
    }
    return false;
}

int* funzione1(int N) {
    int *A = new int[N];
    for(int i = 0; i < N; i++) A[i] = i;
    return A;
}

int** funzione2(int N, int M) {
    int **A = new int*[N];
    for(int i = 0; i < N; i++) {
        A[i] = new int[M];
    }
    return A;
}

int main() {
    return 0;
}