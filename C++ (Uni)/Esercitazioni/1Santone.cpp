/*
Un santone induista si trova nella regione indiana del
Rajasthan, quest'ultima simulata con una rajasthan
quadrata di boolean in cui il valore true indica la
presenza di un libro sacro. Scrivere un metodo che
prenda in input una rajasthan di boolean e restituisca il
numero di libri raccolti dal santone che, partendo dal
centro della regione, esegue un movimento casuale
unitario alla volta in una delle quattro direzioni prima
che egli sia traviato dalle usanze oltre colonne.
*/

#include <iostream>

#define size 15

using namespace std;

int raccoltaLibri(bool rajasthan[][size])
{
    int libri = 0;

    int santonex = (size % 2) == 0 ? size / 2 : size / 2 + 1;
    int santoney = (size % 2) == 0 ? size / 2 : size / 2 + 1;

    bool traviato = false;

    srand(time(NULL));

    while (!traviato)
    {
        int direzione = rand() % 4; // 0 = sx, 1 = dx, 2 = up, 3 = down

        if (rajasthan[santonex][santoney] == true)
        {
            libri++;
            rajasthan[santonex][santoney] = false;
        }

        switch (direzione)
        {
        case 0:
            santonex--;
            break;
        case 1:
            santonex++;
            break;
        case 2:
            santoney--;
            break;
        case 3:
            santoney++;
            break;
        default:
            break;
        }

        if (santonex < 0 || santoney < 0 || santonex >= size || santoney >= size)
        {
            traviato = true;
        }
    }
    return libri;
}

int main()
{
    bool rajasthan[][size] = {
        {false, false, false, true, false, false, true, false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, true, false, false, false, false, false, false, true},
        {true, true, false, false, false, false, false, false, true, false, false, true, false, true, false},
        {false, false, false, true, false, false, true, false, true, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
        {false, false, false, false, true, false, false, false, false, false, true, false, false, false, false},
        {true, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
        {false, false, true, false, true, false, false, false, false, true, true, false, false, false, false},
        {false, false, false, true, false, true, false, false, false, false, false, false, true, false, false},
        {false, true, false, false, false, false, false, false, false, false, false, false, false, false, true},
        {false, true, false, false, false, false, false, false, false, true, false, false, false, false, false},
        {false, true, false, true, true, false, false, true, false, false, false, true, false, false, false},
        {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
        {true, false, false, false, true, false, false, false, false, false, false, false, false, false, false},
        {false, false, false, false, false, false, false, false, false, false, true, false, false, false, false}};

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            cout << rajasthan[i][j] << " ";
        }
        cout << endl;
    }

    int libri = raccoltaLibri(rajasthan);
    cout << "Libri raccolti: " << libri << endl;

    return 0;
}