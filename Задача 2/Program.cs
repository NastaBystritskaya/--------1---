Console.Write("Введите первое число: ");
string? input1 = Console.ReadLine();
int num1 = int.Parse(input1!);

Console.Write("Введите второе число: ");
string? input2 = Console.ReadLine();
int num2 = int.Parse(input2!);

if(num1>num2) {
    System.Console.WriteLine($"{num1} большее число");
} else {
    System.Console.WriteLine($"{num2} большее число");
}