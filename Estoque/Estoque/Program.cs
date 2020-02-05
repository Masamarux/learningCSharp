using System;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p1);

            Console.WriteLine();//quebra de linha
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qnt);
            Console.WriteLine("Dados atualizados do produto: " + p1);

            Console.WriteLine();//quebra de linha
            Console.WriteLine("Digite o número de produtos a ser removidos do estoque: ");
            int qntR = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qntR);

            Console.WriteLine("Dados atualizados do produto: " + p1);

        }
    }
}
