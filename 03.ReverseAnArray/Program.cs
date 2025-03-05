using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
for (int i = 0; i < n; i++) 
{
int currNum = int.Parse(Console.ReadLine());

    numbers[i] = currNum;
}

int[] reverseArray = new int[n];

for(int i = numbers.Length - 1; i >=0; i--) 
{
reverseArray[numbers.Length - i - 1] = numbers[i];
}
Console.WriteLine(string.Join(" ", reverseArray));