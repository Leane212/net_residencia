
namespace Namespace;
public class App
{
    private List<Treinador> treinador = new List<Treinador>();
    private List<Cliente> clientes= new List<Cliente>();

    public void Execultar(){
        Cliente Cliente1 = new Cliente("Leane", new DateTime(1999,02,25), "077666666545", 1.95, 63.8 );
        Cliente Cliente2 = new Cliente("Theo", new DateTime(1999, 03, 25), "84736543533",1.65, 60.87);
        Cliente Cliente3 = new Cliente("Kay", new DateTime(1998, 02, 11), "87363545654",1.65, 63.5);
        this.clientes.Add((Cliente1));
        this.clientes.Add((Cliente2));
        this.clientes.Add((Cliente3));

        Treinador treinador1 = new Treinador("Caio", new DateTime(1997,02,23), "74653635343", "837763533" );
        Treinador treinador2 = new Treinador("Joao", new DateTime(1989,03,23), "83736353633", "837363533" );
        Treinador treinador3 = new Treinador("Matheus", new DateTime(1994,12,23), "74659835343", "837761133" );
        this.treinador.Add((treinador1));
        this.treinador.Add((treinador2));
        this.treinador.Add((treinador3));
    
    
    }

    private void ConsultaTreinadorEntreValores(){
    
    int idadeMinima = 20;
    int idadeMaxima = 30;

    if (idadeMinima > idadeMaxima)
    {
        Console.WriteLine("Idade mínima deve ser menor que a idade máxima");
        return;
    }

    Console.WriteLine("Mostrando treinadores com idade entre {0} e {1} anos", idadeMinima, idadeMaxima);

    treinador.Where(t => t.CalculaIdade() >= idadeMinima && t.CalculaIdade() <= idadeMaxima);

    foreach (Treinador x in treinador)
    {
        Console.WriteLine(x.Nome);
    
    }

    }

    private void ConsultaClienteEntreValores(){
    
    int idadeMinima = 20;
    int idadeMaxima = 30;

    if (idadeMinima > idadeMaxima)
    {
        Console.WriteLine("Idade mínima deve ser menor que a idade máxima");
        return;
    }

    Console.WriteLine("Mostrando clientes com idade entre {0} e {1} anos", idadeMinima, idadeMaxima);

    clientes.Where(t => t.CalculaIdade() >= idadeMinima && t.CalculaIdade() <= idadeMaxima);

    foreach (Cliente x in clientes)
    {
        Console.WriteLine(x.Nome);
    
    }

    }

    private void ListaOrdemAlfabetica(){
        
    }

}