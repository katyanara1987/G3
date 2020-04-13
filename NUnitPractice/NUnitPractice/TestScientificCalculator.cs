using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
class TestScientificCalculator
{
    ScientificCalculator calculator = new ScientificCalculator();
    List<int> test = new List<int> { 1, 2, 3, 4 };

    [TestCase]
    public void CheckSumMethod()
    {
        Assert.That(test, Is.All.GreaterThan(0).And.LessThan(100), "Test Data is valid");
        Assert.That(calculator.Sum(test), Is.Not.Zero, "Sum of values greater than 0 could not be zero");
    }

    [TestCase]
    public void CheckMaxMethod()
    {
        Assert.That(test, Has.Exactly(4).Items.And.All.GreaterThanOrEqualTo(0), "Test Data is valid");
        Assert.That(calculator.Max(test), Is.Not.Zero, "Max values between 0 and greater than 0 could not be zero");
    }

}
