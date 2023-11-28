// See https://aka.ms/new-console-template for more information
/*public class Veiculo{
    public string Cor { get; set; }
    public string Ano { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string cor, string Ano, string Modelo) {
        this.Cor = cor;
        this.Ano = Ano;
        this.Modelo = Modelo;
    }

    static void Main(){
        Veiculo veiculo = new Veiculo("Amarelo", "1999", "Novo");
        System.Console.WriteLine($"Informações do veiculo{veiculo.Cor} {veiculo.Ano} {veiculo.Modelo}");
    }
}


public class ContaBancaria{
    private double Saldo; 

    public double _saldo{
        get{ return Saldo;}
        set{
        if (value < 0)
            {
                throw new ArgumentException("Saldo nao pode ser negativo");
            }else{
                Saldo = value;}
        }
    }
}*/

public class Aluno{
    public string Nome { get; set; }
    public string Idade { get; set; }

    public Aluno() { 
        this.Nome = "Leane";
        this.Idade = "24";    
    }
    static void Main(){
        Aluno aluno = new Aluno();
        Console.WriteLine($"Informações do aluno:  {aluno.Nome} {aluno.Idade}");
    }
}

public class Agenda{
    List<>
}