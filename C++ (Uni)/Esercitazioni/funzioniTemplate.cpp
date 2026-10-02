#include <iostream>
#include <string>

using namespace std;

template <typename T>
void print(T x[], int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << x[i];
        if (i != n - 1)
            cout << " - ";
    }
    cout << endl;
}

int main()
{
    print<char>("ciao", 5);
    print<int>(new int[5]{1, 2, 3, 4, 5}, 5);
    print<string>(new string[5]{"ciao", "come", "stai", "?", "!"}, 5);
    print<double>(new double[5]{1.0, 2.0, 3.0, 4.0, 5.0}, 5);

    return 0;
}