// <copyright file="IStringCounter.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemo.Interfaces
{
    /// <summary>
    /// For counting characters in a string.
    /// </summary>
    public interface IStringCounter
    {
        /// <summary>
        /// Find the count of a given pattern in the given strings.
        /// </summary>
        /// <param name="pattern">The pattern to find.</param>
        /// <param name="subjects">The given strings to search through.</param>
        /// <returns>The count of patterns found</returns>
        int FindPatternCount(string pattern, params string[] subjects);
    }
}
