﻿// <copyright file="BasicStringCounter.cs" company="Samuel Ballard-Adams">
// Copyright (c) Samuel Ballard-Adams. All rights reserved.
// Licensed under the GNU General Public License v3 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace TechnicalSkillsDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TechnicalSkillsDemo.Interfaces;

    /// <summary>
    /// A basic counter for finding the count of a given pattern in a set of strings.
    /// </summary>
    public class BasicStringCounter : IStringCounter
    {
        /// <inheritdoc/>
        public int FindPatternCount(string pattern, params string[] subjects)
        {
            var count = 0;
            foreach (var subject in subjects)
            {
                for (var index = 0; index < subject.Length; ++index)
                {
                    var offset = subject.IndexOf(pattern, index);
                    if (offset != -1)
                    {
                        ++count;
                        index += offset - index;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}
