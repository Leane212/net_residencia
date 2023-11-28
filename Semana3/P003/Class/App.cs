using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace P003;

public class App
{
    private List<(string Codigo, string Nome, int Quantidade, double Preco)> Produtos = new List<(string, string, int, double)>();

    private void CadastroProduto(){
        Console.WriteLine("Digite o codigo do produto");
        string codigo = Console.ReadLine()!;
        Console.WriteLine("Digite o nome do produto");
        string nome = Console.ReadLine()!;
    
        int quantidade;
        while (true){
            Console.WriteLine("Digite a quantidade do produto");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 0){
                break;
            }
            else{
                Console.WriteLine("Digite um valor inteiro nao negativo.");
            }
        }
    
        double preco;
        while (true){
            Console.WriteLine("Digite o preço do produto");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out preco) && preco >= 0){
                break;
            }
            else{
                Console.WriteLine("Digite um valor numerico nao negativo.");
            }
        }

        this.Produtos.Add((Codigo: codigo, Nome: nome, Quantidade: quantidade, Preco:preco));
        Console.WriteLine("Produto cadastrado!!");

    }

    private void ConsultaPeloCodigo(){
        Console.WriteLine("Digite o codigo do produto");
        string codigo = Console.ReadLine()!;

        var produto = this.Produtos.Find(x => x.Codigo == codigo);
        if (produto != default){
            Console.WriteLine($" Codigo: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
        else{
           Console.WriteLine("Produto não encontrado.");
        }
    }

    private void AtualizaEstoque(){
        Console.WriteLine("Digite o codigo do produto que deseja atualizar");
        string codigo = Console.ReadLine()!;

        Console.WriteLine("1 - Atualizar entrada");
        Console.WriteLine("2 - atualizar saida");
        string opcao = Console.ReadLine()!;

        switch(opcao){
            case "1":
                this.AtualizaEntrada(codigo);
                break;
            case "2":
                this.AtualizaSaida(codigo);
                break;
            default:
                Console.WriteLine("Escolha invalida");
                break;
        }
    }

    private void AtualizaEntrada(string codigo){

        Console.WriteLine("Digite o valor de entrada");
        int entrada = int.Parse(Console.ReadLine()!);

        int index = this.Produtos.FindIndex(x => x.Codigo == codigo);
        if (index != -1){
            var prodAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade + entrada, Produtos[index].Preco);
            Produtos[index] = prodAtualizado;
            Console.WriteLine($"Entrada de {entrada} unidades realizada com sucesso! ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Estoque atual: {Produtos[index].Quantidade}");
            Console.WriteLine("-----------------------------------------");
        }else{
    
            throw new Exception($"Produto com codigo {codigo} nao encontrado.");
    }
    }



    private void AtualizaSaida(string codigo){
   
        Console.WriteLine("Digite a quantidade de saida");
        int saida = int.Parse(Console.ReadLine()!);

        var produto = this.Produtos.Find(x => x.Codigo == codigo);
    
        if (produto != default && saida <= produto.Quantidade){
            int index = this.Produtos.FindIndex(x => x.Codigo == codigo);
            var produtoAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade - saida, Produtos[index].Preco);
            Produtos[index] = produtoAtualizado;
            Console.WriteLine($"Saida de {saida} unidades realizada com sucesso!!");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Estoque atual: {produto.Quantidade - saida}");
            Console.WriteLine("-----------------------------------------");

        }else if (produto == default){
            Console.WriteLine($"Produto com código {codigo} não encontrado.");
        }
        else{
            throw new Exception("Saida nao permitida pois o valor de saida eh maior que unidades em estoque!");
        }
    }


    private void ListarProdutoEsto(){
        Console.WriteLine("Informe o limite de quantidade em estoque que deseja verificar: ");
        if (int.TryParse(Console.ReadLine(), out int quantEstoque)){
            var produtosDentrodoLimite = Produtos.Where(x => x.Quantidade < quantEstoque);

            Console.WriteLine("Estes sao os produtos com quantidade abaixo do limite desejado de verificacao:");
            foreach (var produto in produtosDentrodoLimite)
            {
            Console.WriteLine($"Codigo: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
            }
        }else{
                Console.WriteLine("Valor invalido para o limite de quantidade em estoque.");
            }
    }


    private void ListarProdutoMiMax(){
    
        Console.WriteLine("Digite o valor minimo:");
        double minimo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o valor maximo:");
        double maximo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (minimo > maximo){
            throw new Exception("O valor minimo deve ser menor ou igual ao valor maximo.");
        }

        var produtosNesseIntervalo = Produtos.Where(x => x.Preco >= minimo && x.Preco <= maximo);

        Console.WriteLine("Produtos dentro desse intervalo sao:");
        foreach (var produto in produtosNesseIntervalo){
            Console.WriteLine($"Codigo: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }
    }

    private void ListarValorTotal(){
        double valorTotEstoque = Produtos.Sum(x => x.Quantidade * x.Preco);
        Console.WriteLine($"Valor total do estoque: {valorTotEstoque:C}");

        Console.WriteLine("Valores totais por produto:");
        foreach (var produto in Produtos){
            double valorTotProduto = produto.Quantidade * produto.Preco;
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Valor Total: {valorTotProduto:C}");
        }
    }



    public void Menu()
    {
        int escolha;

        do
        {
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1 - Criar Cadastro de Produto");
            Console.WriteLine("2 - Consultar pelo codigo do produto");
            Console.WriteLine("3 - Atualizar estoque de produto");
            Console.WriteLine("4 - Listar produtos com quantidade abaixo de um limite ");
            Console.WriteLine("5 - Listar produtos de acordo com uma faixa de valores");
            Console.WriteLine("6 - Listar valores totais de estoque e de cada produto");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("---Criar Cadastro de Produto---");
                    this.CadastroProduto();
                    break;
                case 2:
                    Console.WriteLine("---Consultar pelo codigo do produto---");
                    this.ConsultaPeloCodigo();
                    break;
                case 3:
                    Console.WriteLine("---Atualizar estoque de produto---");
                    this.AtualizaEstoque();
                    break;
                case 4:
                    Console.WriteLine("---Listar produtos com quantidade abaixo de um limite---");
                    this.ListarProdutoEsto();
                    break;
                case 5:
                    Console.WriteLine("---Listar produtos de acordo com uma faixa de valores---");
                    this.ListarProdutoMiMax();
                    break;
                case 6:
                    Console.WriteLine("---Listar valores totais de estoque e de cada produto---");
                    this.ListarValorTotal();
                    break;
                case 0:
                    Console.WriteLine("Sair do programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (escolha != 0);

    }
}