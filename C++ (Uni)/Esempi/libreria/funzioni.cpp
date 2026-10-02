#include <iostream>
#include <string>
#include "./lib.h"

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

/*
Compilazione libreria(da cartella Esempi):
    g++ -c libreria/lib.cpp
    &&
    g++ libreria/lib.o libreria/funzioni.cpp -o funzioni
*/

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