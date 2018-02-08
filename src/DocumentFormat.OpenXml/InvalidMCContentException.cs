// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

#if FEATURE_SERIALIZATION
using System.Runtime.Serialization;
#endif

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// The exception that is thrown for Markup Compatibility content errors.
    /// </summary>
    [Serializable]
    public sealed class InvalidMCContentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class.
        /// </summary>
        public InvalidMCContentException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public InvalidMCContentException(string message)
            : base(message)
        {
        }

#if FEATURE_SERIALIZATION
        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        private InvalidMCContentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        /// <summary>
        /// Initializes a new instance of the InvalidMCContentException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public InvalidMCContentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
