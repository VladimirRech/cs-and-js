using System.Globalization;

namespace study_hello.classes
{
    public static class HackerHank
    {
        public static List<int> countingSort(List<int> arr)
        {
            // Cria o array de retorno
            List<int> ret = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                ret.Add(0);
            }

            // Faz a contagem
            foreach (int item in arr)
            {
                ret[item]++;
            }

            ret.ForEach(obj => Console.Write($"{obj} "));

            return ret;
        }

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

        public static int LonelyInteger(List<int> arr)
        {
            List<int> lst = arr.Distinct().ToList();

            for (int i = 0; i < lst.Count(); i++)
            {
                if (arr.Count(obj => obj == lst[i]) == 1)
                {
                    return lst[i];
                }
            }

            return -1;
        }

        /// <summary>
        /// Calculates the diagonal difference in elements of an quadradict array
        /// See related test cases to better comprehension.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int diagonalDifference(List<List<int>> arr)
        {
            var diag1 = 0;
            var diag2 = 0;
            int j = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                diag1 += arr[i][i];
            }

            for (int i = arr.Count() - 1; i >= 0; i--)
            {
                j = arr.Count() - 1 - i;
                diag2 += arr[i][j];
            }

            return System.Math.Abs(diag1 - diag2);
        }

        public static int flipMatrix(List<List<int>> matrix)
        {
            int ret = 0;

            // Lista de troca
            List<int> lstSwap = new List<int>();
            int col = matrix[0].Count() / 2;

            for (int i = matrix[0].Count() - 1; i >= 0; i--)
            {
                lstSwap.Add(matrix[i][col]);
            }

            for (int i = 0; i < lstSwap.Count(); i++)
            {
                matrix[i][col] = lstSwap[i];
            }

            matrix[0].Reverse();

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    ret += matrix[i][j];
                }
            }

            return ret;
        }

        public static int flipMatrixb(List<List<int>> matrix)
        {
            // vetor final
            int swap = 0;
            // indexador do vetor final
            int iFinal = 0;
            int finalX = 0;
            int finalY = 0;
            int ret = 0;

            // iterador principal
            for (int i = 0; i < 2; i++)
            {
                finalX = i == 0 ? matrix[0].Count - 1 : matrix[0].Count / 2;

                for (int j = 0; j < 2; j++)
                {
                    swap = 0;
                    finalY = j == 0 ? matrix[0].Count - 1 : matrix[0].Count / 2;

                    if (matrix[i][j] > swap)
                    {
                        swap = matrix[i][j];
                    }

                    if (matrix[i][finalY] > swap)
                    {
                        swap = matrix[i][finalY];
                    }

                    if (matrix[finalX][j] > swap)
                    {
                        swap = matrix[finalX][j];
                    }

                    if (matrix[finalX][finalY] > swap)
                    {
                        swap = matrix[finalX][finalY];
                    }

                    ret += swap;
                    iFinal++;
                }
            }

            return ret;
        }

        public static int FlipMatrixMultiColun(List<List<int>> lstMatrix)
        {
            int matrixMaxColumnIndex = lstMatrix[0].Count() - 1
                , matrixMaxRowIndex = lstMatrix[0].Count() - 1
                , matrixHalStepIndex = lstMatrix[0].Count() / 2;
            int startX1 = 0;
            int startX2 = matrixMaxRowIndex;
            int startY1 = 0;
            int startY2 = matrixMaxColumnIndex;
            int endX1 = matrixHalStepIndex;
            int endY1 = endX1;

            // Console.WriteLine($"startX1: {startX1}\n\rstartX2: {startX2}\r\nstartY1: {startY1}\r\nstartY2: {startY2}\r\nendX1: {endX1}");
            int swap = 0;
            int ret = 0;

            while (startX1 < endX1)
            {
                while (startY1 < endY1)
                {
                    swap = lstMatrix[startX1][startY1] > swap ? lstMatrix[startX1][startY1] : swap;
                    swap = lstMatrix[startX1][startY2] > swap ? lstMatrix[startX1][startY2] : swap;
                    swap = lstMatrix[startX2][startY1] > swap ? lstMatrix[startX2][startY1] : swap;
                    swap = lstMatrix[startX2][startY2] > swap ? lstMatrix[startX2][startY2] : swap;
                    ret += swap;
                    swap = 0;
                    startY1++;
                    startY2--;
                }

                startX1++;
                startX2--;
                startY1 = 0;
                startY2 = matrixMaxColumnIndex;
            }

            return ret;
        }
    }
}
