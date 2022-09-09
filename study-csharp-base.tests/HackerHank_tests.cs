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
}