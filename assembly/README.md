# Assembly

ARM assembly exercises covering low-level data manipulation and basic algorithms.

## Contents

- `bubble_sort.s` implements a sorting exercise.
- `byte.s`, `bytes2.S`, and `strings.S` explore byte and string operations.
- `somma_numeri.s`, `massimo.s`, and `molti_Intera.s` cover numeric operations.
- `prodotto_scalare.s` and `prodotto_scalare2.s` contain scalar-product exercises.
- `cauli.s` is an additional assembly exercise.

## Running the Exercises

Use an ARM assembler or simulator compatible with the syntax of the selected
file. Some exercises use directives such as `DCD` and `END`, so they are not
directly interchangeable with GNU assembler sources or x86 assembly.

Load an exercise into the appropriate ARM environment, assemble it, and inspect
registers and memory while stepping through execution. There is no shared build
script or universal command for all files in this folder.

Keep `.s` and `.S` sources versioned. Object files and compiled executables are
ignored by the repository's root `.gitignore`.
