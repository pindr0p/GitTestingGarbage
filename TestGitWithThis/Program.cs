using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitWithThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI 2");
            var data = new List<int>(){ 1,2,6,7,3,4,5,6,7,3,5,53,354,534,534,534,534,534,534,
                534,5,534,53,53,534,534,534,534,534,534,54,534,354,543,543,345,5,
                34,534,354,534,354,5,43,354,4,45,5,34, 9, 8};
            data.ForEach(num => Console.WriteLine(num * (new Random(786789).Next())));
            Console.ReadKey();
        }
    }
}
