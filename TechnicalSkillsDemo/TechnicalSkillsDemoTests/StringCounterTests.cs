// <copyright file="StringCounterTests.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemoTests
{
    using NUnit.Framework;
    using TechnicalSkillsDemo;

    public class StringCounterTests
    {
        private const string textTest = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
        private const string numberTest = "17272838119191929838299111";

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, "e", textTest, TestName = "Requirement: Lorem ipsum has 10 \"e\"s.")]
        [TestCase(8, "1", numberTest, TestName = "Requirement: 17272838119191929838299111 has 8 \"1\"s.")]
        [TestCase(0, "1", "00000", TestName = "No 1s in 00000")]
        [TestCase(5, "0", "00000", TestName = "5 0s in 00000")]
        [TestCase(2, "1", "01", "10", TestName = "2 1s across two strings of 01 and 10")]
        public void PatternsWillBeCounted(int expectedCount, string pattern, params string[] texts)
        {
            var stringCounter = new BasicStringCounter();

            var count = int.MinValue;
            Assert.DoesNotThrow(() => count = stringCounter.FindPatternCount(pattern, texts));

            Assert.AreEqual(expectedCount, count);
        }
    }
}