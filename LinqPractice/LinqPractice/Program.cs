using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq linq = new Linq();
            linq.ReturnNoDuplicates();
            linq.ReturnAverage();
            linq.StringAlphabeticalFrequency();
        }
    }
}
