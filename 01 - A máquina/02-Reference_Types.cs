void First()
{
  // MyClass cl = new();
  AnotherClass cl = new();
}

First();

class MyClass
{
  public long A;
  public long B;  
}

class AnotherClass
{
  public MyClass A = new();
  public long B;
}

/*
------------------- usando MyClass cl = new(); --------------------

Com já visto antes a Stack vai seguir padrão para alocar as váriaveis locais em pilha, como são duas ao mesmo tempo
ela vai colocar na pilha juntas.

Seguindo a regra, estamos criando uma nova instância da nossa classe, então isso é uma alocação no HEAP, um novo espaço dedicado,
e dentro desse espaço é onde nossos dois LONG ficam.

Mas como vou saber quais são as váriaveis da STACK que são da minha classe? Ai que entra, nós criamos uma referência:
  MyClass cl = new();
Ou seja, eu sei que os dados na Stack contém uma referência da classe alocada na Heap.

deu para entender isso?

Essa referência custa 4 bytes em um sistema de 32 bits e 8 bytes em um sistema de 64 bits.


------------------- usando | AnotherClass cl = new(); --------------------
E agora, como vai ficar isso né? Vai dar uma confusão, mas vamos segui8ndo as linhas

Assim que chamamos First, ele instãncia e consegue um lugar no nosso Heap para armazenar a AnotherClass e os campos contidos nela.
E na Stack ele vai referenciar as váriaveis locais que já foram criadas, tendo a referência CL para os campos contidos no AnotherClass.

Mas pera, entendi que alocamos para o AnotherClass, mas temos uma instância dentro dela tbm, oq acontece agr?
public MyClass A = new();

É criado uma outra alocaçao na memória Heap e guarda os campos contidos - então dois lugares na memória HEAP estão sendo usados.
Como está referenciando A no campo de anotherClass, dentro desse campo vai ter um ponteiro uma refferência para os campos

Entendeu? ele vais se conectando, e surgindo, se tivesse mais um seria a mesma coisa.

Cada uma dessas alocações no HEAP conte'm dados adicionais. Ela não vai armazenar somente os dois LONG que tem dentro dela, ela tambem
vai coanter um HEADER que é basicamente para armazenar informações de herança, informações de bloqueio etc....

- Esses cabeçalhos tem 16 bytes cada, então reprensta uma sobrecarga considerável em cada classe, mas estão lá e vale a pena saber disso
quando eu quero analisar a performance do meu software.
*/


ClassExample teste = new();
ClassExample teste2 = new();

class ClassExample
{
  public int A;
}

/*
E agora, o que acontece aqui?, bom eu criei uma alocaçao na HEAP para minha class
e referenciei as váriaveis locais na minha STACK

mas eu estou chamando a referencia e referenciando ela denovo, então basicamente eu fiz uma cópia com uma referencia
se eu alterar ago na ClassExample ela vai acabar alterando as duas referências
*/