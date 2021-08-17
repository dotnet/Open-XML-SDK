// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Information about particle match.
    /// </summary>
    [DebuggerDisplay("Match={Match}")]
    internal class ParticleMatchInfo
    {
        private ExpectedChildren? _expectedChildren;

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        internal ParticleMatchInfo()
        {
            Match = ParticleMatch.Nomatch;
        }

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        /// <param name="startElement"></param>
        internal ParticleMatchInfo(OpenXmlElement startElement)
        {
            Match = ParticleMatch.Nomatch;
            StartElement = startElement;
        }

        /// <summary>
        /// Gets or sets particle match result.
        /// </summary>
        internal ParticleMatch Match { get; set; }

        /// <summary>
        /// Gets the start element to be matched by a particle rule.
        /// </summary>
        internal OpenXmlElement? StartElement { get; private set; }

        /// <summary>
        /// Gets or sets the last element matched by the particle match.
        /// </summary>
        internal OpenXmlElement? LastMatchedElement { get; set; }

        /// <summary>
        /// Gets or sets message on match error
        /// </summary>
        /// <remarks>
        /// TODO: how can this be decoupled from the validator?
        /// </remarks>
        internal string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets the element type ids of expected children.
        /// Fill this field on partial match.
        /// </summary>
        /// <remarks>
        /// Will be null if matched or not matched.
        /// Will contains the expected child element types if partial match.
        /// </remarks>
        internal ExpectedChildren ExpectedChildren
        {
            get
            {
                if (_expectedChildren is null)
                {
                    _expectedChildren = new ExpectedChildren();
                }

                return _expectedChildren;
            }
        }

        /// <summary>
        /// Purpose:
        /// Reuse this.ExpectedChildren data field.
        /// Avoid this.ExpectedChildren be referenced by more than one object (so "this.ExpectedChildren = other.ExpectedChildren" is not allowed).
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void SetExpectedChildren(ExpectedChildren expectedChildren)
        {
            if (expectedChildren is null || expectedChildren.Count == 0)
            {
                ExpectedChildren.Clear();
            }
            else
            {
                ExpectedChildren.Clear();
                ExpectedChildren.Add(expectedChildren);
            }
        }

        internal void Reset(OpenXmlElement? startElement)
        {
            StartElement = startElement;
            Match = ParticleMatch.Nomatch;
            LastMatchedElement = null;
            ErrorMessage = null;
            if (ExpectedChildren is not null)
            {
                ExpectedChildren.Clear();
            }
        }
    }
}
