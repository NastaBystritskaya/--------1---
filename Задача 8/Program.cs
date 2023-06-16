Console.Write("Введите число: ");
string? input1 = Console.ReadLine();
int N = int.Parse(input1);
for (int i=0; i<N; i = i+2){
    Console.Write(i+" ");
}