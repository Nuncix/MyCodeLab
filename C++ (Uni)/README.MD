# C++ University Exercises

C++ examples, lab work, and exercises collected during university courses.
Many source files are standalone programs rather than parts of one application.

## Contents

- [Esempi](Esempi/) contains examples of arrays, pointers, memory allocation,
  functions, overloading, inheritance, and file handling.
- [Esempi/laboratorio](Esempi/laboratorio/) contains object-oriented programming
  exercises and lab material.
- [Esempi/Tutorato](Esempi/Tutorato/) contains tutorial exercises.
- [Esercitazioni](Esercitazioni/) contains practice problems, algorithms, and exam
  exercises, with supporting documents where available.

## Compiling an Example

Use a C++ compiler such as GCC or Clang. From this folder:

```sh
mkdir -p build
g++ -Wall -Wextra Esempi/puntatori.cpp -o build/puntatori
./build/puntatori
```

Compile one exercise at a time. Some examples need additional source files,
a particular language standard, or platform-specific libraries; not every file
has its own `main` function. Paths containing spaces must be quoted in shell commands.

Place executables in `build/` so that generated files remain outside version control.
