
namespace Namespace;
public class Treinador
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

    public string CREF { get; set;}

    public Treinador(string Nome, DateTime DtNascimento, string Cpf, string Cref)
    {
        this.Nome = Nome;
        this.DtNascimento = DtNascimento;
        this.Cpf = Cpf;
        this.CREF = CREF;
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
