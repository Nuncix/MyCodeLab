#include <string>

#define N 5
#define M 4

using namespace std;

string fun(string A[N][M])
{
    stringstream vocali;
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            if (A[i][j].length() - A[j % N][i % M].length() > i + j)
            {
                for (int h = 0; h < A[i][j].length(); h++)
                {
                    if (A[i][j] == "a" || A[i][j] == "e" || A[i][j] == "i" || A[i][j] == "o" || A[i][j] == "u" ||
                        A[i][j] == "A" || A[i][j] == "E" || A[i][j] == "I" || A[i][j] == "O" || A[i][j] == "U")
                    {
                        vocali << A[i][j][h];
                    }
                }
            }
        }
    }
    return vocali.str();
}

int main()
{
    string A[N][M] = {
        {"pollo", "cavallo", "cane", "gatto"},
        {"cane", "gatto", "topo", "pollo"},
        {"topo", "pollo", "cavallo", "cane"},
        {"gatto", "cane", "topo", "pollo"},
        {"cavallo", "pollo", "gatto", "cane"}};
    fun(A);

    return 0;
}