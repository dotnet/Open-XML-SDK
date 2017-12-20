// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

#if FEATURE_SERIALIZATION
using System.Runtime.Serialization;
#endif

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an Open XML package exception class for errors.
    /// </summary>
    [Serializable]
    public sealed class OpenXmlPackageException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class.
        /// </summary>
        public OpenXmlPackageException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public OpenXmlPackageException(string message)
            : base(message)
        {
        }

#if FEATURE_SERIALIZATION
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied serialized data.
        /// </summary>
        /// <param name="info">The serialized object data about the exception being thrown.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        private OpenXmlPackageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied error message and a reference to the inner exception that caused the current exception.
        /// </summary>
        /// <param name="message">The error message that indicates the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OpenXmlPackageException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
