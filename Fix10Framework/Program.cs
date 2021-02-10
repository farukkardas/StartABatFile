using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix10Framework
{
    class Program
    {



        static void Main(string[] args)
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("                                          FIX 10/30 Min  -  Wiwy");
            Console.WriteLine();
            if (Console.ForegroundColor == ConsoleColor.Blue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("10/30 dakika ban sorununu çözmek için bekleme alanındayken 1'e öldüğünüzde veya kazandığınızda 2 ye basınız!");
            Console.WriteLine();
            Console.WriteLine("1. Bekleme Alanı");
            Console.WriteLine("2. Öldüğünüzde veya Kazandığınızda");


                


            while (true)
            {
                Console.Write("Seçim: ");
                var secim = Console.ReadKey();
                if (secim.Key == ConsoleKey.D1 || secim.Key == ConsoleKey.NumPad2)
                {




                    try
                    {
                        Process proc = null;
                        string batDir = Directory.GetCurrentDirectory();
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = batDir;
                        proc.StartInfo.FileName = "spawn_island.bat";
                        proc.StartInfo.CreateNoWindow = true;
                        proc.Start();
                        proc.WaitForExit();

                        if (Console.ForegroundColor == ConsoleColor.Red)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        Console.WriteLine(" - Dosya başarılı bir şekilde çalıştırıldı!");

                        if (Console.ForegroundColor == ConsoleColor.Green)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(" - Bat dosyası bulunamadı veya çalıştırılamadı!");
                    }
                }
                else if (secim.Key == ConsoleKey.D2 || secim.Key == ConsoleKey.NumPad2)
                {
                    try
                    {
                        Process proc = null;
                        string batDir = Directory.GetCurrentDirectory();
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = batDir;
                        proc.StartInfo.FileName = "reset.bat";
                        proc.StartInfo.CreateNoWindow = true;
                        proc.Start();
                        proc.WaitForExit();

                        if (Console.ForegroundColor == ConsoleColor.Red)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        Console.WriteLine(" - Dosya başarılı bir şekilde çalıştırıldı!");

                        if (Console.ForegroundColor == ConsoleColor.Green)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(" - Bat dosyası bulunamadı veya çalıştırılamadı!");
                        //Console.WriteLine(ex.StackTrace.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(" - Yanlış seçim!");
                }
            }


        }

    }
}
