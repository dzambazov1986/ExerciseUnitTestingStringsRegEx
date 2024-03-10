using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [TestCase("John Smith and Alice Johnson", "John Smith Alice Johnson")]
    [TestCase("Dimityr Robertov is here", "Dimityr Robertov")]
    [TestCase("Hello,Dimityr Robertov", "Dimityr Robertov")]
    [TestCase("Hello,Dimityr Robertov my friend", "Dimityr Robertov")]
    [TestCase("Hello,Dimityr my friend", "")]
    [TestCase("Dimityr", "")]
    [TestCase("Dimityr Robertov", "Dimityr Robertov")]
    [TestCase("Dimityr robertov", "")]
    [TestCase("dimityr robertov", "")]
    [TestCase("", "")]
    [TestCase("Dimityr-Robertov", "")]
    [TestCase("Dimityr  Robertov", "")]
    public void Test_Match_ValidNames_ReturnsMatchedNames(string input, string expected)
    {
       
        // Act
        string result = MatchNames.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // TODO: finish the test
    }
}
