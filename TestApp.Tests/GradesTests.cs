using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> input = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 3,
            ["Petkan"] = 4,
            ["Stoyan"] = 6,
            ["Pesho"] = 2
        };

        string expectedResult = $"Stoyan with average grade 6.00"+
            $"{Environment.NewLine}Gosho with average grade 5.00" +
            $"{Environment.NewLine}Petkan with average grade 4.00";

        // Act
        var result = Grades.GetBestStudents(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> input = new()
        {
        };

        string expectedResult = string.Empty;

        // Act
        var result = Grades.GetBestStudents(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> input = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 3
        };

        string expectedResult = $"Gosho with average grade 5.00" +
            $"{Environment.NewLine}Ivan with average grade 3.00";

        // Act
        var result = Grades.GetBestStudents(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> input = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 5,
            ["Petkan"] = 5,
            ["Stoyan"] = 5,
            ["Pesho"] = 5
        };

        string expectedResult = $"Gosho with average grade 5.00" +
            $"{Environment.NewLine}Ivan with average grade 5.00" +
            $"{Environment.NewLine}Pesho with average grade 5.00";

        // Act
        var result = Grades.GetBestStudents(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
