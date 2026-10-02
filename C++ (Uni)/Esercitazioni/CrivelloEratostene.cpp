#include <iostream>

using namespace std;

int main()
{
    // Algoritmo di erastotene per trovare tutti i primi naturali fino a N
    cout << "Inserisci fino a quale numero trovare i numeri primi: ";
    int N = 0;
    cin >> N;
    bool primi[N + 1];

    // Imposto a true tutti gli elementi tranne 0 e 1 che non sono primi dio maiale
    for (int i = 0; i <= N; i++)
        primi[i] = true;
    primi[0] = false;
    primi[1] = false;

    // Inizio a "setacciare" i numeri primi
    for (int i = 2; i <= N; i++)
    {
        // Se la variabile è true verrà controllata che essa sia un numero primo
        if (primi[i])
        {
            // Vengono settate a false, tutte le variabili la cui posizione è multiplo di i
            for (int j = i * 2; j <= N; j += i)
            {
                primi[j] = false;
            }
        }
    }

    // Stampa dei numeri primi
    for (int i = 0; i <= N; i++)
    {
        if (primi[i])
            cout << i << ("" + (i % 5 == 0) ? " " : "\n");
    }
    cout << endl;

    return 0;
}