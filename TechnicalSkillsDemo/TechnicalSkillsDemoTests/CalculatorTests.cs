// <copyright file="CalculatorTests.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemoTests
{
    using NUnit.Framework;
    using TechnicalSkillsDemo;

    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(12, 7, 5, TestName ="Requirement: Result of 7 + 5")]
        [TestCase(100, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, TestName = "10 10s")]
        [TestCase(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, TestName = "Adding multiple 0s is still 0.")]
        [TestCase(-1, -1, TestName = "-1")]
        [TestCase(-2, -1, -1, TestName = "-1 and -1 makes -2")]
        [TestCase(0, 1, -1, TestName = "1 and -1 cancels out")]
        public void NumbersSummedInBasicCalculatorCorrectly(int expectedResult, params int[] testNumbers)
        {
            var basicCalculator = new BasicCalculator();

            var sum = int.MinValue;
            Assert.DoesNotThrow(() => sum = basicCalculator.Sum(testNumbers));

            Assert.AreEqual(expectedResult, sum);
        }
    }
}