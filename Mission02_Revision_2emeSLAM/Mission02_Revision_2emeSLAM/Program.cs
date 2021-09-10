using System;

namespace Mission02_Revision_2emeSLAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1, c2;
            c1 = new Compte(12345, "toto", 1000, -500);
            c2 = new Compte(45657, "titi", 2000, -1000);
            if (c1.superieur(c2))
                Console.WriteLine("superieur");
            else
                Console.WriteLine("inférieur");



        }
    }
}
