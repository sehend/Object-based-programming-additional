using System;
using System.Collections;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int kar = r.Next(1, 2); //Sonradan kaldırılmalı

            Canavar canav = new Game.Canavar("Yabani", r.Next(4, 10));

            for (;;)
            {
                Console.Write("Karakter Seç =>1\n");
                Console.Write("Oyundan Çık  =>2\n");
                int menu1 = int.Parse(Console.ReadLine());
                if (menu1 == 1)
                {
                    if (kar == 1)
                    {
                        Savasci savas = new Savasci("Karakter");

                        Console.Clear();

                        for(int i=0;i<100;i++)
                        {
                            Console.WriteLine("Round {0}", i);
                            Console.WriteLine("Savaşçı HP: {0}", savas.Yasam);
                            Console.WriteLine("Canavar HP: {0}", canav.Yasam);
                            Console.WriteLine("Savaşçı LVL: {0}", savas.Level);
                            Console.WriteLine("Canavar LVL: {0}", canav.Level);

                            Console.WriteLine("Vurmak için herhangi bir tuşa basınız");
                            Console.ReadKey();
                            int hasar = savas.Vur(canav);
                            canav.DarbeAl(hasar);
                            Console.WriteLine("Canavaraa {0} hasar verildi", hasar);
                            Console.WriteLine("Savaşçı HP: {0}", savas.Yasam);
                            Console.WriteLine("Canavar HP: {0}", canav.Yasam);
                            Console.WriteLine("Savaşçı LVL: {0}", savas.Level);
                            Console.WriteLine("Canavar LVL: {0}", canav.Level);

                            Console.WriteLine("Savunma için herhangi bir tuşa basınız.");
                            Console.ReadKey();

                            hasar = canav.Vur(savas);
                            savas.DarbeAl(hasar);
                            Console.WriteLine("{0} hasar aldınız", hasar);
                            Console.WriteLine("Savaşçı HP: {0}", savas.Yasam);
                            Console.WriteLine("Canavar HP: {0}", canav.Yasam);
                            Console.WriteLine("Savaşçı LVL: {0}", savas.Level);
                            Console.WriteLine("Canavar LVL: {0}", canav.Level);

                            if (!savas.Dirimi)
                            {
                                Console.WriteLine("Öldün ve Oyun Bitti, Kazanamadın");
                                break;
                            }
                            if (!canav.Dirimi)
                            {
                                Console.WriteLine("Canavarı öldürdün, Kazandın");
                                break;
                            }
                        }
                        
                    }
                }


                else if (menu1 == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız.");
                }
            }
        }
    }
}
