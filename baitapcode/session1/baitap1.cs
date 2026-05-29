using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcode.session1
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1.Print Hello and Name");
            Console.WriteLine("Hello : Tran Nguyet Thuy Tien");
            Console.WriteLine("2 peat Number in Rows");
            Console.WriteLine("25252525");
            Console.WriteLine("25 25 25 25");
            Console.WriteLine("25252525");
            Console.WriteLine("25 25 25 25");
            Console.WriteLine("3 move Character by Index");
            string st1 = "con meo be nho";
            string result1 = st1.Remove(1, 1);
            string result2 = st1[..^1];
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine("4 Multiply Two Arrays");
            int[] kitten = new int[4];
            int[] meomeo = new int[4];
            int[] result4 = new int[4];

            Console.WriteLine("nhap 4 so:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                kitten[i] = Convert.ToInt32(Console.ReadLine()); // Dung lai de cho ban nhap
            }

            Console.WriteLine("Nhap 4 so cho mang thu hai:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                meomeo[i] = Convert.ToInt32(Console.ReadLine()); // Dung lai tiep
            }

            for (int i = 0; i < 4; i++) result4[i] = kitten[i] * meomeo[i];
            Console.WriteLine("Ket qua nhan: " + string.Join(" ", result4));

            Console.WriteLine("5");
            int[] arr = [5, 2, 5, 7, 8, 5];

            Console.Write("Input an integer: ");

            string? v1 = Console.ReadLine();

            int v2 = Convert.ToInt32(v1);

            int num = v2;

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of " + num + " present in the said array: " + count);
            Console.WriteLine("6 Odd numbers from 1 to 99:");

            for (int n1 = 1; n1 < 100; n1++)
            {
                // Check if the number is odd
                if (n1 % 2 != 0)
                {
                    Console.WriteLine(n1);


                }
            }

            Console.WriteLine("7 Rectangle Pattern with Number");
            Console.Write("Enter a number: ");
            int _ = v2;

            Console.WriteLine("{0}{0}{0}", num);

            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);

            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("8.Celsius to Kelvin and Fahrenheit");
            Console.Write("Enter Celsius temperature: ");
            double celsius = Convert.ToDouble(v1);

            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
            Console.WriteLine("9");
            Console.Write(" ");
            string input = v1;

            if (input.Length
                < 1)
            {
            }
            else
            {

                var firstChar = input[0];

                Console.WriteLine("Ket qua: {0}{1}{2}", firstChar, input, firstChar);
            }
            Console.WriteLine("10 Check Within 20 of 100 or 200");
            Console.Write(" ");
            int n = v2;

            bool check = Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20;

            Console.WriteLine("Ket qua: " + check);
            Console.WriteLine("11 Convert String to Lowercase ");
            Console.Write("Nhap: ");
            string Input = v1;

            string v = input.ToLower();

            string result3 = v;

            Console.WriteLine("ket qua: " + result3);
            Console.WriteLine("12 Sum of Digits in Integer ");
            Console.Write("Nhap so: ");
            int u = v2;

            int sum = 0;
            int temp = Math.Abs(num);

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("tong cac chu so cua {0} la: {1}", num, sum);
            Console.WriteLine("13  File Size in Bytes ");

            FileInfo fileInfo = new("test.txt");

            FileInfo f = fileInfo;
            if (f.Exists)
            {
                Console.WriteLine("File size in bytes: " + f.Length);
            }
            else
            {
                Console.WriteLine("File does not exist.");
                Console.WriteLine("14 Hexadecimal to Decimal ");
                Console.Write("Input a hexadecimal number: ");
                string hexValue = v1;

                try
                {
                    int decimalValue = Convert.ToInt32(hexValue, 16);

                    Console.WriteLine("Decimal value: " + decimalValue);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid hexadecimal number.");
                }
            }
            Console.WriteLine("15 Check Multiple of 3 or 7 ");
            Console.Write("Input an integer: ");
            int N = v2;

            if (N > 0)
            {
                bool result4v = n % 3 == 0 || n % 7 == 0;
                Console.WriteLine(result4v);
            }
            Console.WriteLine(value: "16 First and Last Element Equal in Array");
            int[] nums = [1, 2, 3, 4, 8, 1];

            Console.WriteLine("Array: [{0}]", string.Join(", ", nums));

            if (nums.Length >= 1)
            {
                bool result = nums[0] == nums[nums.Length - 1];


                Console.WriteLine("First and last elements are equal: " + result);
            }

            Console.WriteLine("17 Max Product of Adjacent Integers");

            int[] arr17 = [2, 4, -1, -5, 3];
            Console.WriteLine("Array: [{0}]", string.Join(", ", nums));

            if (nums.Length < 2)
            {
                return;
            }

            int maxProduct = arr17[0] * arr17[1];
            int firstNum = arr17[0];
            int secondNum = arr17[1];

            for (int i = 1; i < arr17.Length - 1; i++)
            {
                int currentProduct = arr17[i] * arr17[i + 1];
                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                    firstNum = arr17[i];
                    secondNum = arr17[i + 1];
                }
            }


            Console.WriteLine("cap so co tich lon nhat: {0} và {1}", firstNum, secondNum);
            Console.WriteLine("Tich lon nhat: {0}", maxProduct);

            Console.WriteLine("18 Get File Name from Path ---");


            string filePath = @"C:\Users\Admin\Documents\test_document.pdf";
            Console.WriteLine("Full Path: " + filePath);


            string fileName = Path.GetFileName(filePath);


            Console.WriteLine("File Name: " + fileName);


            string nameOnly = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine("File Name without extension: " + nameOnly);


            Console.WriteLine(19);
            Console.Write("Input the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var Temp = number1;
            number1 = number2;
            number2 = Temp;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);

            Console.ReadLine();

            Console.WriteLine(20);
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
