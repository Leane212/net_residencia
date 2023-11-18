// 1:

//Primeiro verifica a versao global que ta SDK instalado ---
//    dotnet --version 

//Depois pode-se listar as versoes instaladas ---
//    dotnet --list-sdks

//Para remover ---
//    dotnet --uninstall-sdk <versao>

//Para atualizar ---
//    dotnet --install-dir /usr/share/dotnet

//2:

int preco = 5;
int quantidadeDeFrutas = 10;

int lucroDeVenda = preco * quantidadeDeFrutas;
Console.WriteLine($"Lucro liquido de venda eh: {lucroDeVenda}");
Console.WriteLine();

decimal preco5 = 5.99m;
decimal quantidadeDeFrutas5 = 10;

decimal lucroDeVenda5 = preco5 * quantidadeDeFrutas5;
Console.WriteLine($"Lucro liquido de venda eh: {lucroDeVenda5}");

long volumeCaixa = 1000000000L;
long volumeBalde = 10500000L;

long volumeTotal = volumeCaixa + volumeBalde;
Console.WriteLine($"O volume total eh: {volumeTotal} m^3");

float a = 65.55f;
float b = 3.0f;

float divisao = a / b;
Console.WriteLine($"A divisao de a por b eh: {divisao}");

double temperaturaC = 3.55;
double temperaturaD = 10.21;

double divisaodasTemperaturas = temperaturaC / temperaturaD;
Console.WriteLine($"A divisao das temperaturas eh: {somadasTemperaturas}");

// 3:

Console.WriteLine();

double temperatura = 3.55;
int numInteiro = Convert.ToInt32(temperatura);
Console.WriteLine($"Numero Inteiro: {numInteiro}");

// 4:

Console.WriteLine();

int x = 10;
int y = 3;

int subtracao = x - y;
int adicao = x + y;
int multiplicacao = x * y;
int divisao1 = x / y;

Console.WriteLine($"Subtracao: {subtracao}");
Console.WriteLine($"Adicao: {adicao}");
Console.WriteLine($"Multiplicacao: {multiplicacao}");
Console.WriteLine($"Divisao: {divisao1}");

// 5:

Console.WriteLine();

int a = 5;
int b = 8;

bool resposta = a > b;
Console.WriteLine($"A eh maior que B?: {resposta}");

// 6:

Console.WriteLine();

string str1 = "Hello"; 
string str2 = "World";

bool resultado = string.Equals(str1, str2);
Console.WriteLine($"As duas strings sao iguais?: {resultado}");

// 7:

Console.WriteLine();

bool condicao1 = true;
bool condicao2 = false;

bool verdadeira = condicao1 && condicao2;
Console.WriteLine($"Ambas condicoes sao verdadeiras?: {verdadeira}");

// 8:
Console.WriteLine();

int num1 = 7;
int num2 = 3;
int num3 = 10;

bool respos = num1 > num2;
bool respos5 = num3 == num1 + num2;

Console.WriteLine($"Numero um eh maior que numero dois?: {respos}");
Console.WriteLine($"Numero tres eh igual a soma de numero um e numero dois?: {respos5}");





