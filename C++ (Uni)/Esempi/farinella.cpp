#include <cstdlib> //per rand e srand
#include <ctime>
#include <iostream>

using namespace std;

int main()
{
    srand(111222333);
    srand(time(0));

    for (int i = 0; i < 100; i++)
    {
        cout << rand() << endl;
    }
}