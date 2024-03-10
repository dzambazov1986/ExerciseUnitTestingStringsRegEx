using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        string expectedResult = "The quick brown  jumps over the lazy dog";
        Assert.That(expectedResult, Is.EqualTo(expectedResult));
    }
        [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        //Arrange
        string toRemove = "Hello";
        string input = "Hello,my name is Mitko";

        //Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        //Assert
        string expectedResult = ",my name is Mitko";
        Assert.That (result,Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        //Arrange
        string toRemove = "Mitko";
        string input = "Hello,my name is Mitko";

        //Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        //Assert
        string expectedResult = "Hello,my name is";
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        //Arrange
        string toRemove = "Mitko";
        string input = "Hello,my name is Mitko,my name is get by my Grandfather Mitko,and i love my Mitko names";

        //Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        //Assert
        string expectedResult = "Hello,my name is ,my name is get by my Grandfather ,and i love my names";
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
