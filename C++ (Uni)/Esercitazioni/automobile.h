#include <iostream>
#include <string>
#include "Persona.h"

using namespace std;

class Automobile
{
private:
    string modello;
    Persona &proprietario;

public:
    Automobile(string modello, Persona &p) : proprietario(p)
    {
        this->modello = modello;
    }
    friend ostream &operator<<(ostream &s, Persona p);
    void stampa()
    {
        cout << "Automobile di " << proprietario << endl;
    }
    void set_proprietario(Persona &p)
    {
        proprietario = p;
    }
};

ostream &operator<<(ostream &s, Persona &p)
{
    s << p.nome<<" "<<p.cognome;
    return s;
}

int main()
{
    Persona p1("Mario", "Rossi");
    Persona p2("Giuseppe", "Verdi");
    Automobile a1("Automobile1", p1);
    Automobile a2("Automobile2", p1);
    Automobile a3("Automobile3", p2);
    a2.stampa();
    a2.set_proprietario(p2);
    a2.stampa();
}