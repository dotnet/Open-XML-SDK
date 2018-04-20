using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a comparable and equatable reference.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public abstract class OpenXmlComparableReferenceType<T> : OpenXmlSimpleType,
        IComparable, IComparable<OpenXmlComparableReferenceType<T>>, IEquatable<OpenXmlComparableReferenceType<T>>
        where T : class, IComparable, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableReferenceType{T}"/>.
        /// </summary>
        protected OpenXmlComparableReferenceType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlComparableReferenceType{T}"/>
        /// class by deep copying the supplied <see cref="OpenXmlComparableReferenceType{T}"/>
        /// value.
        /// </summary>
        /// <param name="source">The source <see cref="OpenXmlComparableReferenceType{T}"/> instance.</param>
        protected OpenXmlComparableReferenceType(OpenXmlComparableReferenceType<T> source) : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public abstract T Value { get; set; }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj is OpenXmlComparableReferenceType<T> other)
            {
                return CompareTo(other);
            }

            throw new ArgumentException();
        }

        /// <inheritdoc />
        public int CompareTo(OpenXmlComparableReferenceType<T> other)
        {
            if (other is null)
            {
                return 1;
            }

            if (Value == null)
            {
                return other.Value == null ? 0 : -1;
            }

            return Value.CompareTo(other.Value);
        }

        /// <inheritdoc />
        public bool Equals(OpenXmlComparableReferenceType<T> other)
        {
            if (other is null)
            {
                return false;
            }

            if (Value == null)
            {
                return other.Value == null;
            }

            return Value.Equals(other.Value);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is OpenXmlComparableReferenceType<T> other)
            {
                return Equals(other);
            }

            if (obj is T otherValue)
            {
                return otherValue.Equals(Value);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            if (left is null)
            {
                return right is null;
            }

            return left.Equals(right);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            return !(left == right);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            return left is null ? !(right is null) : left.CompareTo(right) < 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            return !(left is null) && left.CompareTo(right) > 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(OpenXmlComparableReferenceType<T> left, OpenXmlComparableReferenceType<T> right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }
    }
}
