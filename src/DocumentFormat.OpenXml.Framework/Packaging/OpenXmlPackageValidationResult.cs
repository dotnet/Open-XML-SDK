// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class OpenXmlPackageValidationResult
{
    private string? _message;

    /// <summary>
    /// Gets or sets the message string of the event.
    /// </summary>
    public string Message
    {
        get
        {
            if (_message is null && MessageId is not null)
            {
                return ExceptionMessages.ResourceManager.GetString(MessageId, CultureInfo.CurrentCulture) ?? string.Empty;
            }
            else
            {
                return _message ?? string.Empty;
            }
        }

        set
        {
            _message = value;
        }
    }

    /// <summary>
    /// Gets or sets the class name of the part.
    /// </summary>
    public string? RelationshipType { get; set; }

    /// <summary>
    /// Gets or sets the part that caused the event.
    /// </summary>
    public OpenXmlPart? SubPart { get; internal set; }

    /// <summary>
    /// Gets or sets the part in which to process the validation.
    /// </summary>
    public OpenXmlPart? Part { get; internal set; }

    internal string? MessageId { get; set; }

    /// <summary>
    /// Gets or sets the DataPartReferenceRelationship that caused the event.
    /// </summary>
    internal DataPartReferenceRelationship? DataPartReferenceRelationship { get; set; }
}
