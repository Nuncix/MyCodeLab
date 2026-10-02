#include <iostream>

using namespace std;

string** esercizio12(string** S, int n, short k, string s) {
    string** A = new string*[n];
    for(int i = 0; i < n; i++) {
        string temp = S[i][n - i - 1];
        if(temp.length() >= k && temp.find(s) == 0) {
            A[i] = new string(temp);
        }
        else {
            A[i] = new string(S[i][i]);
        }
    }
    return A;
}

int main() {
    return 0;
}