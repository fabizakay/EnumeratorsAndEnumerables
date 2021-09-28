using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Hezka
    {
        public Hezka(int num1)
        {
            Num1 = num1;
        }

        public int Num1 { get; set; }
        public int sum = 1;


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= Num1; i++)
            {
                yield return sum = sum*Num1;
            }
        }

        
    }
}

