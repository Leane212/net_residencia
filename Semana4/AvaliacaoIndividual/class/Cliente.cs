using System.Reflection;

namespace Namespace;
public class Cliente
{
    public string Nome { get; set;}
    public DateTime DtNascimento { get; set;}
    public string Cpf{
        get{ return Cpf;}
        set{
        if (value.Length < 11 || value.Length >11)
            {
                throw new ArgumentException("O Cpf deve conter 11 numeros");
            }else{
                Cpf = value;}
        }
    }
    public double Altura {
        get{ return Altura;}
        set{ 
            if (value < 0)
            {
                throw new ArgumentException("Altura nao pode ser negativo");
            }else{
                Altura= value;}
        }
    }

    public double Peso{
        get{ return Peso;}
        set{
            if (value < 0)
            {
                throw new ArgumentException("Peso nao pode ser negativo");
            }else{
                Peso = value;}
        }
    }
    
    public Cliente(string Nome, DateTime DtNascimento, string Cpf, double Altura, double Peso)
    {
        this.Nome = Nome;
        this.DtNascimento= DtNascimento;
        this.Cpf= Cpf;
        this.Altura = Altura;
        this.Peso = Peso;   
    }
    
    public void GetData(){
        if(this.DtNascimento < DateTime.Now){
            int resultado = CalculaIdade ();
        } else{
            Console.WriteLine("Data invalida");
        }

    }

    public int CalculaIdade(){
        int idade = DateTime.Now.Year - DtNascimento.Year;
        if(DateTime.Now.DayOfYear < DtNascimento.DayOfYear){
            idade = idade -1;
        }
        return idade;
    }
}
