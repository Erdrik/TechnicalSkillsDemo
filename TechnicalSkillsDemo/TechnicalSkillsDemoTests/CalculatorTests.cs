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
        public void NumbersSummedInBasicCalculatorCorrectly(int expectedResult, params int[] testNumbers)
        {
            var basicCalculator = new BasicCalculator();
            Assert.DoesNotThrow(() => Assert.AreEqual(expectedResult, basicCalculator.Sum(testNumbers)));
        }
    }
}