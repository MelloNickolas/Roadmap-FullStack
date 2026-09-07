void First()
{
  int a = 5;
  Console.WriteLine(a);
  Second();  // Váriavel B é alocada logo acima da váriavel A aqui.
}

void Second()
{
  int b = 5;
  Console.WriteLine(b);
}

First();

/*
Vamos entender como as váriaveis são alocadas aqui:

Assim que chamamos o método First e ele cria a váriavel A, ela vai ser alocada no primeiro lugar da pilha.
Logo após isso, ele chama o SECOND, que vai criar a váriavel B alocando ela acima da váriavel A, ficanod na seguinte visão:

------
Stack
- A
- B
------

Se dermos um POP aqui, ele vai deletar a váriavel B que está por primeiro, deu para entender isso?
É assim que os métodos funcionan

*/