using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [TestCase(new string[] { }, "")]
    [TestCase(new string[] { "" }, "")]
    [TestCase(new string[] { " " }, "")]
    [TestCase(new string[] { "Mitko" }, "Mitko")]
    [TestCase(new string[] { "Plovdiv", "Sofia", "Pernik" }, "PernikSofiaPlovdiv")]
    [TestCase(new string[] { null }, "")]
    [TestCase(null, "")]
    [TestCase(new string[] { "Plovdiv Sofia", "Pernik Varna", "Burgas Ruse" },"Burgas Ruse Pernik Varna Plovdiv Sofia")]

    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString(
        string[] input,
        string expectedResult)
    {

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(expectedResult));

    }
}