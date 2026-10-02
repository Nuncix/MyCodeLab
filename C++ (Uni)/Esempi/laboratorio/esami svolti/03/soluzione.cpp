#include<iostream>
#include<stdlib.h>
#include <typeinfo>

using namespace std;

class A {
	private:
		string x;
	public:
		A(string str) : x(str) {}
		string getX() {return x;}
		virtual string select() = 0;
		bool moreThan3() {
			for(int i=0; i<x.length(); i++) {
				int contatore = 1;
				for (int j=i+1; j<x.length(); j++) {
					if (x[i]==x[j]) contatore++;
				}
				if (contatore>=3) return true;
			}
			return false;
		}

		virtual ostream& put(ostream &stream) const{
			stream << "{ x=\"" << x <<"\" ";
			return stream;
		}
};

ostream &operator <<(ostream &stream, const A &a) {
	return a.put(stream);
}

class B : public A {
	private:
		string y;
		float f;
	public:
		B(string s, float _f) :
				A(s.substr(0,10)), 
				y(s.substr(10)), 
				f(_f) {}
		char extract () {
			int i = (int) ((f-(int)f)*10);
			return y[i];
		}

		string select() {
			string x = getX();
			string xy = (x+y);
			string r = "";
			for (int i=0; i<xy.length(); i++) {
				if (xy[i] == 'a' || xy[i] == 'e' 
				|| xy[i] == 'i' || xy[i] == 'o' 
				|| xy[i] == 'u' || xy[i] == 'A'
				|| xy[i] == 'E' || xy[i] == 'I'
				|| xy[i] == 'O' || xy[i] == 'U') {
					r += xy[i];
				}
			}
			return r;
		}
		ostream& put(ostream &stream) const{
			A::put(stream);
			stream << "y=\"" << y <<"\" f=\"" << f <<"\" }";
			return stream;
		}
};

class C : public A {
	private:
		short *b;
		short n;
	public:
		C(string s) : A(s.substr(0,10)), n(s.length()) {
			b = new short[n];
			for (int i=0; i<n; i++) {
				b[i] = s[i] % 5;
			}
		}

		string select() {
			string r = "";
			string x = getX();
			for (int i=0; i<x.length(); i++) {
				bool x_in_b = false;
				for (int j=0; j<n; j++) {
					if (i==b[j])
						x_in_b=true;
				}
				if (x_in_b) {
					r+=x[i];
				}
			}
			return r;
		}
		
		ostream& put(ostream &stream) const{
			A::put(stream);
			stream << "b=[ ";
			for (int i=0; i<n; i++) {
				stream << b[i] << " ";
			}
			stream << "] }";
			return stream;
		}
};

int main() {
		int DIM = 50;
		A *vett[DIM];

		//punto 0
		srand(111222333);
		for (int i=0; i<DIM; i++) {
				string str = "";
				for (int j=0; j<20; j++) 
					str += (char) ('a' + rand()%12);
				if (rand()%2==1) 
					vett[i]=new B(str, (float)rand()/RAND_MAX);
				else 
					vett[i]=new C(str);

				cout << *vett[i] << endl;
		}

		cout << "\t select ----> " << vett[13]->select() << vett[48]->select() << endl;

		//punto 1
		for (int i=0; i<DIM; i++) 
			if (vett[i]->moreThan3()) cout << i << " ";
		cout << endl;

		string stringa = "";

		for (int i=0; i<DIM; i++) {
			if(typeid(*vett[i])==typeid(B)) {
				stringa+=((B*) (vett[i]))->extract();
			}
		}

		cout << stringa << endl;
		
}
