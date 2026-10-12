using System;

class bai1
{
    static void Main()
    {
        Console.WriteLine("Nhap a,b,c");
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b  = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int max = Math.Max(a, Math.Max(b,c));

        int min = Math.Min(a, Math.Min(b,c));

        int sum = a + b + c;
        float avg = sum/3.0f;

        Console.WriteLine("Lon nhat: " + max);
        Console.WriteLine("Nho nhat: " + min);
        Console.WriteLine("Tong: " + sum);        Console.WriteLine("Trung binh: " + Math.Round(avg, 2));
    }
}