// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Holder for feature event args.
    /// </summary>
    /// <typeparam name="TArg">The type of the argument.</typeparam>
    public readonly struct FeatureEventArgs<TArg>
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
    }
}
