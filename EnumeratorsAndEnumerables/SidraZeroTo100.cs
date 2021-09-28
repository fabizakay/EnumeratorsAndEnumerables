using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    public class Sidra10To100 : IEnumerable<int>
    {

        //    int i = 0;
        //    bool MoveNext()
        //    {
        //        if (i <= 10)
        //        {
        //            i++;
        //            return true;
        //        }

        //        return false;
        //    }
        //    void Reset()
        //    {
        //        i = 0;
        //    }

        //    int Current { get { return i*10} }


        //    public IEnumerator<int> GetEnumerator()
        //    {
        //        return 
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return  i * 10;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
