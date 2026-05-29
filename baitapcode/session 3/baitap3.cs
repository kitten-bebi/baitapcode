using System;

Console.WriteLine("1");
Console.Write("Nhap so thu nhat: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Nhap phep tinh (+ - * /): ");
char pheptinh = Convert.ToChar(Console.ReadLine());

Console.Write("Nhap so thu hai: ");
double b = Convert.ToDouble(Console.ReadLine());

if (pheptinh == '+')
    Console.WriteLine("Ket qua = " + (a + b));

else if (pheptinh == '-')
    Console.WriteLine("Ket qua = " + (a - b));

else if (pheptinh == '*')
    Console.WriteLine("Ket qua = " + (a * b));

else if (pheptinh == '/')
    Console.WriteLine("Ket qua = " + (a / b));

else
    Console.WriteLine("Phep tinh khong hop le");
Console.WriteLine("2");
int x;
for (int y = -5; y <= 5; y++)
{
    x = y * y + 2 * y + 1;

    Console.WriteLine("y = " + y + " , x = " + x);
}

Console.WriteLine("3");
Console.Write("Enter distance in kilometers: ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter hours: ");
int hours = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter minutes: ");
int minutes = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter seconds: ");
int seconds = Convert.ToInt32(Console.ReadLine());

double totalTime = hours + (minutes / 60.0) + (seconds / 3600.0);

double kmh = distance / totalTime;

double miles = distance * 0.621371;

double mph = miles / totalTime;

Console.WriteLine("Speed in km/h = " + kmh);

Console.WriteLine("Speed in miles/h = " + mph);

Console.WriteLine("4");
Console.Write("Enter radius: ");
double r = Convert.ToDouble(Console.ReadLine());

double volume = (4.0 / 3.0) * Math.PI * r * r * r;

double surface = 4 * Math.PI * r * r;

Console.WriteLine("Surface Area = " + surface);

Console.WriteLine("Volume = " + volume);
Console.WriteLine("5");
Console.Write("Enter a character: ");
char t = Convert.ToChar(Console.ReadLine());

if (t == 'a' || t == 'e' || t == 'i' || t == 'o' || t == 'u' ||
    t == 'A' || t == 'E' || t == 'I' || t == 'O' || t == 'U')
{
    Console.WriteLine("It is a vowel");
}

else if (char.IsDigit(t))
{
    Console.WriteLine("It is a digit");
}

else
{
    Console.WriteLine("It is another symbol");
}
Console.WriteLine("6");
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
    Console.WriteLine("7");
    Console.Write("Enter first number: ");
    int e = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int f = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter third number: ");
    int c = Convert.ToInt32(Console.ReadLine());
    if (e > f && a > c)
    {
        Console.WriteLine("Largest number is: " + e);
    }

    else if (f > e && f > c)
    {
        Console.WriteLine("Largest number is: " + f);
    }

    else
    {
        Console.WriteLine("Largest number is: " + c);
    }
}
Console.WriteLine("8");
Console.Write("Enter x coordinate: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter tr coordinate: ");
int tr = Convert.ToInt32(Console.ReadLine());

if (p > 0 && tr > 0)
{
    Console.WriteLine("The point is in the First Quadrant");
}

else if (p < 0 && tr > 0)
{
    Console.WriteLine("The point is in the Second Quadrant");
}

else if (p < 0 && tr < 0)
{
    Console.WriteLine("The point is in the Third Quadrant");
}

else if (p > 0 && tr < 0)
{
    Console.WriteLine("The point is in the Fourth Quadrant");
}

else
{
    Console.WriteLine("The point is on the axis");
}
//9
int o, ob, oc;

Console.Write("Enter first side: ");
o = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second side: ");
ob = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third side: ");
oc = Convert.ToInt32(Console.ReadLine());

if (o == ob && ob == oc)
{
    Console.WriteLine("Equilateral Triangle");
}
else if (o == ob || ob == oc || o == oc)
{
    Console.WriteLine("Isosceles Triangle");
}
else
{
    Console.WriteLine("Scalene Triangle");
}
int sum = 0;
double average;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Enter number " + i + ": ");
    int num = Convert.ToInt32(Console.ReadLine());

    sum += num;
}

average = sum / 10.0;

Console.WriteLine("Sum = " + sum);
Console.WriteLine("Average = " + average);

//10
int n;
Console.Write("Enter an integer: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Multiplication Table of " + n);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(n + " x " + i + " = " + (n * i));
}
//11
int rows;
Console.Write("Enter number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }

    Console.WriteLine();
    //12
    int l = 1;

    for (int qui = 1; qui <= 4; qui++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(n + " ");
            l++;
        }

        Console.WriteLine();

        //13
        int po;
        double total = 0;

        Console.Write("Enter number of terms: ");
        po = Convert.ToInt32(Console.ReadLine());

        for (int thth = 1; thth <= po; thth++)
        {
            total += 1.0 / thth;
        }

        Console.WriteLine("Sum = " + sum);
        //14
        int start, end;

        Console.Write("Enter start number: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end number: ");
        end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Perfect numbers are:");

        for (int love = start; love <= end; love++)
        {
            int ketqua = 0;

            for (int meo = 1; meo < love; meo++)
            {
                if (love % meo == 0)
                {
                    total += meo;
                }
            }

            if (total == love)
            {
                Console.WriteLine(love);
            }
            Console.WriteLine("15");
            int so = 0;
            bool laSoNguyenTo = true;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (so <= 1)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int kk = 2; kk < number; kk++)
                {
                    if (so % kk == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }

            if (laSoNguyenTo)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}



