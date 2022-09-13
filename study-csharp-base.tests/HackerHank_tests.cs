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
        List<int> lst = (new int[] {1, 2, 3, 4, 3, 2, 1}).ToList();
        int expected = 4;
        int returned = study_hello.classes.HackerHank.LonelyInteger(lst);
        Assert.IsTrue(expected == returned, "It should be 4.");
    }
}