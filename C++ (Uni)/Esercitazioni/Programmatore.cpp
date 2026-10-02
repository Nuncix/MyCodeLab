#include <iostream>
#include <fstream>

using namespace std;

// Create a program that write a file with a program
// written in c++ and then compile it and run it.

int main()
{
    ofstream file;
    system("mkdir programmed");
    file.open("programmed/program.cpp");
    file << "#include <iostream>" << endl;
    file << "using namespace std;" << endl;
    file << "int main()" << endl;
    file << "{" << endl;
    file << "    cout << \"Hello World!\" << endl;" << endl;
    file << "    return 0;" << endl;
    file << "}" << endl;
    file.close();
    system("g++ programmed/program.cpp -o programmed/program");
    system("./programmed/program");
    return 0;
}