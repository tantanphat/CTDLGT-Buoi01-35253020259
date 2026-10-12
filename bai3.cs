
using System;
using System.Diagnostics;

class bai3
{
    static long CachA(int[] a)
    {
        long max = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            long tong = 0;

            for (int j = i; j < a.Length; j++)
            {
                tong += a[j];

                if (tong > max)
                    max = tong;
            }
        }

        return max;
    }

    static long CachB(int[] a)
    {
        long tong = a[0];
        long max = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            tong = Math.Max(a[i], tong + a[i]);
            max = Math.Max(max, tong);
        }

        return max;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap cac phan tu:");
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        var sw = System.Diagnostics.Stopwatch.StartNew();
        var kqA = CachA(a);
        sw.Stop();
        double tgA = sw.Elapsed.TotalMilliseconds;

        sw.Restart();
        var kqB = CachB(a);
        sw.Stop();
        double tgB = sw.Elapsed.TotalMilliseconds;

        Console.WriteLine("Tong lon nhat A: " + kqA);
        Console.WriteLine("Thoi gian A: " + tgA + " ms");

        Console.WriteLine("Tong lon nhat B: " + kqB);
        Console.WriteLine("Thoi gian B: " + tgB + " ms");

        int[] kichThuoc = { 100, 1000, 10000 };
        Random rd = new Random();

        foreach (int size in kichThuoc)
        {
            int[] mang = new int[size];

            for (int i = 0; i < size; i++)
                mang[i] = rd.Next(-100, 100);

            sw.Restart();
            CachA(mang);
            sw.Stop();
            Console.WriteLine("A, n = " + size + ": "
                + sw.Elapsed.TotalMilliseconds + " ms");

            sw.Restart();
            CachB(mang);
            sw.Stop();
            Console.WriteLine("B, n = " + size + ": "
                + sw.Elapsed.TotalMilliseconds + " ms");
        }
    }
}
