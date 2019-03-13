// <copyright file="BasicCalculator.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemo
{
    using System;
    using TechnicalSkillsDemo.Interfaces;

    /// <summary>
    /// A basic calculator with no tricks.
    /// </summary>
    public class BasicCalculator : ICalculator
    {
        /// <inheritdoc/>
        public int Sum(params int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
