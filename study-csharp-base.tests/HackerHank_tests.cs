using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System;

namespace study_csharp_base.tests;

[TestFixture]
public class HackerHank_tests
{
    // [SetUp]
    // public void Setup()
    // {
    // }Console.WriteLine(str); mais o resultado de Expected.
    [Test]
    public void HackerHank_median_IsTrueMedianValue()
    {
        List<int> lst = (new int[] { 0, 2, 1, 5, 4, 3 }).ToList();
        int expected = 3;
        int returned = study_hello.classes.HackerHank.median(lst);
        Assert.IsTrue(returned == expected, "Should be 3.");
    }

    [Test]
    public void HackerHank_LonelyInteger_IsTrueLonelyInt()
    {
        List<int> lst = (new int[] { 1, 2, 3, 4, 3, 2, 1 }).ToList();
        int expected = 4;
        int returned = study_hello.classes.HackerHank.LonelyInteger(lst);
        Assert.IsTrue(expected == returned, "It should be 4.");
    }

    [TestCase("0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0", 5)]
    [TestCase("10, 11, 11, 9, 8, 10, 9", 8)]
    [TestCase("10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1", 0)]
    public void HackerHank_LonelyInteger_IsTrueLonelyIntMany(string given, int expected)
    {
        List<int> lst = new List<int>();

        foreach (string item in given.Split(','))
        {
            lst.Add(int.Parse(item));
        }

        int returned = study_hello.classes.HackerHank.LonelyInteger(lst);
        Assert.IsTrue(returned == expected, $"It should be {expected} it is {returned}");
    }

    [Test]
    public void HakerHank_diagonalDifference_IsTrue()
    {
        List<List<int>> lst = new List<List<int>>();
        lst.Add((new int[] { 1, 2, 3 }.ToList()));
        lst.Add((new int[] { 4, 5, 6 }.ToList()));
        lst.Add((new int[] { 9, 8, 9 }.ToList()));
        int expected = 2;
        int returned = study_hello.classes.HackerHank.diagonalDifference(lst);
        Assert.IsTrue(expected == returned, $"It should be 2, it is {returned}.");
    }

    [TestCase("1 2 3", "4 5 6", "9 8 9", 2)]
    [TestCase("1 2 3", "4 5 6", "7 8 9", 0)]
    [TestCase("10 20 30", "14 15 16", "7 8 9", 18)]
    public void HackerHank_diagonalDifference_IsTrueMultiple(string arr1, string arr2, string arr3, int expected)
    {
        List<List<int>> lst = new List<List<int>>();
        List<int> lstSwap = new List<int>();
        arr1.Split(' ').ToList().ForEach(o => lstSwap.Add(int.Parse(o)));
        lst.Add(lstSwap);

        lstSwap = new List<int>();
        arr2.Split(' ').ToList().ForEach(o => lstSwap.Add(int.Parse(o)));
        lst.Add(lstSwap);

        lstSwap = new List<int>();
        arr3.Split(' ').ToList().ForEach(o => lstSwap.Add(int.Parse(o)));
        lst.Add(lstSwap);

        int returned = study_hello.classes.HackerHank.diagonalDifference(lst);
        Assert.IsTrue(expected == returned, $"It should be 2, it is {returned}.");
    }

    [Test]
    public void HackerHank_TestMatrixSum()
    {
        List<List<int>> matrix = new List<List<int>>();
        matrix.Add((new int[] { 112, 42, 83, 119 }).ToList<int>());
        matrix.Add((new int[] { 56, 125, 56, 49 }).ToList());
        matrix.Add((new int[] { 15, 78, 101, 43 }).ToList());
        matrix.Add((new int[] { 62, 98, 114, 108 }).ToList());
        int expected = 414;
        int returned = study_hello.classes.HackerHank.flipMatrix(matrix);
        Assert.AreEqual(expected, returned, 0, $"It should be {expected} it is {returned}.");
    }

    [TestCase("0 0 0 0 0 1|0 0 0 0 0 0|0 0 0 0 0 0|0 0 0 0 0 0|0 0 0 0 0 0|0 0 0 1 0 0", 2)]
    [TestCase("1 2|3 4", 4)]
    public void HackerHank_TestFlipMatrixAnyQuadradic_True(string arr, int expected)
    {
        string[] arr1 = arr.Split('|');
        List<List<int>> lst = new List<List<int>>();
        List<int> swap;

        foreach (string item in arr1)
        {
            string[] arr2 = item.Split(' ');
            swap = new List<int>();

            foreach (string str in arr2)
            {
                swap.Add(int.Parse(str));
            }

            lst.Add(swap);
        }

        int actual = study_hello.classes.HackerHank.flipMatrix(lst);
        Assert.AreEqual(expected, actual, 0, $"It should be {expected} it is {actual}.");
    }

    [Test]
    public void HackerHank_FlipMatrixb_True()
    {
        List<List<int>> matrix = new List<List<int>>();
        matrix.Add((new int[] { 112, 42, 83, 119 }).ToList());
        matrix.Add((new int[] { 56, 125, 56, 49 }).ToList());
        matrix.Add((new int[] { 15, 78, 101, 43 }).ToList());
        matrix.Add((new int[] { 62, 98, 114, 108 }).ToList());
        int expected = 414;
        int actual = study_hello.classes.HackerHank.flipMatrixb(matrix);
        Assert.AreEqual(expected, actual, 0, $"It should be {expected} it is {actual}.");
    }

    [TestCase("88, 61, 186, 28 | 38, 123, 137, 111 | 153, 153, 114, 133 | 194, 65, 94, 86", 686)]
    [TestCase("112, 42, 83, 119 | 56, 125, 56, 49 | 15, 78, 101, 43 | 62, 98, 114, 108", 414)]
    [TestCase("185, 19, 166, 50 | 59, 83, 101, 149 | 128, 178, 182, 101 | 93, 54, 79, 0", 682)]
    [TestCase("154, 34, 52, 72 | 172, 59, 110, 125 | 148, 155, 177, 42 | 52, 155, 34, 159", 663)]
    public void HackerHank_FlipMatrixbMany_True(string arr, int expected)
    {
        string[] arr1 = arr.Split('|');
        List<List<int>> lst = new List<List<int>>();
        List<int> swap;

        foreach (string item in arr1)
        {
            string[] arr2 = item.Split(',');
            swap = new List<int>();

            foreach (string str in arr2)
            {
                swap.Add(int.Parse(str));
            }

            lst.Add(swap);
        }

        int actual = study_hello.classes.HackerHank.flipMatrixb(lst);
        Assert.AreEqual(expected, actual, 0, $"It should be {expected} it is {actual}.");
    }

    [TestCase("120 175|200 83", 200)]                                                    // 2 x 2
    [TestCase("88 61 186 28|38 123 137 111|153 153 114 133|194 65 94 86", 686)]          // 4 x 4
    [TestCase("169 179 105 166 5 156|84 50 5 146 162 108|114 168 157 104 109 153|" +     // 6 x 6
              "132 84 168 150 92 175|126 101 63 87 170 2|4 189 135 196 157 174", 1512)]
    [TestCase("22 9 16 192 164 36 58 80|122 59 77 76 144 59 151 149|" +                  // 8 x 8
              "10 149 163 78 177 164 193 155|100 91 149 59 185 40 6 82|" +
              "57 186 147 83 132 78 133 8|163 29 41 100 9 144 161 80|" +
              "22 61 171 76 90 52 23 116|49 175 171 73 82 79 5 138", 2608)]
    public void HackerHank_FlipMatrixMultiDim_True(string arr, int expected)
    {
        string[] arrLines = arr.Split('|');
        var lstMatrix = new List<List<int>>();
        List<int> lstSwap;

        foreach (string item in arrLines)
        {
            string[] arrNumbers = item.Split(' ');
            lstSwap = new List<int>();

            foreach (string str in arrNumbers)
            {
                lstSwap.Add(int.Parse(str));
            }

            lstMatrix.Add(lstSwap);
        }

        int actual = study_hello.classes.HackerHank.FlipMatrixMultiColun(lstMatrix);
        Assert.AreEqual(expected, actual, 0, $"It should be {expected} it is {actual}.");

    }
}