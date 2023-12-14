using System;
using System.Threading;

namespace bayrak
{
    internal class Programb
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            string[] bayrakDizi = new string[16];
            bayrakDizi[0] = "                    *************                                          ";
            bayrakDizi[1] = "                  *****************                                        ";
            bayrakDizi[2] = "                ******            **                                       ";
            bayrakDizi[3] = "               ******               *                      *               ";
            bayrakDizi[4] = "              ******                                      ***              ";
            bayrakDizi[5] = "             ******                                      *****             ";
            bayrakDizi[6] = "            *******                              ***********************   ";
            bayrakDizi[7] = "            *******                                  ***************       ";
            bayrakDizi[8] = "            *******                                    **********          ";
            bayrakDizi[9] = "            *******                                   ****    ****         ";
            bayrakDizi[10] = "             ******                                  ***        ***        ";
            bayrakDizi[11] = "              ******                                *              *       ";
            bayrakDizi[12] = "               ******              *                                       ";
            bayrakDizi[13] = "                ******            **                                       ";
            bayrakDizi[14] = "                  *****************                                        ";
            bayrakDizi[15] = "                    *************                                          ";

            int tekrarSayisi = 10; //her efekt kaç kez tekrarlancak.
            for (int tekrar = 0; tekrar < tekrarSayisi; tekrar++)
            {
                Console.Clear();


                for (int i = 0; i < 16; i++)
                {
                    Console.WriteLine(bayrakDizi[i]);
                    Thread.Sleep(100); // hız ayarı
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Clear();
                    Thread.Sleep(100); //parlama süre ayarları.
                    Console.WriteLine();
                    Thread.Sleep(100);
                    Console.WriteLine(string.Join(Environment.NewLine, bayrakDizi));
                    Thread.Sleep(100);
                }
            }
        }
    }
}

