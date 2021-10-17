using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakSaBiljkom_EM
{
    class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno hrast = new Bjelogoricno(true);
            Crnogoricno bor = new Crnogoricno(false);

            Console.WriteLine($"Je li palo lisce sa hrasta {hrast.OpadajuListovi}");
            Console.WriteLine();
            Console.WriteLine($"Je li palo lisce sa bora {bor.OpadajuListovi}");

            Console.ReadKey();
        }
    }
}
