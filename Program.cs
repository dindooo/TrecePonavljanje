using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaTreca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite niz znakova!!!");
            string niz = Console.ReadLine();
            string sVelika = niz.ToUpper();
            string sMala = niz.ToLower();
            string sPrvaTri = niz.Substring(0, 2);
            string sZadnjihPet = niz.Substring(niz.Length-5, 5);
            string s8_11 = niz.Substring(8, 3);

            Console.WriteLine("Velika slova : "+sVelika);
            Console.WriteLine("Mala slova : "+sMala);
            Console.WriteLine("Prva tri znaka : "+sPrvaTri);
            Console.WriteLine("Zadnjih pet znakova : "+sZadnjihPet);
            if (niz.Length >= 11)
            {
                Console.WriteLine("Od osmog do jedaneastog znaka : " + s8_11);
            }

            Console.ReadKey();
        }
    }
}
