#include<iostream>
#include<locale>
#include<cstdlib>
#include<typeinfo>

using namespace std;

class A {
	private:
		string w;
	public:
		A(string s) : w(s) {}
		int getSum() {
			int accumulatore = 0;
			for (int i=0; i<w.length(); i++) {
				bool trovato = false;
				for (int j=1; j<w.length() && !trovato; j++)
					if(w[i]==w[j])
						trovato = true;
				if(trovato)
					accumulatore += (int) (w[i]);
			}
			return accumulatore+1;
		}

		virtual short* values() = 0;

		virtual ostream &put(ostream &stream) const{
			stream << "Class "<<typeid(*this).name()<<" w=\""<<w<<"\"";
			return stream;
		}
};

ostream & operator<<(ostream &stream, const A &a){
	return a.put(stream);
}

class B : public A {
	private:
		string s;
		int l;
	public:
		B(string s1, string s2, short n) : A(s1.substr(n)+s2.substr(n,s2.length()-n)){
			s="";
			int i=0;
			while(i<s1.length() && i<s2.length()){
				s+=s1[i];
				s+=s2[i];
				i++;
			}
			l = s.length();
		}

		short *values(){
			short *out = new short[l];
			for(int i=0; i<l; i++)
				out[i] = ((short)s[i])%10;
			return out;
		}

		float res() {
			short *array = values();
			short sum = 0;
			for (int i=0; i<l; i++)
				sum+=array[i];
			return (float)sum/getSum();
		}

		ostream& put(ostream &stream) const{
			A::put(stream);
			stream << " s=\""<<s<<"\"";
			return stream;
		}
};

class C : public A {
	private:
		string t;
		int n;
	public:
		C(string s) : A(s) {
			for(int i=0; i<s.length(); i++)
				if(tolower(s[i])==s[i])
					t+=toupper(s[i]);
				else
					t+=tolower(s[i]);
			n=t.length();
		}
		short *values() {
			short *out = new short[n];
			for(int i=0; i<n;i++)
				if(t[i]=='0' || t[i]=='1' || t[i]=='2' || t[i]=='3' || t[i]=='4' || t[i]=='5' || t[i]=='6' || t[i]=='7' || t[i]=='8'|| t[i]=='9')
					out[i]=0;
				else
					out[i]=1;
			return out;
		}
		short zeros() {
			short *array = values();
			int count=0;
			for (int i=0; i<n; i++)
				if (array[i]==0)
					count++;
			return count;
		}
		
		ostream& put(ostream &stream) const {
			A::put(stream);
			stream << " t=\""<<t<<"\"";
			return stream;
		}
};


int main() {
	
	const int DIM = 30;
	A *vett[DIM];

	int values[DIM];
	int n=0;

	for(int i=0; i<DIM; i++){
			string str1 = ""; string str2 = "";
			if(rand()%2==0){
			  short l1 = rand()%5+3; short l2 = rand()%5+6;
			  for(int j=0; j<l1; j++)
			str1+=((char) ('a' + rand()%25));
			  for(int j=0; j<l2; j++)
			str2+=((char) ('a' + rand()%25));
			  short n = rand()%3+1;
			  vett[i] = new B(str1, str2, n);
			}
			else {
			  for(int j=0; j<10; j++){
			int r = rand(); 
			if(r%2==0)
			  str1+=((char) ('0' + rand()%9));
			else if(r%3==0)
			  str1+=((char) ('a' + rand()%25));
			else
			  str1+=((char) ('A' + rand()%25));
			  }
			  vett[i] = new C(str1); 
			}
			
			if(typeid(*vett[i])==typeid(B)) {
				values[n++]=((B*) vett[i])->getSum();
			}

		  	cout << *vett[i]<<endl;
  	}

	int somma = 0;
	int min = values[0];
	int max = values[0];
	
	for (int i=0; i<n; i++){
		somma+=values[i];
		if(values[i]<min) min = values[i];
		if(values[i]>max) max = values[i];
	}



	cout << endl<<"Punto 1. Somma res: " << ((B*)vett[9])->res()+((B*)vett[17])->res()<<endl;

	cout << "Punto 2. Indici per i quali zeros()>=7: ";
	for (int i=0; i<DIM; i++)
		if(typeid(*vett[i])==typeid(C))
			if(((C*)vett[i])->zeros()>=7)
				cout << i<<" ";
	cout << endl;

	cout << "Punto 3. Somma: "<<somma<<" Min: "<<min<<" Max: "<<max<<" Mean: "<<(float)somma/n<<endl;
}
