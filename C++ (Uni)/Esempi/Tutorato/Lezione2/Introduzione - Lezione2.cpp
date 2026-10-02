#include <iostream>

using namespace std;

void printMatrix(int** M, int n, int m) {
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
            cout << M[i][j] << "  ";
        }
        cout << endl;
    }
}

int main() {
    int N = 5;
    int M = 5;
    int **matrice = new int*[N];
    for(int i = 0; i < N; i++) {
        matrice[i] = new int[M];
        for(int j = 0; j < M; j++) {
            matrice[i][j] = i + j;
        }
    }
    printMatrix(matrice, N, M);
    for(int i = 0; i < N; i++) {
        cout << matrice[i][i] << " ";
    }
    cout << endl;
    for(int i = 0, j = M - 1; i < N; i++, j--) {
        cout << matrice[i][j] << " ";
    }
    cout << endl;
    for(int i = 0; i < N; i++) {
        cout << matrice[i][M - 1 - i] << " ";
    }
    cout << endl;
    string pippo = "ciao";
    string newString = "";
    pippo.erase(pippo.find("i"), 1);
    cout << pippo << endl;
}