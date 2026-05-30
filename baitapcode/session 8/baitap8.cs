using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcode.session_8
{
    using System;

    class Program
    {
        static void Main()
        {
            //1. To input a string and print it
            string str;

            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();

            Console.WriteLine("Chuoi vua nhap: " + str);


            //2. To find the length of a string without using a library function
            int length = 0;

            foreach (char ch in str)
            {
                length++;
            }

            Console.WriteLine("Do dai chuoi = " + length);


            //3. To separate individual characters from a string
            Console.WriteLine("Cac ky tu trong chuoi:");

            foreach (char ch in str)
            {
                Console.WriteLine(ch);
            }


            //4. To print individual characters of the string in reverse order
            Console.Write("Chuoi dao nguoc: ");

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();


            //5. To count the total number of words in a string
            int words = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words++;
                }
            }

            Console.WriteLine("So tu trong chuoi = " + words);


            //6. To compare two strings without using string library functions
            string str2;
            bool equal = true;

            Console.Write("Nhap chuoi thu hai: ");
            str2 = Console.ReadLine();

            if (str.Length != str2.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != str2[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
                Console.WriteLine("Hai chuoi giong nhau");
            else
                Console.WriteLine("Hai chuoi khac nhau");


            //7. To count the number of alphabets, digits and special characters in a string
            int alphabets = 0, digits = 0, special = 0;

            foreach (char ch in str)
            {
                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                    alphabets++;
                else if (ch >= '0' && ch <= '9')
                    digits++;
                else
                    special++;
            }

            Console.WriteLine("So chu cai = " + alphabets);
            Console.WriteLine("So chu so = " + digits);
            Console.WriteLine("So ky tu dac biet = " + special);


            //8. To count the number of vowels or consonants in a string
            int vowels = 0, consonants = 0;

            foreach (char ch in str)
            {
                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                        ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("So nguyen am = " + vowels);
            Console.WriteLine("So phu am = " + consonants);


            //9. To check whether a given substring is present in the given string
            string sub;
            bool found = false;

            Console.Write("Nhap chuoi con: ");
            sub = Console.ReadLine();

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;

                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }

                if (j == sub.Length)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Co tim thay chuoi con");
            else
                Console.WriteLine("Khong tim thay chuoi con");


            //10. To search for the position of a substring within a string
            int pos = -1;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;

                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }

                if (j == sub.Length)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
                Console.WriteLine("Vi tri chuoi con = " + (pos + 1));
            else
                Console.WriteLine("Khong tim thay chuoi con");


            //11. To check whether a character is an alphabet and not and if so, check for the case
            char c;

            Console.Write("Nhap 1 ky tu: ");
            c = Convert.ToChar(Console.ReadLine());

            if (c >= 'A' && c <= 'Z')
                Console.WriteLine("Day la chu hoa");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine("Day la chu thuong");
            else
                Console.WriteLine("Khong phai chu cai");


            //12. To find the number of times a substring appears in a given string
            int count = 0;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;

                for (j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }

                if (j == sub.Length)
                    count++;
            }

            Console.WriteLine("Chuoi con xuat hien " + count + " lan");


            //13. To insert a substring before the first occurrence of a string
            string insert, result = "";

            Console.Write("Nhap chuoi can chen: ");
            insert = Console.ReadLine();

            if (pos != -1)
            {
                for (int i = 0; i < pos; i++)
                    result += str[i];

                result += insert;

                for (int i = pos; i < str.Length; i++)
                    result += str[i];

                Console.WriteLine("Chuoi moi = " + result);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con");
            }
        }
    }
}
