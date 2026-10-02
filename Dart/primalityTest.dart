import 'dart:math';

void Eratostene(int x) {
  int i, j, k;
  bool b;
  List<int> tab = List.filled(100, 0);
  for (i = 2; i < x; i++) {
    tab[i] = i;
  }
  for (i = 2; i < sqrt(x); i++) {
    if (tab[i] != 0) {
      for (j = i * i; j < x; j += i) {
        tab[j] = 0;
      }
    }
  }
  for (i = 2; i < x; i++) {
    if (tab[i] != 0) {
      print(tab[i]);
    }
  }
}

bool Prime(int x) {
  if (x < 2) return false;
  if (x == 2) return true;
  if (x % 2 == 0) return false;
  for (int i = 3; i <= sqrt(x); i += 2) {
    if (x % i == 0) return false;
  }
  return true;
}

void main() {
  Random random = new Random();
  for (int i = 0; i < 10; i++) {
    int x = random.nextInt(100);
    print("$x ${Prime(x)}");
  }
  Eratostene(100);
}
