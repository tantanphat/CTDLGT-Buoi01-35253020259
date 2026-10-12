using System;

class bai2
{
    static void Main()
    {
        Console.WriteLine("Nhap n");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap cac phan tu");
        for(int i = 0; i<n;i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        int max1 = a[0];
        int max2 = 0;
        bool found = false;
        for ( int i = 1; i< n; i++)
        {
            if(a[i] > max1)
            {
                max2 = max1;
                max1 = a[i];
                found = true;
            } else if (a[i] < max1 && (!found || a[i] > max2))
            {
                max2 = a[i];
                found = true;
            }
        }

        
        if(found)
        {
            Console.WriteLine("Lon nhat: "+max1);
            Console.WriteLine("Lon thu 2: "+max2);
        } else
        {
            Console.WriteLine("No");
        }
    }
}