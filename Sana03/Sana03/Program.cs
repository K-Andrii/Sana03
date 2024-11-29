Console.WriteLine("Enter N of elevent array:");
int N = int.Parse(Console.ReadLine());

double[] arr =  new double[N];
Random random = new Random();

Console.WriteLine("Array:");
for (int i = 0; i < N; i++)
{
    arr[i] = Math.Round(random.Next(0, 2) == 0 ? random.Next(-1000, 1001) : random.Next(-1000, 1001) + random.NextDouble(), 2);
    Console.Write($"{arr[i]}  ");
}

double sumNeg = 0, min = arr[0], max = arr[0], Imax = 0, maxM = arr[0], sumIpos = 0, countInt = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] < 0) sumNeg += arr[i];
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) Imax = i;
    if (Math.Abs(arr[i]) > maxM) maxM = Math.Abs(arr[i]);
    if (arr[i] > 0) sumIpos += i;
    if (arr[i] % 1 == 0) countInt++;
}

Console.WriteLine($"\nSum of negative - {sumNeg}");
Console.WriteLine($"Min num - {min}");
Console.WriteLine($"Index of max - {Imax}");
Console.WriteLine($"Max num (modul) - {maxM}");
Console.WriteLine($"Sum indexs of positive - {sumIpos}");
Console.WriteLine($"Count of int - {countInt}");

