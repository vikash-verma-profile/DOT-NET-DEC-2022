using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetryPattern
{
    //Predicate Delegate
    //public delegate bool Predicate<>()
    internal class Class3
    {
        //public delegate bool SampleDelegate (string sampleString);

        public static bool TestStringLength(string sampleString)
        {
            if (sampleString.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main4()
        {
            //SampleDelegate sample = TestStringLength;
            Predicate<string> sample = TestStringLength;
            Console.WriteLine(sample("Vikash"));
        }
    }
}
