using System;
using System.Linq;

class Program2
{
    // Bài 1
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    // Bài 2
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }

    // Bài 3
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    // Bài 4
    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;

        for (int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }

        return ketQua;
    }

    // Bài 5
    static string DaoNguocChuoi(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    // Bài 6
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // Bài 7
    static void InFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }

    // Bài 8
    static int DemNguyenAm(string s)
    {
        int dem = 0;
        string nguyenAm = "aeiouAEIOU";

        foreach (char c in s)
        {
            if (nguyenAm.Contains(c))
                dem++;
        }

        return dem;
    }

    // Bài 9
    static double TinhLuyThua(double x, int y)
    {
        double ketQua = 1;

        for (int i = 0; i < y; i++)
        {
            ketQua *= x;
        }

        return ketQua;
    }

    // Bài 10
    static double TinhTrungBinh(int[] arr)
    {
        int tong = 0;

        foreach (int x in arr)
        {
            tong += x;
        }

        return (double)tong / arr.Length;
    }

    // Bài 11
    static bool KiemTraDoiXung(string s)
    {
        string daoNguoc = new string(s.Reverse().ToArray());

        return s == daoNguoc;
    }

    // Bài 12
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    // Bài 13
    static int TimMin(int[] arr)
    {
        int min = arr[0];

        foreach (int x in arr)
        {
            if (x < min)
                min = x;
        }

        return min;
    }

    // Bài 14
    static int TongCacChuSo(int n)
    {
        int tong = 0;

        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }

        return tong;
    }

    // Bài 15
    static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);

        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }

    // Bài 16
    static string XoaTrungLap(string s)
    {
        string ketQua = "";

        foreach (char c in s)
        {
            if (!ketQua.Contains(c))
            {
                ketQua += c;
            }
        }

        return ketQua;
    }

    // Bài 17
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    // Bài 18
    static string DecimalToBinary(int n)
    {
        string binary = "";

        while (n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }

        return binary;
    }

    // Bài 19
    static bool KiemTraNamNhuan(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    // Bài 20
    static int DemSoTu(string sentence)
    {
        string[] words = sentence.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return words.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Tong = " + TinhTong(5, 7));

        Console.WriteLine("10 la so chan? " + KiemTraChan(10));
        Console.WriteLine("7 la so chan? " + KiemTraChan(7));

        Console.WriteLine("So lon nhat = " + TimMax(12, 25, 9));

        Console.WriteLine("5! = " + TinhGiaiThua(5));

        Console.WriteLine("Chuoi dao nguoc: " + DaoNguocChuoi("Hello"));

        Console.WriteLine(KiemTraNguyenTo(7));

        InFibonacci(6);

        Console.WriteLine(DemNguyenAm("Hello World"));

        Console.WriteLine(TinhLuyThua(2, 3));

        Console.WriteLine(TinhTrungBinh(new int[] { 4, 5, 6, 7 }));

        Console.WriteLine(KiemTraDoiXung("radar"));

        Console.WriteLine(CelsiusToFahrenheit(25));

        Console.WriteLine(TimMin(new int[] { 10, 5, 8, 2, 9 }));

        Console.WriteLine(TongCacChuSo(1234));

        SapXepMang(new int[] { 3, 1, 4, 2 });

        Console.WriteLine(XoaTrungLap("programming"));

        Console.WriteLine(UCLN(12, 18));

        Console.WriteLine(DecimalToBinary(10));

        Console.WriteLine(KiemTraNamNhuan(2024));

        Console.WriteLine(DemSoTu("Hoc lap trinh C# rat thu vi"));
    }
}