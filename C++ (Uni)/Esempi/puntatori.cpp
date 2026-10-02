#include <iostream>

using namespace std;

void puntatore()
{
    int num = 25;  // numero intero
    int k = 20;    // k è un patore a int
    int *p = &num; //dichiara patore a intero
    *p = 34;       //assegna 10 al dato pato da patore
    p = &k;        //assegna ad patore indirizzo di 20

    //funzione che stampa patore
    cout << "Il valore di *p è: " << *p << endl;
    cout << "Il valore di p è: " << p << endl;
}

void puntaArray()
{
    double v[] = {1.2, 10.7, 9.8}; //dichiara array di double
    cout << v << endl;             // stampa indirizzo di v
    cout << *v << endl;            // stampa il primo elemento di v
    cout << v[0] << endl;          // stampa il primo elemento di v

    double *ptr = v;        //dichiara puntatore a double
    cout << ptr[1] << endl; // stampa il secondo elemento di v
    cout << ptr[2] << endl; // stampa il terzo elemento di v

    //aritmetica di puntatori
    cout << ptr << endl;        //stampa indirizzo di ptr
    cout << *(ptr + 1) << endl; // stampa il secondo elemento di v
    cout << *(ptr + 2) << endl; // stampa il terzo elemento di v
    cout << *(v + 2) << endl;   // stampa il terzo elemento di v

    double w[] = {3.4, 6.7, 9.8};
    // !ERRORE v = w;
}

void aritmeticaPuntaArray()
{
    int v[] = {1, 2, 3, 4, 5}; // array di interi
    int *ptr = v;              // puntatore a interi
    cout << *(++ptr) << endl;  // stampa il secondo elemento di v
    cout << *(--ptr) << endl;  // stampa il primo elemento di v
    cout << *(ptr++) << endl;  // stampa il primo elemento di v
    cout << *(ptr) << endl;    // stampa il secondo elemento di v

    //addizione,sottrazione e assegnamento
    int *ptr1 = v;               // puntatore al dato ''1''
    int *ptr2 = &v[4];           // puntatore al dato ''5''
    cout << *(ptr1 + 1) << endl; // stampa il secondo elemento di v
    cout << *(ptr2 - 1) << endl; //stampa il primo elemento di v
    ptr2 -= 2;                   // decrementa di 2 il puntatore
    cout << *ptr2 << endl;       //stampa il terzo elemento di v
    ptr1 += 1;                   // incrementa di 1 il puntatore
    cout << *ptr1 << endl;       //stampa il secondo elemento di v
    cout << ptr2 - ptr1 << endl; //stampa 1 (non è un dato)

    // !ERRORE *(ptr+7)=90;
    // !ERRORE v[4]=100;
}

void initPuntatori()
{
    int *ptr = NULL;     // Macro C/C++
    int *ptr1 = nullptr; // C++11

    float f;
    // int *ptr3 = &f; // !ERRORE di compilazione!

    if (!ptr) // Controlla se ptr è valido
    {
        // ...
    }
}

void valVsPtr() // Differenza tra valori e puntatori
{
    int num;
    int *ptr1 = &num; // Puntatore a intero
    int *ptr2 = &num; // Puntatore a intero

    if (ptr1 == ptr2) // Controlla indirizzi
    {
        // ...
    }

    if (*ptr1 == *ptr2) // Controlla valori
    {
        // ...
    }
}

void constPtr() //puntatori costanti puntatori a costanti
{
    double d1 = 10.9;
    double d2 = 4.5;

    const double *ptr1 = &d1;
    ptr1 = &d2; // OK
    // !ERRORE *ptr1 = 56.9;

    double *const ptr2 = &d2;
    // !ERRORE ptr2 = &d1;
    *ptr2 = 10.5;

    const double *const ptr3 = &d2;
    // !ERRORE ptr3 = &d1;
    // !ERRORE *ptr3 = 10.5;
}

void furnari()
{
    int x = 5;
    cout << x << endl;
    cout << &x << endl;

    int *xPtr = &x;

    cout << xPtr << endl;

    // int *ptr = NULL;
    int *null_ptr = nullptr;
    // int *ptr = 0;

    cout << null_ptr << endl;

    cout << *null_ptr << endl;

    // xPtr: int* (puntatore a intero)
    // *xPtr: int (intero)
    // x: int (intero)
    // &x: int* (indirizzo di x)

    *xPtr = 10;
    cout << x << endl;
    // cout << *null_ptr << endl; //!ERRORE: *null_ptr è null

    int a = 2;
    int b = 3;

    int *a_ptr = &a;
    int *b_ptr = &b;

    cout << (a == b) << endl;         //stampa 0
    cout << (a_ptr == b_ptr) << endl; //stampa 0

    b_ptr = &a;
    cout << (a_ptr == b_ptr) << endl;   //stampa 1
    cout << (*a_ptr == *b_ptr) << endl; //stampa 1

    int aa = 2;
    int bb = 2;
    int *ptr_aa = &aa;
    int *ptr_bb = &bb;

    cout << (aa == bb) << endl;         //stampa 0
    cout << (ptr_aa == ptr_bb) << endl; //stampa 0

    int var = 8;
    const int *ptr_var = &var; //(const int)*

    cout << *ptr_var << endl; //stampa 8
    cout << ptr_var << endl;  //stampa 0x7fff5fbffd80

    // *ptr_var = 10; //!ERRORE: è un puntatore costante

    int var2 = 7;
    int *const ptr_var2 = &var2; // (int)* const

    cout << *ptr_var2 << endl; //stampa 7
    *ptr_var2 = -2;
    cout << var2 << endl; //stampa -2

    // ptr_var2 = null_ptr //!ERRORE: ptr_var2 è un puntatore costante

    int var3 = -9;
    const int *const ptr_var3 = &var3; // (const int)* const

    cout << *ptr_var3 << endl; //stampa -9
    // *ptr_var3 = 10; //!ERRORE: è un puntatore costante
    // ptr_var3 = null_ptr //!ERRORE: ptr_var3 è un puntatore costante
}

void furnariArray()
{
    int x[5] = {1, 2, 3, 4, 5}; // puntatore costante

    cout << x << endl;    //stampa indirizzo di memoria
    cout << x[0] << endl; //stampa 1
    cout << *x << endl;   //stampa x[0]

    cout << (x + 1) << endl; //stampa indirizzo di x[1]

    int *ptr = 0;
    cout << ptr << endl;       //stampa 0
    cout << (ptr + 1) << endl; //stampa il prossimo intero in memoria

    cout << *(x + 1) << endl; //stampa x[1]->(x+i1) <-> x[i]->(x+i)
}

void furnariPtrToPtra()
{

    cout << endl
         << "furnariPtrToPtra:" << endl;
    int x = 5;
    int *x_ptr = &x;
    int **x_ptr_ptr = &x_ptr;

    cout << x << endl;         // stampa 5
    cout << x_ptr << endl;     // stampa indiirizzo di x
    cout << x_ptr_ptr << endl; //stampa indirizzo di x_ptr

    cout << *x_ptr_ptr << endl;  //stampa indirizzo di x_ptr
    cout << **x_ptr_ptr << endl; //stampa 5
}

int main()
{
    // puntatore();
    // puntaArray();
    // aritmeticaPuntaArray();
    //furnari();
    furnariArray();
    furnariPtrToPtra();
    return 0;
}