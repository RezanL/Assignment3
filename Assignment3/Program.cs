using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
          var array1 = new[] {1,2,3,4,5};
          
          var array2 = new[] {5,4,1,3,2};

          int numberOfElements = 5;

          var checker = new HashSet<int>(array1).SetEquals(array2);

          if (checker == true && numberOfElements == array1.Length && numberOfElements == array2.Length)
          {
              Console.WriteLine("True");
          }

          else
          {
              Console.WriteLine("False");
          }

          Console.ReadKey();
        }
    }
}
