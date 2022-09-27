using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using study_csharp_base;

namespace study_csharp_base.tests;

[TestFixture]
public class HackerHank_tests
{
    // [SetUp]
    // public void Setup()
    // {
    // }


    // Criar teste com vários parâmetros e mais o resultado de Expected.
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
}