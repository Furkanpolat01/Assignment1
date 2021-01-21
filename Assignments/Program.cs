using System;

namespace odev1
{


    class MainClass
    {
        static void Main(string[] args)
        {
            Kıtaplar kıtap1 = new Kıtaplar();
            kıtap1.yazar = "can yücel";
            kıtap1.ısım = "gezintiler";
            kıtap1.sayfaSayısı = 96;

            Kıtaplar kıtap2 = new Kıtaplar();
            kıtap2.yazar = "h.n. atsız";
            kıtap2.ısım = "bozkurtlar";
            kıtap2.sayfaSayısı = 584;


            Kıtaplar kıtap3 = new Kıtaplar();
            kıtap3.yazar = "turgut özakman";
            kıtap3.ısım = "cumhuriyet II";
            kıtap3.sayfaSayısı = 845;


            Kıtaplar[] kıtaplar = new Kıtaplar[] { kıtap1, kıtap2, kıtap3 };


            Console.WriteLine("-----for döngüsü-----");

            for (int i = 0; i < kıtaplar.Length; i++)
            {
                Console.WriteLine(kıtaplar[i].yazar + "---" + kıtaplar[i].ısım + "---" + kıtaplar[i].sayfaSayısı);
            }

            Console.WriteLine("-----foreach döngüsü-----");

            foreach (var kıt in kıtaplar)
            {
                { Console.WriteLine(kıt.yazar + "---" + kıt.ısım + "---" + kıt.sayfaSayısı); }
            }



            Console.WriteLine("-----while döngüsü-----");

            int a = 0;
            while (a < kıtaplar.Length)
            {
                Console.WriteLine(kıtaplar[a].yazar + "---" + kıtaplar[a].ısım + "---" + kıtaplar[a].sayfaSayısı);
                a++;
            }
        }
    }
    class Kıtaplar
    {
        public string yazar { get; set; }
        public string ısım { get; set; }
        public int sayfaSayısı { get; set; }
    }

}
