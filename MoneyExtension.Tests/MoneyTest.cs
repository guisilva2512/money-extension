namespace MoneyExtension.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShouldReturnsCents()
    {
        var valor = 1299.95m;

        var cents = valor.ToCents();

        Assert.AreEqual(129995, cents);
    }
}