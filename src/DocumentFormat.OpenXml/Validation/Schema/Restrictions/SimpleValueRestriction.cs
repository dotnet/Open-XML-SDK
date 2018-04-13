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
    [DataContract(Name = "simpletst")]
    internal abstract class SimpleValueRestriction<T, ST> : SimpleTypeRestriction
        where T : struct, IComparable<T>
        where ST : OpenXmlSimpleValue<T>, new()
    {
        protected abstract T MinValue { get; }

        protected abstract T MaxValue { get; }

        public SimpleValueRestriction()
        {
            MinInclusive = MinValue;
            MaxInclusive = MaxValue;
        }

        /// <inheritdoc />
        public override string ClrTypeName => typeof(T).Name;

        /// <summary>
        /// Gets or sets the minInclusive facets.
        /// </summary>
        [DataMember(Name = "ni")]
        public T MinInclusive { get; set; }

        /// <summary>
        /// Gets or sets the maxInclusive facets.
        /// </summary>
        [DataMember(Name = "xi")]
        public T MaxInclusive { get; set; }

        /// <summary>
        /// Gets or sets the minExclusive facets.
        /// </summary>
        [DataMember(Name = "ne")]
        public T MinExclusive { get; set; }

        /// <summary>
        /// Gets or sets the maxExclusive facets.
        /// </summary>
        [DataMember(Name = "xe")]
        public T MaxExclusive { get; set; }

        /// <inheritdoc />
        public override string GetRestrictionValue(RestrictionField restrictionField)
        {
            switch (restrictionField)
            {
                case RestrictionField.MinExclusive:
                    return MinExclusive.ToString();

                case RestrictionField.MaxExclusive:
                    return MaxExclusive.ToString();

                case RestrictionField.MinInclusive:
                    return MinInclusive.ToString();

                case RestrictionField.MaxInclusive:
                    return MaxInclusive.ToString();

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
            if (string.IsNullOrEmpty(valueText))
            {
                return null;
            }

            return new ST { InnerText = valueText };
        }

        /// <inheritdoc />
        public override bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
        {
            Debug.Assert(attributeValue is ST);
            var simpleValue = (ST)attributeValue;

            if ((RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                // true if this.MinInclusive <= simpleValue.Value
                if (MinInclusive.CompareTo(simpleValue.Value) > 0)
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
            var simpleValue = (ST)attributeValue;

            if ((RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                // true if this.MinExclusive < simpleValue.Value
                if (MinExclusive.CompareTo(simpleValue.Value) >= 0)
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
            var simpleValue = (ST)attributeValue;

            if ((RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                // true if this.MaxInclusive >= simpleValue.Value
                if (MaxInclusive.CompareTo(simpleValue.Value) < 0)
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
            var simpleValue = (ST)attributeValue;

            if ((RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                // true if this.MaxExclusive > simpleValue.Value
                if (MaxExclusive.CompareTo(simpleValue.Value) <= 0)
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
                var stValue = (ST)attributeValue;

                if (stValue.Value.CompareTo(MinValue) < 0 ||
                    stValue.Value.CompareTo(MaxValue) > 0)
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
            Debug.Assert(IsEnum == false);
            Debug.Assert(IsList == false);
            Debug.Assert(Pattern == null);

            VerifyMinMax();
        }

        private void VerifyMinMax()
        {
            if ((RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
            {
                Debug.Assert(MinExclusive.CompareTo(MinValue) >= 0);
            }

            if ((RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
            {
                Debug.Assert(MaxExclusive.CompareTo(MaxValue) <= 0);
            }

            if ((RestrictionField & RestrictionField.MinMaxExclusive) == RestrictionField.MinMaxExclusive)
            {
                Debug.Assert(MinExclusive.CompareTo(MaxExclusive) < 0);
            }

            if ((RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
            {
                Debug.Assert(MinInclusive.CompareTo(MinValue) >= 0);
            }

            if ((RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
            {
                Debug.Assert(MaxInclusive.CompareTo(MaxValue) <= 0);
            }

            if ((RestrictionField & RestrictionField.MinMaxInclusive) == RestrictionField.MinMaxInclusive)
            {
                Debug.Assert(MinInclusive.CompareTo(MaxInclusive) <= 0);
            }
        }
#endif
    }
}
