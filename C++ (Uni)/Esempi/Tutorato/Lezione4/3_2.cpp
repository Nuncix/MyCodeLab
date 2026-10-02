#include <iostream>

using namespace std;

bool esercizio3(string** S, int n, int m, char* C, float w) {
    float somma = 0;
    int L = 0;
    for(int i = 0; i < n; i++) {
        somma = 0;
        L = 0;
        for(int j = 0; j < m; j++) {
            L += S[i][j].length();
            for(int k = 0; k < n; k++) {
                for(int l = 0; l < S[i][j].length(); l++) {
                    if(S[i][j][l] == C[k]) {
                        somma += 1;
                    }
                }
            }
        }
        if((somma/L) * 100 > w) {
            return true;
        }
    }
    for(int i = 0; i < m; i++) {
        somma = 0;
        L = 0;
        for(int j = 0; j < n; j++) {
            L += S[j][i].length();
            for(int k = 0; k < n; k++) {
                for(int l = 0; l < S[j][i].length(); l++) {
                    if(S[j][i][l] == C[k]) {
                        somma += 1;
                    }
                }
            }
        }
        if((somma/L) * 100 > w) {
            return true;
        }
    }
    return false;
}

int main() {
    return 0;
}