Console.Write("Введите первое число: ");
string? input1 = Console.ReadLine();
int num1 = int.Parse(input1!);

Console.Write("Введите второе число: ");
string? input2 = Console.ReadLine();
int num2 = int.Parse(input2!);

Console.Write("Введите третье число: ");
string? input3 = Console.ReadLine();
int num3 = int.Parse(input3!);

int max=num1;

if (max<num2) {
    max=num2;
} 
if (max<num3) {
    max=num3;

}
System.Console.WriteLine($"{max} большее число");

