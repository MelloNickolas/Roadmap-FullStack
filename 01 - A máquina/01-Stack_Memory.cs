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
É assim que os métodos funcionan, pensa que quando cvocê chama um método você chama pelo PUSH e um POP ao retornar de um método.

*/




void First2Variables()
{
  int a = 5;
  if (Console.ReadLine() is not null){
    int b = 10;
  }
}

/*
Quando uma única função é criada com 2 variaveis locais dentro dela, elas vão ser armazenadas na pilha
e alocadas assim que essa função ser chamada. 

além disso temos um erro que acontece quando temos problemas com chamadas recursivas etc... chamada

STACKOVERFLOWEXCEPTION
é basciamente quando você chama tantas funções, que empilham tantos dados na STACK que a preenchemos completamente.
*/