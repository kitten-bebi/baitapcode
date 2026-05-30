using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace baitapso7
{
    internal class baiso7
    {
        static void Main1(string[] args)
        {
            //cau1
            int n;
            n = int.Parse(Console.ReadLine());
            string[] dauvao = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(dauvao[i]);

            }
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();


            // cau so 2

            Console.WriteLine("nhap vao so b");
            int b = int.Parse(Console.ReadLine());
            double[] a2 = new double[b];
            double tong = 0;
            for (int i = 0; i < b; i++)

            {
                a2[i] = double.Parse(Console.ReadLine());
                tong += a2[i];
            }
            double trungbinhcong = tong / b;
            Console.WriteLine($"{tong:F2}");
            Console.WriteLine($"{trungbinhcong:F2}");
            // cau so 3 tim so lon nhat va so nho nhat
            Console.WriteLine("moi nhap vao so nguyen c");
            int c = int.Parse(Console.ReadLine());
            int[] a3 = new int[c];
            for (int i = 0; i < c; i++)
            {
                a3[i] = int.Parse(Console.ReadLine());
            }
            int max = a3[0];
            int min = a3[0];
            for (int i = 1; i < c; i++)
            {
                if (a3[i] > max)
                    max = a3[i];
                if (a3[i] < min)
                    min = a3[i];
            }
            Console.WriteLine($"so lon nhat va so nho nhat la: {max}   {min}");
            //cau 3 dem so chan va so le
            Console.WriteLine("nhap vao so nguyen d");
            int d = int.Parse(Console.ReadLine());
            int[] a4 = new int[d];
            for (int i = 0; i < d; i++)
            {
                a4[i] = int.Parse(Console.ReadLine());
            }
            int chan = 0;
            int le = 0;
            for (int i = 0; i < d; i++)
            {
                if (a4[i] % 2 == 0)
                    chan++;
                else
                    le++;
            }
            Console.WriteLine($"so chan la: {chan}");
            Console.WriteLine($"so le la: {le}");
            //5 tìm kiếm một số trong năm
            Console.WriteLine("moi nhap vao so phan tu cua mang");
            int p = int.Parse(Console.ReadLine());
            int[] nam = new int[p];
            Console.WriteLine($"moi nhap vao {p} so cho mang: ");
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine($" nhap phan tu thu{i + 1}");
                nam[i] = int.Parse(Console.ReadLine());
            }
            int e;
            Console.WriteLine($"moi nhap vao so nguyen");
            e = int.Parse(Console.ReadLine());
            bool timthay = false;
            for (int i = 0; i < p; i++)
            {
                if (nam[i] == e)
                {
                    Console.WriteLine($"so {e} co trong mang");
                    timthay = true;
                    break;
                }
                if (timthay == false)
                {
                    Console.WriteLine($"so {e} khong co trong mang");

                }
                //cau 6 Đảo nguoc một mảng
                Console.WriteLine("moi nhap vao so phan tu cua mang");
                int f = int.Parse(Console.ReadLine());
                int[] mang = new int[f];
                Console.WriteLine($"moi nhap vao {f} so cho mang");
                for (int j = 0; j < f; j++)
                {
                    Console.WriteLine($"nhap vao phan tu thu {j + 1}: ");
                    mang[j] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < f / 2; j++)
                {
                    int temp = mang[j];
                    mang[j] = mang[f - 1 - j];
                    mang[f - 1 - j] = temp;
                }
            }
            //cau 7 kiem tra mang doi xung
            Console.WriteLine("moi nhap vao so phan tu cua mang");
            int t = int.Parse(Console.ReadLine());
            int[] mang2 = new int[t];
            Console.WriteLine($"moi nhap vao {t} so cho mang");
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine($"nhap vao phan tu thu {i + 1}: ");
                mang2[i] = int.Parse(Console.ReadLine());
            }
            bool doixung = true;
            for (int i = 0; i < t / 2; i++)
            {
                if (mang2[i] != mang2[t - 1 - i])
                {
                    doixung = false;
                    break;
                }
            }
            if (doixung == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //bai 8 liet ke so nguyen to trong mang
            Console.WriteLine("nhap so phan tu cua mang");
            int o = int.Parse(Console.ReadLine());
            int[] mang3 = new int[o];
            Console.WriteLine($"moi nhap vao {o} so cho mang");
            for (int l = 0; l < o; l++)
            {
                Console.WriteLine($"moi nhap vao phan tu thu {l + 1}: ");
                mang3[l] = int.Parse(Console.ReadLine());
            }
            Console.Write("cac so nguyen to trong mang la: ");
            for (int k = 0; k < o; k++)
            {
                int phaisonguyento = mang3[k];
                if (phaisonguyento >= 2)
                {

                    bool lasoonguyento = true;
                    for (int m = 2; m <= Math.Sqrt(phaisonguyento); m++)
                    {
                        if (phaisonguyento % m == 0)
                        {
                            lasoonguyento = false;
                            break;
                        }
                    }
                    if (lasoonguyento)
                    {
                        Console.WriteLine(phaisonguyento);
                    }
                }
            }
            //bai 9 tach mang chan le
            Console.WriteLine("nhap so phan tu cua mang");
            int q = int.Parse(Console.ReadLine());
            int[] mang4 = new int[q];
            int[] mangsochan = new int[q];
            int[] mangsole = new int[q];
            int demsochan = 0;
            int demsole = 0;
            Console.WriteLine("moi nhap vao {q} so cho mang");
            for
                (int i = 0; i < q; i++)
            {
                Console.WriteLine($"moi nhap vao phan tu thu {i + 1}: ");
                mang4[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < q; i++)
            {
                if (mang4[i] % 2 == 0)
                {
                    mangsochan[demsochan] = mang4[i];
                    demsochan++;
                }
                else
                {
                    mangsole[demsole] = mang4[i];
                    demsole++;
                }
            }
            Console.WriteLine("mang so chan la:");
            for (int i = 0; i < demsochan; i++)
            {
                Console.Write(mangsochan[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("mang so le la:");
            for (int i = 0; i < demsole; i++)
            {
                Console.Write(mangsole[i] + " ");
            }

            //cau 10 sap xep mang tang dan va giam dan
            Console.WriteLine("nhap so phan tu cua mang");
            int r = int.Parse(Console.ReadLine());
            int[] mang5 = new int[r];
            Console.WriteLine("moi nhap vao {r} so cho mang");
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"moi nhap vao phan tu thu {i + 1}: ");
            }
            for (int i = 0; i < r - 1; i++)
            {
                for (int j = i + 1; j < r; j++)
                {
                    if (mang5[i] > mang5[j])
                    {
                        int temp = mang5[i];
                        mang5[i] = mang5[j];
                        mang5[j] = temp;
                    }
                }
            }
            Console.WriteLine("mang sau khi xep tang dan la");
            for (int i = 0; i < r; i++)
            { Console.Write(mang5[i] + " "); }
            Console.WriteLine();
            for (int i = 0; i < r - 1; i++)
            {
                for (int j = i + 1; j < r; j++)
                {
                    if (mang5[i] < mang5[j])
                    {
                        int temp = mang5[i];
                        mang5[i] = mang5[j];
                        mang5[j] = temp;
                    }
                }
            }
            Console.WriteLine("mang sau khi xep giam dan la");
            for (int i = 0; i < r; i++)
            {
                Console.Write(mang5[i] + " ");
            }
        }


    }









}



