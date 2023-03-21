int[] firstArray = new int[5];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write("Enter a number to put in the array: ");
    int number = int.Parse(Console.ReadLine());
    firstArray[i] = number;
}

int[] secondArray = new int[5];

for(int i = 0; i < firstArray.Length; i++)
{
    secondArray[i] = firstArray[i];
}

Console.WriteLine("First array:");
for (int i = 0;i < firstArray.Length; i++)
{
    Console.WriteLine(firstArray[i]);
}

Console.WriteLine("Second array:");
for (int i = 0; i < secondArray.Length; i++)
{
    Console.WriteLine(secondArray[i]);
}