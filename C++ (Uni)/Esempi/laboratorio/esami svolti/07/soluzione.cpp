#include<iostream>
#include<cmath>
#include<typeinfo>
#include<cstdlib>
#include<sstream>

using namespace std;

class MyDouble {
	private:
		double x;
	public:
		MyDouble(float _x) : x(_x) {}
		int trunc() {
			return x;
		}

		MyDouble operator^(MyDouble &op) {
			return MyDouble(pow(x,op.x));
		}

		bool operator>(MyDouble &op) {
			return x>op.x;
		}

		ostream& put(ostream &stream) const {
			stream << x;
			return stream;
		}
};

ostream &operator<<(ostream &stream, const MyDouble &d) {
		return d.put(stream);
}


class A {
	private:
		float w;
	protected:
		static int const dim = 4;
		MyDouble *mat[dim][dim];
	public:
		A(double _w) : w(_w) {
			for(int i=0; i<dim; i++)
				for (int j=0; j<dim; j++)
					mat[i][j] = new MyDouble((w*10)+i+j);
		}

		virtual double f() const = 0;

		virtual string classname() const {
			return "A";
		}

		virtual ostream &put(ostream &stream) const {
			stream << "class "<< classname() << ": \tw="<<w;
			return stream;
		}
};

ostream &operator<<(ostream &str, const A &a) {
		return a.put(str);
}

class B : public A {
	public:
		B(double _w) : A(_w) {}
		double f() const {
			int somma = 0;
			for(int j=0; j<dim; j++)
				somma += mat[0][j]->trunc();
			return somma;
		}
		
		virtual string classname() const {
			return "B";
		}
		
		virtual ostream &put(ostream &stream) const {
			A::put(stream);
			stream << "\tf()="<<f();
			return stream;
		}
};

template<typename T>
class C : public A {
	private:
		T c;
	public:
		C(double _w, T _c) : A(_w), c(_c) {}
		double f() const {
			MyDouble a(5.0);
			int contatore = 0;
			for(int i=0; i<dim; i++)
				for(int j=0; j<dim; j++)
					if(*mat[i][j]>a)
						contatore++;
			return contatore;
		}

		MyDouble f(T p) const {
			if(typeid(T)==typeid(double))
				return MyDouble(p);
			else
				return (*mat[0][0])^(*mat[dim-1][dim-1]);
		}
		
		virtual string classname() const {
			if(typeid(T)==typeid(int)) {
				return "C<int>";
			} else if(typeid(T)==typeid(double)){
				return "C<double>";
			} else
				return "C<"+string(typeid(T).name())+">";
		}
		
		virtual ostream &put(ostream &stream) const {
			A::put(stream);
			stream << "\tc="<<c<< "\tf()="<<f()<<"\tf(3)="<<f(3);
			return stream;
		}
};


int main() {
	const int DIM = 30;
	A *vett[DIM];

	double sum = 0;
	MyDouble d(0); 
	int d_indice=0;
	bool d_found = false;

	srand(328832748);
	for(int i=0; i<DIM; i++){
		double x=rand()/(double)RAND_MAX;
		rand();
		switch(rand()%3) {
			case 0: vett[i] = new B(x);
					break;
			case 1: vett[i] = new C<double>(x,rand()/(double)RAND_MAX);
					break;
			case 2: vett[i] = new C<int>(x,(int)(x*10));
		}

		cout << i << ")" << *vett[i]<<endl;
		sum+=vett[i]->f();

		if(!d_found && typeid(*vett[i])==typeid(C<int>)) {
			d_indice = i;
			d=( (C<int>*) vett[i] )->f(3);
			d_found = true;
		}
	}

	cout << "punto 1: sum="<<sum<<"\t punto 2: f(3)="<<d<<" di indice "<<d_indice<<endl;

}
