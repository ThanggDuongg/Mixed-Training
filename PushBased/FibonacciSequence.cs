using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushBased
{
    public class FibonacciSequence
    {
        public IEnumerable<int> GetSequence()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int temp = next;
                next = current + next;
                current = temp;
            }
        }
    }
}
