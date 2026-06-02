using System;
using System.IO;
using System.Linq;

internal class bai_8
{ // to create a blank file 
    static void Main()
    {
        string path = @"c:\Users\ADMIN\source\repos\baitapcode\baitapcode\sesion 9\file.txt";
        File.Create(path).Close();
        Console.WriteLine("File da duoc tao tai: " + path);
        // to remove a file from a disk;
        File.Delete(path);
        Console.WriteLine("file da xoa het");
        // to creat a file and add some text
        string meo = @"c:\Users\ADMIN\source\repos\baitapcode\baitapcode\sesion 9\file.txt";
        File.WriteAllText(meo, "meo meo meo");
        Console.WriteLine("file da duoc tao va them noi dung");
        // creat a text file and read it
        string data = File.ReadAllText(meo);
        Console.WriteLine("Noi dung file: " + data);
        //5.to create a file and write an array of strings to the file.
        string[] mang =
        {
            "conmeo trang",
            " con meo vang",
            "con meo den",
            "con meo xam"
        };
        File.WriteAllLines(meo, mang);
        Console.WriteLine("file da duoc tao va them noi dung");
        //6.to append some text to an existing file.
        string moi = @"c:\Users\ADMIN\source\repos\baitapcode\baitapcode\sesion 9\file.txt";
        string[] them =
            { "con meo hong be nho",
              "con meo xanh be nho",
              "con meo do be nho"
            };
        File.AppendAllLines(moi, them);
        Console.WriteLine("Noi dung da duoc them vao file");
        // 7 create and copy the file to another name and display the content;
        string source = @"hellolitty.txt";
        string destination = @"hellolitty_copy.txt";
        File.WriteAllText(source, "be meo hong be nho");
        File.Copy(source, destination, true);
        string data1 = File.ReadAllText(destination);
        Console.WriteLine(data1);
        //8 create a file and move it into the same directory with another name.
        string oldfile = @"conmeobenho.txt";
        string newfile = @"conmeobenho_moved.txt";
        File.WriteAllText(oldfile, "be meo de thuong dang yeu ngot ngao");
        if (File.Exists(newfile))
        {
            File.Delete(newfile);
        }
        File.Move(oldfile, newfile);
        string data2 = File.ReadAllText(newfile);
        Console.WriteLine(data2);
        //9. read the first line of a file.
        string filee = @"helokitty.txt";
        string[] themnoidung =
        {
            "hello kitty mini cuoi hihi",
            "hello kitty mini dang yeu",
        };
        File.WriteAllLines(filee, themnoidung);
        string firstline = File.ReadLines(filee).First();
        Console.WriteLine(firstline);
        //10 create and read last line of a file.
        string fileee = @"conmeobebenho.txt";
        string[] hoimeovn =
            { "kitten bebie",
              "kitten bebi dang yeu",
              "kitten bebie de thuong"
            };
        File.WriteAllLines(fileee, hoimeovn);
        string lasteline = File.ReadLines(fileee).Last();
        Console.WriteLine(lasteline);
        //11 create and read n lines of a file.
        string fileeee = @"akittenbebi.txt";
        string[] hoimeovn1 =
            { "kitten bebie",
              "kitten bebi dang yeu",
              "kitten bebie de thuong"
            };
        File.WriteAllLines(fileeee, hoimeovn1);
        int n = 2;
        string[] lines = File.ReadAllLines(fileeee);
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(lines[i]);

        }
        //12 read a speacific line of a file.
        File.ReadAllLines(fileeee);
        int lineNumber = 1;
        Console.WriteLine(lines[lineNumber]);
        //13.to count the number of lines in a file
        int lineCount = File.ReadAllLines(fileeee).Length;
        Console.WriteLine("So dong trong file: " + lineCount);
        //14 To print the structure of specific folder (include files)
        string folderPath = @"c:\Users\ADMIN\source\repos\baitapcode\baitapcode";
        string[] files = Directory.GetFiles(folderPath);
        Console.WriteLine("Cau truc thu muc: " + folderPath);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        //15.Read a text file, then statistic the appearance of characters and numbers.
        string textfile = @"conmeomeomeo.txt";
        string content = "con meo meo meo meo meo meo meo meo meo";
        File.WriteAllText(textfile, content);
        int suxuathien = 0;
        char characterToCount = 'o';
        foreach (char c in File.ReadAllText(textfile))
        {
            if (c == characterToCount)
            {
                suxuathien++;
            }
        }
        Console.WriteLine("So lan xuat hien cua ky tu '{0}': {1}", characterToCount, suxuathien);
        int suxuathiencuaso = 0;
        char soToCount = '0';
        foreach (char c in File.ReadAllText(textfile))
        {
            if (c == soToCount)
            {
                suxuathiencuaso++;
            }
        }
        Console.WriteLine("So lan xuat hien cua ky tu '{0}': {1}", soToCount, suxuathiencuaso);


    }
}