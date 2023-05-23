using lb10;
using System;
using System.Diagnostics;
using System.Text;

public class Program
{
    public int Num(DirectoryInfo dir)
    {
        int count = 0;

        return count;
    }
    static void Printdir(DirectoryInfo dir)
    {
        DirectoryInfo[] dr = dir.GetDirectories();
        foreach (DirectoryInfo d in dr)
        {
            if (d.GetFileSystemInfos().Length == 0)
            {
                Console.WriteLine(d.Name);
            }
            else
            {
                Printdir(d);
            }
        }
    }
    static void Main()
    {

        try
        {
            if (Directory.Exists(@"..\..\basedir\dir0"))
            {
                #region 1-3
                //Задния 1-3
                //Console.WriteLine(Directory.GetFileSystemEntries(@"..\..\basedir\dir0").Length);
                //DirectoryInfo dir0 = new DirectoryInfo(@"..\..\basedir\dir0");
                //DirectoryInfo[] dir = dir0.GetDirectories();
                //for (int i = 0; i < dir.Length; i++)
                //{
                //    Console.WriteLine(dir[i].Name);
                //}
                //Console.WriteLine(Directory.GetFiles(@"..\..\basedir\dir0").Length);
                //Console.WriteLine(Directory.GetFileSystemEntries(@"..\..\basedir\dir0", "*.txt").Length);
                //DirectoryInfo basedir = new DirectoryInfo(@"..\..\basedir");
                ////Printdir(basedir);
                //Console.WriteLine(Path.GetFullPath("елки.txt"));
                //Directory.CreateDirectory(@"..\..\basedir\Picture");
                //Directory.CreateDirectory(@"..\..\basedir\Texts\History");
                //Directory.CreateDirectory(@"..\..\basedir\Texts\Horror\First");
                //for (int i = 1; i < 6 + 1; i++)
                //{
                //    var myFile=File.CreateText(@$"..\..\basedir\Picture\{i}.txt");
                //    myFile.Close();
                //}
                //FileInfo file1 = new FileInfo(@"..\..\basedir\Picture\5.txt");
                //file1.CopyTo(@"..\..\basedir\Picture\5000.txt", true);
                //file1.Delete();
                //Console.WriteLine("5.txt заменен");
                //File.Delete(@"..\..\basedir\Picture\6.txt");
                //Console.WriteLine("6.txt Удален");
                //Console.WriteLine("какой изфайлов удалить?\n1,2,3,4,5000");
                //int n=Convert.ToInt32(Console.ReadLine());
                //if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5000)
                //{
                //    File.Delete(@$"..\..\basedir\Picture\{n}.txt");
                //    Console.WriteLine($"{n}.txt Удален");
                //}
                //else
                //{
                //    Console.WriteLine("Нет такого Файла");
                //}
                //Directory.Delete(@"..\..\basedir\Picture",true);
                //Console.WriteLine(@"basedir\Picture Удален");
                //Directory.Delete(@"..\..\basedir\Texts\Horror", true); 
                //Console.WriteLine(@"basedir/Texts/Horror Удален");
                #endregion
                #region Задание4
                ////Задaние 4.a
                //var a = new FileStream(@"..\..\basedir\data\dataset_1.txt", FileMode.Open);
                //byte[] buffer = new byte[a.Length];
                //a.Read(buffer, 0, buffer.Length);
                //string Text = Encoding.Default.GetString(buffer);
                //string[] b = Text.Split(" ");
                //double[] b1 = new double[b.Length];
                //for (int i = 0; i < b.Length; i++)
                //{
                //    b1[i] = Convert.ToDouble(b[i]);
                //}
                //Console.WriteLine($"a+b={b1[0] + b1[1]},a*b={b1[0] * b1[1]},a+b^2={b1[0] + Math.Pow(b1[1], 2)}");

                ////Задaние 4.b
                //a = new FileStream(@"..\..\basedir\data\dataset_2.txt", FileMode.Open);
                //buffer = new byte[a.Length];
                //a.Read(buffer, 0, buffer.Length);
                //Text = Encoding.Default.GetString(buffer);
                //b = Text.Split("\n");
                //int count = 0;
                //for (int i = 0; i < b.Length; i++)
                //{
                //    if (Convert.ToDouble(b[i]) % 2 == 0)
                //    {
                //        count++;
                //    }
                //}
                //Console.WriteLine("количество четных чисел:" + count);

                ////Задaние 4.c
                //var myFile = File.CreateText(@"..\..\basedir\data\res_3.txt");
                //myFile.Close();
                //a = new FileStream(@"..\..\basedir\data\dataset_3.txt", FileMode.Open);
                //buffer = new byte[a.Length];
                //a.Read(buffer, 0, buffer.Length);
                //Text = Encoding.Default.GetString(buffer);
                //b = Text.Split(" ");
                //StringBuilder stringBuilder = new StringBuilder();
                //foreach (string temp in b)
                //{
                //    if (Convert.ToDouble(temp) < 9999)
                //    {
                //        Console.Write(temp + " ");
                //        stringBuilder.Append(temp);
                //        stringBuilder.Append(" ");
                //    }
                //}
                //using (FileStream fileStream = new FileStream(@"..\..\basedir\data\res_3.txt", FileMode.OpenOrCreate))
                //{
                //    byte[] array = Encoding.Default.GetBytes(stringBuilder.ToString());
                //    fileStream.Write(array, 0, array.Length);
                //    fileStream.Close();
                //}
                //Console.WriteLine("Числа добавлены");
                //Console.WriteLine();

                ////Задaние 4.d
                //a = new FileStream(@"..\..\basedir\data\dataset_4.txt", FileMode.Open);
                //buffer = new byte[a.Length];
                //a.Read(buffer, 0, buffer.Length);
                //Text = Encoding.Default.GetString(buffer);
                //b = Text.Split(" ");
                //double max = 0;
                //foreach (string temp in b)
                //{
                //    if (Convert.ToDouble(temp) > max)
                //        max= Convert.ToDouble(temp);
                //}
                //Console.WriteLine(max);
                //using (FileStream fileStream = new FileStream(@"..\..\basedir\data\res_3.txt", FileMode.Append))
                //{
                //    byte[] array = Encoding.Default.GetBytes(max.ToString());
                //    fileStream.Write(array, 0, array.Length);
                //    fileStream.Close();
                //}
                //Console.WriteLine("Число добавлено");
                //Console.WriteLine();

                ////Задaние 4.e
                //a = new FileStream(@"..\..\basedir\data\dataset_5.txt", FileMode.Open);
                //buffer = new byte[a.Length];
                //a.Read(buffer, 0, buffer.Length);
                //Text = Encoding.Default.GetString(buffer);
                //b = Text.Split(" ");
                //foreach (string temp in b)
                //{
                //    Console.WriteLine(temp.ToUpper());
                //}
                #endregion

                #region 5
                //Задание 5.а
                var er = File.Create(@"D:\Users\Zerox\PROECTS_VS\laba10\laba10\bin\basedir\data\person.txt");
                er.Close();
                DateTime a1 = new DateTime(2000, 5, 3);
                DateTime b1 = new DateTime(1998, 6, 12);
                DateTime c1 = new DateTime(2005, 6, 6);
                LD[] arr = new LD[3];
                arr[0] = new LD("Петров", 170, 100, a1);
                arr[1] = new LD("Иванов", 150, 58, b1);
                arr[2] = new LD("Санечкин", 174, 65, c1);
                LD d = new LD();
                //d.input();
                LD e = new LD();
                //e.input();
                using (FileStream fileStream = new FileStream(@"..\..\basedir\data\person.txt", FileMode.Open))
                {
                    foreach (LD a in arr)
                    {
                        byte[] array = Encoding.Default.GetBytes(a.ToString());
                        fileStream.Write(array, 0, array.Length);
                    }
                    byte[] array1 = Encoding.Default.GetBytes(d.ToString());
                    fileStream.Write(array1, 0, array1.Length);
                    array1 = Encoding.Default.GetBytes(e.ToString());
                    fileStream.Write(array1, 0, array1.Length);
                    fileStream.Close();
                }

                //5.б
                using (FileStream fls = new FileStream(@"..\..\basedir\data\person.txt", FileMode.Open))
                {
                    byte[] buffer = new byte[fls.Length];
                    fls.Read(buffer, 0, buffer.Length);
                    string Text = Encoding.Default.GetString(buffer);
                    string[] arrm = Text.Split('\n');
                    double sredLen = 0;
                    double sredVeig = 0;
                    for (int i = 0; i < arrm.Length - 1; i++)
                    {
                        string[] subarm = arrm[i].Split(new char[] { Convert.ToChar(" "), Convert.ToChar("\n"), Convert.ToChar(":"), Convert.ToChar(";") });
                        Console.WriteLine(subarm[1] + " " + subarm[10] + " лет");
                        sredLen += Convert.ToDouble(subarm[4]);
                        sredVeig += Convert.ToDouble(subarm[7]);
                    }
                    sredLen /= 5;
                    sredVeig /= 5;
                    Console.WriteLine("средний рост в этой группе:" + sredLen);
                    Console.WriteLine("средний вес в этой группе:" + sredVeig);

                    string Len = "средний рост в этой группе:" + sredLen + "\n";
                    string Vei = "средний вес в этой группе:" + sredVeig + "\n";
                    byte[] array = Encoding.Default.GetBytes(Len);
                    fls.Write(array, 0, array.Length);
                    array = Encoding.Default.GetBytes(Vei);
                    fls.Write(array, 0, array.Length);
                    fls.Close();
                }

                //5.в
                Console.WriteLine("Данные тех,кто имеет избыточный вес:");
                var creat = File.Create(@"..\..\basedir\data\new.txt");
                creat.Close();
                using (FileStream fls1 = new FileStream(@"..\..\basedir\data\new.txt", FileMode.Open))
                {
                    var tone = new FileStream(@"..\..\basedir\data\person.txt", FileMode.Open);
                    byte[] buffer = new byte[tone.Length];
                    tone.Read(buffer, 0, buffer.Length);
                    string Text = Encoding.Default.GetString(buffer);
                    string[] arrm = Text.Split('\n');
                    Text = "Данные тех,кто имеет избыточный вес:" + "\n";
                    byte[] array = Encoding.Default.GetBytes(Text.ToString() + "\n");
                    fls1.Write(array, 0, array.Length);
                    for (int i = 0; i < arrm.Length - 3; i++)
                    {
                        string[] subarm = arrm[i].Split(new char[] { Convert.ToChar(" "), Convert.ToChar("\n"), Convert.ToChar(":"), Convert.ToChar(";") });
                        if (Convert.ToDouble(subarm[7]) > Convert.ToDouble(subarm[4]) - 100 + 10)
                        {
                            Console.WriteLine(arrm[i]);
                            array = Encoding.Default.GetBytes(arrm[i].ToString() + "\n");
                            fls1.Write(array, 0, array.Length);
                        }
                    }
                    fls1.Close();
                }
                #endregion
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка " + e.Message);
            var trace = new StackTrace(e, true);

            foreach (var frame in trace.GetFrames())
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Строка: {frame.GetFileLineNumber()}");
                Console.WriteLine(sb);
            }
        }
        finally
        {
            Console.WriteLine("Программа завершилась");
        }
    }
}