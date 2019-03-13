// <copyright file="ICalculator.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemo.Interfaces
{
    /// <summary>
    /// Does calculations. Obviously.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Sums the given numbers together.
        /// </summary>
        /// <param name="numbers">The numbers to be summed together.</param>
        /// <returns>The sum of the given numbers.</returns>
        int Sum(params int[] numbers);
    }
}
