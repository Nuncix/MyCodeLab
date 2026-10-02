#include <iostream>

using namespace std;

short esercizio16(string*** S, int n, int m, short* B) {
    short r = -1;
    short cond = 0;
    for(int i = 0; i < n; i++) {
        short c = 0;
        for(int j = 0; j < m; j++)
            if((S[i][j]) && (*S[i][j]).length() <= B[j]) c++;
        if(c > cond) {
            cond = c;
            r = i;
        }
    }
    return r;
}

int main() {
    return 0;
}