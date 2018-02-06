// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Base class for digit value based simple type constraint.
    /// </summary>
    /// <typeparam name="T">A basic number type.</typeparam>
    /// <typeparam name="ST">A type of OpenXmlSimpleType.</typeparam>
    [DataContract]
    internal abstract class SimpleValueRestriction<T, ST> : SimpleTypeRestriction
        where T : struct, IComparable<T>
        where ST : OpenXmlSimpleValue<T>, new()
    {
        protected abstract T MinValue { get; }

        protected abstract T MaxValue { get; }

        public SimpleValueRestriction()
        {
            this.MinInclusive = this.MinValue;
            this.MaxInclusive = this.MaxValue;
        }

        /// <inheritdoc />
        public override string ClrTypeName => typeof(T).Name;

        /// <summary>
        /// Gets or sets the minInclusive facets.
        /// </summary>
        [DataMember]
        public T MinInclusive { get; set; }

        /// <summary>
        /// Gets or sets the maxInclusive facets.
        /// </summary>
        [DataMember]
        public T MaxInclusive { get; set; }

        /// <summary>
        /// Gets or sets the minExclusive facets.
        /// </summary>
        [DataMember]
        public T MinExclusive { get; set; }

        /// <summary>
        /// Gets or sets the maxExclusive facets.
        /// </summary>
        [DataMember]
        public T MaxExclusive { get; set; }

        /// <inheritdoc />
        public override string GetRestrictionValue(RestrictionField restrictionField)
        {
            switch (restrictionField)
            {
                case RestrictionField.MinExclusive:
                    return this.MinExclusive.ToString();

                case RestrictionField.MaxExclusive:
                    return this.MaxExclusive.ToString();

                case RestrictionField.MinInclusive:
                    return this.MinInclusive.ToString();

                case RestrictionField.MaxInclusive:
                    return this.MaxInclusive.ToString();

                default:
                    return base.GetRestrictionValue(restrictionField);
            }
        }

        /// <summary>
        /// Convert the text "valueText" to value in OpenXmlSimpleValue.
        /// </summary>
        /// <param name="valueText"></param>
        /// <returns></returns>
        public virtual OpenXmlSimpleValue<T> StringToSimpleValue(string valueText)
        {
            if (String.IsNullOrEmpty(valueText))
            {
                return null;
            }

            ST simpleValue = new ST();
            simpleValue.InnerText = valueText;
            return simpleValue;
        }

        /// <inheritdoc />
        public override bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                // true if this.MinInclusive <= simpleValue.Value
                if (this.MinInclusive.CompareTo(simpleValue.Value) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override bool IsMinExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                // true if this.MinExclusive < simpleValue.Value
                if (this.MinExclusive.CompareTo(simpleValue.Value) >= 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override bool IsMaxInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                // true if this.MaxInclusive >= simpleValue.Value
                if (this.MaxInclusive.CompareTo(simpleValue.Value) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override bool IsMaxExclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            ST simpleValue = (ST)attributeValue;
            if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                // true if this.MaxExclusive > simpleValue.Value
                if (this.MaxExclusive.CompareTo(simpleValue.Value) <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                ST stValue = (ST)attributeValue;

                if (stValue.Value.CompareTo(this.MinValue) < 0 ||
                    stValue.Value.CompareTo(this.MaxValue) > 0)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);

            this.VerifyMinMax();
        }

        private void VerifyMinMax()
        {
            if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                Debug.Assert(this.MinExclusive.CompareTo(this.MinValue) >= 0);
            }
            if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                Debug.Assert(this.MaxExclusive.CompareTo(this.MaxValue) <= 0);
            }
            if ((this.RestrictionField & RestrictionField.MinMaxExclusive) == RestrictionField.MinMaxExclusive)
            {
                Debug.Assert(this.MinExclusive.CompareTo(this.MaxExclusive) < 0);
            }

            if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                Debug.Assert(this.MinInclusive.CompareTo(this.MinValue) >= 0);
            }
            if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                Debug.Assert(this.MaxInclusive.CompareTo(this.MaxValue) <= 0);
            }
            if ((this.RestrictionField & RestrictionField.MinMaxInclusive) == RestrictionField.MinMaxInclusive)
            {
                Debug.Assert(this.MinInclusive.CompareTo(this.MaxInclusive) <= 0);
            }
        }
#endif
    }
}
