using NUnit.Framework;
using Microsoft.OData.Edm;
using System.Diagnostics;

[TestFixture]
class TestCalculator
{
    Calculator calculator = new Calculator();
    Date TestsRunStart;
    Date TestsRunFinish;

    [OneTimeSetUp]
    public void Init()
    {
        TestsRunStart = Date.Now;
    }

    [Test(ExpectedResult = 0), Description("Check that multiply to zero is always 0")]
    public double CheckMultiplyToZero()
    {
        return calculator.Multiply(4, 0);
    }


    [TestCase(2, 4, 6), Description("Check successfull Addition")]
    public void SuccessAdd(int x, int y, int result)
    {
        Assert.That(calculator.Add(x, y), Is.EqualTo(result));
    }

    [Description("Check successfull Multiplying")]
    [TestCase(2, 4, 8, "Int values are successfully multiplied")]
    [Retry(15)]
    [TestCase(2, 0.1, 0.02, "Combined types are successfully multiplied")]
    public void SuccessMultiply(double x, double y, double result, string message)
    {
        Assert.That(calculator.Multiply(x, y), Is.EqualTo(result), $"test : {message}");
    }

    [TestCase(2, 0, "Can't divide to Zero", "Check divide to Zero")]
    [Repeat(15)]
    public void DivideToZero(double x, double y, string result, string message)
    {
        Assert.That(calculator.Divide(x, y), Does.Contain(result), $"test : {message}");
    }

    [OneTimeTearDown]
    public void Finish()
    {
        TestsRunFinish = Date.Now;
        Debug.WriteLine($"TestsRunStart: { TestsRunStart} TestsRunFinish: {TestsRunFinish}");
    }

}
