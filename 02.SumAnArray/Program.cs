﻿int[] numbersArray = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

int sum = 0;

for (int i = 0; i < numbersArray.Length; i++) 
{
    sum += numbersArray[i];
}
Console.WriteLine(sum);