#include <cstdlib>
#include <ctime>

using namespace std;

double **fun(double **A, int M, int N)
{
    double **B = new double *[N];
    srand(time(NULL));
    for (int i = 0; i < N; i++)
    {
        B[i] = new double[M];
        for (int j = 0; j < M; j++)
        {
            double s = rand() / double(RAND_MAX);
            if (A[j][i] > s)
            {
                B[i][j] = A[j][i];
            }
            else
            {
                B[i][j] = A[i % M][j % N];
            }
        }
    }
    return B;
}

int main()
{
    double **A = new double *[3];
    for (int i = 0; i < 3; i++)
    {
        A[i] = new double[3];
    }
    A[0][0] = 1;
    A[0][1] = 0;
    A[0][2] = 0;
    A[1][0] = 0;
    A[1][1] = 1;
    A[1][2] = 0;
    A[2][0] = 0;
    A[2][1] = 1;
    A[2][2] = 1;

    double **B = fun(A, 3, 3);

    return 0;
}