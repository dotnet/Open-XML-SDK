// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace SvgExample
{
    public class Program
    {
        // Template slide and sample image
        private const string EmptySlidePath = "Content\\EmptySlide.pptx";
        private const string SvgImagePath = "Content\\Dinosaur.svg";

        // Output paths
        private const string LinqToXmlOutputPath = "LinqToXmlSlide.pptx";
        private const string StronglyTypedOutputPath = "StronglyTypedSlide.pptx";

        // Image scale as a percentage of the slide height
        private const double PercentageOfCy = 0.5;

        public static void Main()
        {
            // Add an SVG image, using the Linq-to-XML way.
            File.Copy(EmptySlidePath, LinqToXmlOutputPath, true);
            using FileStream linqToXmlStream = File.Open(LinqToXmlOutputPath, FileMode.Open, FileAccess.ReadWrite);
            LinqToXmlTools.AddSvg(linqToXmlStream, SvgImagePath, PercentageOfCy);

            // Add an SVG image, using the strongly typed way.
            File.Copy(EmptySlidePath, StronglyTypedOutputPath, true);
            using FileStream stronglyTypedStream = File.Open(StronglyTypedOutputPath, FileMode.Open, FileAccess.ReadWrite);
            StronglyTypedTools.AddSvg(stronglyTypedStream, SvgImagePath, PercentageOfCy);
        }
    }
}
