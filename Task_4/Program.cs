//1

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach(int number in numbers)
{
    sum += number;
}

Console.WriteLine(sum);

//2

int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int minSort = temps[0];
int maxSort = temps[temps.Length - 1];

int minMath = temps.Min();
int maxMath = temps.Max();
Console.WriteLine($"Min: {minSort}, Max: {maxSort}\nMin: {minMath}, Max: {maxMath}");

//3

string[] words = { "apple", "banana", "cherry", "date" };
Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));

string[] words2 = { "apple", "banana", "cherry", "date" };
string[] reversed = new string[words.Length];

for (int i = 0; i < words2.Length; i++)
{
    reversed[i] = words2[words2.Length - 1 - i];
}

Console.WriteLine(string.Join(" ", reversed));
//4

int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

int even = 0;
int odd = 0;

foreach (int num in data)
{
    if (num % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

Console.WriteLine($"Even: {even}, Odd: {odd}");

//5

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
List<int> unique = new List<int>();

foreach (int num in raw) { 

    if (!unique.Contains(num))
    {
        
        unique.Add(num);
    }
}

int[] result = unique.ToArray();
Console.WriteLine(string.Join(" ", result));

//6

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;
static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    int[] rotated = new int[n];

    for (int i = 0; i < n - k; i++)
    {
        rotated[i] = arr[i + k];
    }

    for (int i = 0; i < k; i++)
    {
        rotated[n - k + i] = arr[i];
    }
    return rotated;
}

int[] result2 = RotateLeft(arr, k);
Console.WriteLine(string.Join(" ", result2));