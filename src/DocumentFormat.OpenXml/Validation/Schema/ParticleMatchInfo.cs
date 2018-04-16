// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Information about particle match.
    /// </summary>
    [DebuggerDisplay("Match={Match}")]
    internal partial class ParticleMatchInfo
    {
        static partial void IncressInstanceCount();

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        internal ParticleMatchInfo()
        {
            Match = ParticleMatch.Nomatch;

            IncressInstanceCount();
        }

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        /// <param name="startElement"></param>
        internal ParticleMatchInfo(OpenXmlElement startElement)
        {
            Match = ParticleMatch.Nomatch;
            StartElement = startElement;

            IncressInstanceCount();
        }

        /// <summary>
        /// Gets or sets particle match result.
        /// </summary>
        internal ParticleMatch Match { get; set; }

        /// <summary>
        /// Gets the start element to be matched by a particle rule.
        /// </summary>
        internal OpenXmlElement StartElement { get; private set; }

        /// <summary>
        /// Gets or sets the last element matched by the particle match.
        /// </summary>
        internal OpenXmlElement LastMatchedElement { get; set; }

        /// <summary>
        /// Gets or sets message on match error
        /// </summary>
        /// <remarks>
        /// TODO: how can this be decoupled from the validator?
        /// </remarks>
        internal string ErrorMessage { get; set; }

        /// <summary>
        /// Gets the element type ids of expected children.
        /// Fill this field on partial match.
        /// </summary>
        /// <remarks>
        /// Will be null if matched or not matched.
        /// Will contains the expected child element types if partial match.
        /// </remarks>
        internal ExpectedChildren ExpectedChildren { get; private set; }

        /// <summary>
        /// The .ExpectedChildren will be non-null after this call.
        /// </summary>
        internal void InitExpectedChildren()
        {
            if (ExpectedChildren == null)
            {
                ExpectedChildren = new ExpectedChildren();
            }
            else
            {
                ExpectedChildren.Clear();
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
            if (expectedChildren == null || expectedChildren.Count == 0)
            {
                if (ExpectedChildren != null)
                {
                    ExpectedChildren.Clear();
                }

                // else, both are null, just return, nothing to do.
            }
            else
            {
                if (ExpectedChildren == null)
                {
                    ExpectedChildren = new ExpectedChildren();
                }

                ExpectedChildren.Clear();
                ExpectedChildren.Add(expectedChildren);
            }
        }

        internal void Reset(OpenXmlElement startElement)
        {
            StartElement = startElement;
            Match = ParticleMatch.Nomatch;
            LastMatchedElement = null;
            ErrorMessage = null;
            if (ExpectedChildren != null)
            {
                ExpectedChildren.Clear();
            }
        }
    }
}
