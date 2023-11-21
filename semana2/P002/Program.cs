using System;
using System.Collections.Generic;

public class Tarefa
{
    private string titulo;
    private string descricao;
    private DateTime dataVencimento;
    private bool entConclusao;

    public Tarefa(string titulo, string descricao, DateTime dataVencimento, bool entConclusao)
    {
        this.titulo = titulo;
        this.descricao = descricao;
        this.dataVencimento = dataVencimento;
        this.entConclusao = entConclusao;
    }

    public string GetTitulo()
    {
        return this.titulo;
    }

    public string GetDescricao()
    {
        return this.descricao;
    }

    public DateTime GetDataVencimento()
    {
        return this.dataVencimento;
    }

    public bool GetConclusao()
    {
        return this.entConclusao;
    }

    public void setConfConclusao(bool conclusao)
    {
        this.entConclusao = conclusao;
    }

    public void Print()
    {
        Console.WriteLine($"Título: {this.titulo}");
        Console.WriteLine($"Descrição: {this.descricao}");
        Console.WriteLine($"Data de Vencimento: {this.dataVencimento}");
        Console.WriteLine($"Concluída: {this.entConclusao}");
    }
}

public class App
{
    private List<Tarefa> Tarefas = new List<Tarefa>();

    private void CriarTarefa()
    {
        Console.WriteLine("Digite um título para a tarefa: ");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite uma descricao para a tarefa: ");
        string descricao = Console.ReadLine();

        Console.WriteLine("Digite um dia de vencimento para a tarefa: ");
        int dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um mes de vencimento para a tarefa: ");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um ano de vencimento para a tarefa: ");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Tarefa ja concluida? s para SIM / n para NAO ");
        string recConclusao = Console.ReadLine();

        bool entConclusao = recConclusao == "s";

        DateTime data = new DateTime(ano, mes, dia);
        Tarefa tarefa = new Tarefa(titulo, descricao, data, entConclusao);
        this.Tarefas.Add(tarefa);
    }

    private void ListarTodos()
    {
        for (int i = 0; i < Tarefas.Count; i++)
        {
            Console.WriteLine($"Tarefa número: {i + 1}:");
            Console.WriteLine($"Título: " + Tarefas[i].GetTitulo());
            Console.WriteLine($"Descrição: " + Tarefas[i].GetDescricao());
            Console.WriteLine($"Data de Vencimento: " + Tarefas[i].GetDataVencimento());
        }
    }

    private void ListarConcluidas()
    {
        Console.WriteLine("Tarefas concluidas: ");
        foreach (Tarefa t in this.Tarefas)
        {
            if (t.GetConclusao())
            {
                t.Print();
            }
        }
    }

    private void ListarNaoConcluidas()
    {
        Console.WriteLine("Tarefas nao concluidas: ");
        foreach (Tarefa t in this.Tarefas)
        {
            if (!t.GetConclusao())
            {
                t.Print();
            }
        }
    }

    private void AlterarConclusao()
    {
        this.ListarTodos();
        Console.WriteLine("Digite o numero que deseja alterar conclusao ");
        int num = int.Parse(Console.ReadLine());
        this.Tarefas[num].setConfConclusao(!this.Tarefas[num].GetConclusao());
    }

    private void ExcluirTarefa()
    {
        this.ListarTodos();
        Console.WriteLine("Digite o numero que deseja excluir ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0 && num < this.Tarefas.Count)
        {
            this.Tarefas.RemoveAt(num);
            Console.WriteLine("Tarefa removida com sucesso.");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido. Nenhuma tarefa removida.");
        }
    }

    private void Pesquisar()
    {
        Console.WriteLine("Digite uma palavra chave ");
        string palavraChave = Console.ReadLine();
        foreach (Tarefa t in this.Tarefas)
        {
            if (t.GetTitulo().Contains(palavraChave) || t.GetDescricao().Contains(palavraChave))
            {
                t.Print();
            }
        }
    }

    private void Estatisticas()
    {
        int concluidas = 0;
        int naoConcluidas = 0;

        foreach (Tarefa t in this.Tarefas)
        {
            if (t.GetConclusao())
            {
                concluidas++;
            }
            else
            {
                naoConcluidas++;
            }
        }

        Console.WriteLine($"Total de tarefas: {this.Tarefas.Count}");
        Console.WriteLine($"Tarefas concluídas: {concluidas}");
        Console.WriteLine($"Tarefas não concluídas: {naoConcluidas}");
    }

    public void Menu()
    {
        int escolha;

        do
        {
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1 - Criar Tarefa");
            Console.WriteLine("2 - Listar Todas as Tarefas");
            Console.WriteLine("3 - Listar Tarefas Concluídas");
            Console.WriteLine("4 - Listar Tarefas Não Concluídas");
            Console.WriteLine("5 - Alterar Conclusão de uma Tarefa");
            Console.WriteLine("6 - Excluir Tarefa");
            Console.WriteLine("7 - Pesquisar Tarefa por Palavra-Chave");
            Console.WriteLine("8 - Estatísticas");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    CriarTarefa();
                    break;
                case 2:
                    ListarTodos();
                    break;
                case 3:
                    ListarConcluidas();
                    break;
                case 4:
                    ListarNaoConcluidas();
                    break;
                case 5:
                    AlterarConclusao();
                    break;
                case 6:
                    ExcluirTarefa();
                    break;
                case 7:
                    Pesquisar();
                    break;
                case 8:
                    Estatisticas();
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

    public static void Main(string[] args)
    {
        App aplicativo = new App();
        aplicativo.Menu();
    }
}