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

        [TestCase(12, textTest, TestName = "Requirement: Lorem ipsum has 12 \"e\"s.")]
        [TestCase(8, textTest, TestName = "Requirement: 17272838119191929838299111 has 8 \"1\"s.")]
        public void PatternsWillBeCounted(int expectedCount, params string[] text)
        {
            var stringCounter = new BasicStringCounter();
            Assert.DoesNotThrow(() => Assert.AreEqual(expectedCount, text));
        }
    }
}