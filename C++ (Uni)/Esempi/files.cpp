#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    string path_file = "./test.txt";
    ifstream file(path_file);

    if (!file.is_open())
    {
        cout << "Errore nell'apertura del file" << endl;
    }

    string x;

    while (file >> x)
    {
        cout << x << endl;
    }

    while (getline(file, x))
    {
        cout << x << endl;
    }

    ofstream file3("output.txt");

    file3 << "RIGA UNO" << endl;
    file3 << "RIGA DUE" << endl;

    fstream file4("output2.txt", fstream::out);

    file4 << "RIGA UNO" << endl;
    file4 << "RIGA DUE" << endl;

    fstream file5("output2.txt", fstream::in);
    string xx;
    file5 >> xx;
    cout << xx << endl;

    file >> x;

    cout << x;

    return 0;
}