using System.Collections;
using System.Linq;
using System.Globalization;

namespace study_hello.classes
{
    public static class HackerHank
    {
        // Minimum sum
        // https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen
        public static void minMaxSum(List<int> arr)
        {
            List<int> arr2 = arr.OrderBy(i => i).ToList();
            Int64 min = 0;
            Int64 max = 0;

            for (int i = 0; i < arr2.Count() - 1; i++)
            {
                min += arr2[i];
            }

            for (int i = arr2.Count() - 1; i > 0; i--)
            {
                max += arr2[i];
            }

            Console.WriteLine($"{min} {max}");
        }

        /*
        * Complete the 'timeConversion' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts STRING s as parameter.
        */

        public static string timeConversion(string s)
        {
            DateTime t = DateTime.ParseExact(s, "h:mm:sstt", CultureInfo.InvariantCulture);
            return string.Format("{0:HH:mm:ss}", t);
        }

        /// <summary>
        /// Return the median element of a list with even number of elements after sorted
        ///
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int median(List<int> arr)
        {
            List<int> srt = arr.OrderBy(i => i).ToList();
            int m = srt.Count() / 2;
            return srt[m];
        }
    }
}