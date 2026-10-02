#include<iostream>
#include<cstdlib>
#include<typeinfo>

using namespace std;

class A {
	private:
		string s;
	public:
		A(string _s) : s(_s) {}
		string getS() {
			return s;
		}
		
		virtual bool doppia()  {
			for(int i=0; i<s.length(); i++)
				for(int j=i+1; j<s.length(); j++)
					if(s[i]==s[j])
						return true;
			return false;
		}

		virtual string nuova() = 0;

		virtual ostream& put(ostream& stream) const{
			stream << "s=\""<<s<<"\"";
		}

};

ostream& operator<<(ostream& stream, const A &a) {
		return a.put(stream);
}

class B : public A {
	private:
		int y;
	public:
		B(string s, int _y) : A(s), y(_y) {}

		bool doppia() {
			string s = getS();
			for(int i=0; i<s.length(); i++)
				if(s[i]=='a' || s[i]=='e'|| 
				   s[i]=='i' || s[i]=='o'|| 
				   s[i]=='u' || s[i]=='A'|| 
				   s[i]=='E' || s[i]=='I'|| 
				   s[i]=='O' || s[i]=='U')
						for(int j=i+1; j<s.length(); j++)
							if(s[i]==s[j])
								return true;
			return false;
		}

		string nuova() {
			string s = getS();
			if(y%3==0)
				return s.substr(s.length()-3);
			else
				return s.substr(0,3);
		}
		
		ostream& put(ostream& stream) const{
			return A::put(stream) << " y=" << y;
		}
};

class C : public A {
	protected:
		char c;
	public:
		C(string s, char _c) : A(s), c(_c) {}
		string nuova() {
			string s = getS();
			for (int i=1; i<s.length(); i++)
				s[i]='*';
			return s;
		}
		
		ostream& put(ostream& stream) const{
			return A::put(stream) << " c='" << c<<"'";
		}
};

class D : public C {
	public:
		D(string s, char c) : C(s,c) {}
		string nuova(short x) {
			string out = "";
			out+=c;

			string s = getS();

			for (int i=0; i<x; i++)
				out+= (char) (s[i]+1);

			return out;
		}	
};

int main() {
		const int DIM = 30;
		A* vett[DIM];

		string nuova = "";
		string nuova3 = "";
		int doppi = 0;

		srand(111222333);
		for (int i=0; i<DIM; i++) {
				int p = rand()%5+3;
				string str = "";
				for (int j=0; j<p; j++)
						str += (char) ('a' + rand()%26);

				if (rand()%2==1)
						vett[i] = new D(str, (char) ('a' + rand()%26));
				else 
						vett[i] = new B(str, rand()%15);

				cout << *vett[i] << endl;

				nuova += vett[i]->nuova().substr(0,2);

				if(typeid(*vett[i])==typeid(D))
						nuova3 += ((D*) vett[i])->nuova(3).substr(0,3);

				if(vett[i]->doppia())
						doppi++;
		}

		cout << "nuova()=\""<<nuova<<"\""<<endl;
		cout << "nuova(3)=\""<<nuova3<<"\""<<endl;
		cout << "doppi="<<doppi<<endl;
}
