// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Holder for feature event args.
    /// </summary>
    /// <typeparam name="TArg">The type of the argument.</typeparam>
    public readonly struct FeatureEventArgs<TArg> : IEquatable<FeatureEventArgs<TArg>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureEventArgs{TArg}"/> struct.
        /// </summary>
        /// <param name="type">Type of change.</param>
        /// <param name="arg">Argument of change.</param>
        public FeatureEventArgs(EventType type, TArg arg)
        {
            Type = type;
            Argument = arg;
        }

        /// <summary>
        /// Gets the event type.
        /// </summary>
        public EventType Type { get; }

        /// <summary>
        /// Gets the argument.
        /// </summary>
        public TArg Argument { get; }

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            obj is FeatureEventArgs<TArg> arg && Equals(arg);

        /// <inheritdoc/>
        public bool Equals(FeatureEventArgs<TArg> other)
            => Equals(Argument, other.Argument) && Equals(Type, other.Type);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(Argument, Type);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

        public static bool operator ==(FeatureEventArgs<TArg> left, FeatureEventArgs<TArg> right)
            => left.Equals(right);

        public static bool operator !=(FeatureEventArgs<TArg> left, FeatureEventArgs<TArg> right)
            => !(left == right);
    }
}
