Console.Write("Введите число: ");
string? input1 = Console.ReadLine();
int num1 = int.Parse(input1!); 
if  (num1 % 2 == 0) {
   System.Console.WriteLine($"{num1} четное");
} else {
   System.Console.WriteLine($"{num1} нечетное"); 
}

