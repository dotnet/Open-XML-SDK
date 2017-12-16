// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static class EnumerableExtensions
    {
        /// <summary>Pick the second element from source collection.  If only one, then return the first.</summary>
        /// <typeparam name="TSource">Type of collection content</typeparam>
        /// <param name="source">source collection</param>
        /// <returns>chosen element of source collection</returns>
        public static TSource PickSecond<TSource>(this IEnumerable<TSource> source)
        {
            var chosenElement = source.Skip(1).FirstOrDefault();
            if (chosenElement != null)
                return chosenElement;
            chosenElement = source.FirstOrDefault();
            return chosenElement;
            // This used to return a random element.  Bad idea for a test suite.
            //int index = new Random ().Next(source.Count());
            //return source.ElementAtOrDefault(index);
        }

        /// <summary> Pick an element from source collection randomly. </summary>
        /// <typeparam name="TSource">Type of collection content</typeparam>
        /// <param name="source">source collection</param>
        /// <param name="predicate">predicate on collection element</param>
        /// <returns>chosen element of source collection</returns>
        public static TSource PickFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Where(predicate).FirstOrDefault();
        }
    }
}
