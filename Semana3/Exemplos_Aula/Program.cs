/*using System.Globalization;
using System.Security.Cryptography;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");


var tuple1 = (10, 20);
Console.WriteLine($"Tuple 1: {tuple1.Item1}, {tuple1.Item2}");
//Tuple 1: 10, 20

var tuple2 = (x: 5, y: 50);
Console.WriteLine($"Tuple 2: {tuple2.x}, {tuple2.y}");
//Tuple 2: 5, 50

var tuple3 = (id: 10, name: "Helder", born: new DateTime(1987, 9, 24));
Console.WriteLine($"Tuple 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");
// Tuple 3: 10, Helder, 24/09/1987 00:00:00

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "Nicole", new DateTime(2019, 1, 12)));
list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));
// Tuple 4: 10, Helder, 24/09/1987
// Tuple 4: 11, Nicole, 12/01/2019



Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine($"Sum: {sum(10, 20)}");
// Sum: 30

Action<string> greet = name =>
{
   string greeting = $"Hello {name}!";
   Console.WriteLine(greeting);
};
string person = Console.ReadLine() ?? "";
greet(person);
// Hello `person or Someone`
// ?? and ??= are null-coalescing operators, 
//    which return the left-hand operand if the operand is not null; 
//    otherwise, they return the right operand.

Func<string, int, string> isBiggerThan = (string s, int x) => s.Length > x ? "Yes" : "No";
var size = 5;
Console.WriteLine($"The text {person} has more than {size} chars? {isBiggerThan(person, size)}");

string[] people = { "Helder", "Nicole", "Gilvana" };
char letter = 'N';
Console.WriteLine($"People with name started with '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)))}");*/



List<int> list = new() { 1, 2, 3, 4, 5 };
var squaredList = list.Select(x => x * x);
Console.WriteLine($"Original List: {string.Join(", ", list)}");
Console.WriteLine($"Squared  List: {string.Join(", ", squaredList)}");
//Original List: 1, 2, 3, 4, 5
//Squared  List: 1, 4, 9, 16, 25
var summedList = list.Select((x,index) => x + squaredList.ElementAt(index));
Console.WriteLine($"Summed   List: {string.Join(", ", summedList)}");
//Summed   List: 2, 6, 12, 20, 30

var listMultipleOfThree = list.Where(x => x % 3 == 0).ToList();  //multiplos de 3
listMultipleOfThree.AddRange(squaredList.Where(x => x % 3 == 0).ToList()); //add 
listMultipleOfThree.AddRange(summedList.Where(x => x % 3 == 0).ToList());
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree)}");
// List Multiple of Three: 3, 9, 6, 12, 30
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree.Order())}");



//---------Questao 1-----------

//using System.Security.Cryptography.X509Certificates;

/*Console.WriteLine($"{CalcAge("Leane", new DateTime(1999, 2, 25))}");

(string, int)CalcAge(string name, DateTime DiaAniversario){
    
    var age = DateTime.Today.Year - DiaAniversario.Year;
    if(DateTime.Today.DayOfYear < DiaAniversario.DayOfYear){
        age++;
    }
    
    Console.WriteLine(DiaAniversario);

    return (name,age);
}

    string [] pessoas = {"Leane", "Theo", "Kay"};
    char letter = 'A';
    Console.WriteLine($"Pessoas: ,'{letter}' : {string.Join(", ", pessoas Where(x=>x.StartsWith(letter)))} ");*/
