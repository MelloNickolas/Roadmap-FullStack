MyStruct s = new();

MyClass cl = new();

struct MyStruct
{
  public long A;
  public long B;
}

class MyClass
{
  public MyStruct S;
}

/*
Aqui é bem mais simples

A struct basicamente está armazenando os dois LONG diretamente na váriavel local na STACK, sem alocar nada no HEAP.


mas espera, entendi que se chamarmos ele direto na Main ele coloca direto lá, mas agora a STRUCT está dentro dea Class e ela está sendo
referenciada, o que acontece aqui?
Ele basicamente vai ter uma alocaçao no HEAP e as váriaveis locais refenciadas dentro da STACK, a STRUCT vai basicamente armazenar
seu conteúdo diretamente dentro da classe, tudo que está dentro do STRUCT vai ser armazenado no CLASS

Eles não estão diretamente na "STACK" elas estão na classe, são direto, sao espaços armazenados e só, sem referencia, sem HEADER, então nao tem herança  
*/