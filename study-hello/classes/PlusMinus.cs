//
// Plus Minus - Teste do link: https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one
//
using System.Linq;
using System;
using System.Collections.Generic;

namespace study_hello.classes
{
    public class PlusMinus 
    {
        public static void plusMinus(List<int> arr)
        {
            float elements = arr.Count();
            float n = arr.Where(i => i >= 1).Count();
            Console.WriteLine("{0:n6}", n / elements);
            n = arr.Where(i => i <= -1).Count();
            Console.WriteLine("{0:n6}", n / elements);
            n = arr.Where(i => i == 0).Count();
            Console.WriteLine("{0:n6}", n / elements);
        }
    }
}
