// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] people = { "Leane", "Kalay", "Theo"};
foreach(string person in people)
{
    Console.WriteLine(person);
}

//Exercicios
/*Escreva um programa em c# que imprime todos os numeros que são divisiveis por 3 ou por 4 
entre 0 e 30*/

for(int i = 0; i <=30; i++)
{
    if(i%3==0)
    {
        Console.WriteLine("O valor " +i+" é divisivel por 3");
    }
    if(i%4==0)
    {
        Console.WriteLine("O valor " +i+ " é divisivel por 4");
    }
}

/*Faça um programa em c# que imprima os primeiro números da serie de fibonacci ate
passar de 100. A serie de fibonacci é a seguinte: 0,1,1,2,3,5,8,13,21 etc...
Para calcula-la, o primeiro elemento vale 0, o segundo (n-1)-ésimo elemento somado ao 
(n-2)-énesimo elemento*/

int fib =0;
int fib1 =1;
int fib2;

Console.WriteLine("fib");
Console.WriteLine("fib1");

for(fib2 = fib1+fib; fib <=100;)
{
    Console.WriteLine("Serie de Finonacci: " +fib);
    fib = fib1;
    fib1 = fib2;
    fib2 = fib1 + fib;
}