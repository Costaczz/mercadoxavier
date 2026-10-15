using System;

class EstoqueMercado
{
    static string[] produtos
    public static void MenuEstoque = meu string[10]
  public static void MenuEstoque()

  int opcaoEstoque;
{
 Console.WriteLine("---MENU ESTOQUE---");
 Console.WriteLine("(1) Listar produtos");
 Console.WriteLine("(2) Adicionar produtos");
 Console.WriteLine("(3) Remover produtos");
 Console.WriteLine("Opcao Escolhida: ");
   opcaoEstoque = int.Parse(Console.ReadLine());

if(opcaoEstoque == 1)
{
   listaProdutos();
}
else if (opcaoEstoque == 2)
{
    adicionarProdutos();
}
else if(opcaoEstoque == 3)
{
    removerProdutos();
}
else
{
   Console.WriteLine("Opcao invalida!")
}

}

public static string adicionarProdutos()
{
    string novoProduto;
    string[] produtoEstoque - new string[10];

Console.WriteLine("--- ADICIONAR PRODUTOS ---");
Console.WriteLine("digite um produto para adicionar ao estoque");
  novoProduto = (Console.ReadLine());

  for(int 1 = 0; i < produtoEstoque.Length; i++)
  {
    produtoEstoques[i] - novoProduto
  }

   return produtoEstoque;
}
}







