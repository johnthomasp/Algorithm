using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class TowerOfHanoi
    {
        private static void towerOfHanoi(int n, char src, char aux, char dest)
        {
            if (n>0)
            {
                towerOfHanoi(n-1, src, dest, aux);
                Console.WriteLine("Move disk {0} from rod {1} to rod {2}", n, src, dest);
                towerOfHanoi(n-1, aux, src, dest);
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            towerOfHanoi(n, 'A', 'B', 'C');
            Console.ReadLine();
        }
    }
}
