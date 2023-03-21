int[] firstArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int number in firstArray)
{
    if (number < currentSmallest)
        currentSmallest = number;
}
Console.WriteLine(currentSmallest);

int[] secondArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int number in secondArray)
    total += number;
float average = (float)total / secondArray.Length;
Console.WriteLine(average);