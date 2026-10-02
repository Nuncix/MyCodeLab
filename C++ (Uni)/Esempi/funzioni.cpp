#include <iostream>

using namespace std;

/*
tipo_in_uscita nome_funzione(tipo_in_input1, tipo_in_input2, ...)
{
    ...
    codice_funzione;
    ...

    return tipo_in_uscita;
}
*/

int somma(int, int); // int somma(int a, int b)

int pow(int base, int esponente = 2);

void print(string);

int main()
{
    int x = somma(2, 3);
    {
        int y = x + 2;
        cout << y << endl;
    }
    cout << x << endl;
    //cout << y << endl; //!ERRORE - y non è definito

    int z = 8;
    int y = somma(x, z);
    cout << y << endl;

    print("hello world");

    cout << pow(2, 3) << endl; //stampa 8
    cout << pow(2) << endl;    //stampa 4
    cout << pow(2, 4) << endl; //stampa 16
}

int somma(int a, int b)
{
    return a + b;
}

int pow(int base, int esponente)
{
    int prodotto = 1;
    for (int i = 0; i < esponente; i++)
    {
        prodotto *= base;
    }
    return prodotto;
}

void print(string s) // void: non restituisce nulla
{
    cout << s << endl;
    return;
    cout << "Non mi restituisce nulla" << endl;
}
