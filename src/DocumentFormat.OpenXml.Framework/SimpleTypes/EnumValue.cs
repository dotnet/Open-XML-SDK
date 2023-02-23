// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Represents the enum value for attributes.
/// </summary>
/// <typeparam name="T">Type of enum.</typeparam>
[DebuggerDisplay("{InnerText}")]
public class EnumValue<T> : OpenXmlSimpleValue<T>
    where T : struct, IEnumValue, IEnumValueFactory<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EnumValue{T}"/> class.
    /// </summary>
    public EnumValue()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EnumValue{T}"/> class using the supplied
    /// value of type T.
    /// </summary>
    /// <param name="value">
    /// The value of type T.
    /// </param>
    public EnumValue(T value)
        : base(value)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EnumValue{T}"/> by deep copying the supplied
    /// <see cref="EnumValue{T}"/> class.
    /// </summary>
    /// <param name="source">
    /// The source <see cref="EnumValue{T}"/> class.
    /// </param>
    public EnumValue(EnumValue<T> source)
        : base(source)
    {
    }

    internal override bool IsEnum => true;

    /// <summary>
    /// Implicitly converts the specified value to an enum.
    /// </summary>
    /// <param name="value">The <see cref="EnumValue{T}"/> to convert.</param>
    /// <returns>
    /// The converted enum value.
    /// </returns>
    /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
    public static implicit operator T(EnumValue<T> value)
    {
        if (value is null)
        {
            throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
        }

        return value.Value;
    }

    /// <summary>
    /// Initializes a new <see cref="EnumValue{T}"/> class by converting the supplied enum
    /// value.
    /// </summary>
    /// <param name="value">The specified value.</param>
    /// <returns>A new <see cref="EnumValue{T}"/> instance corresponding to the value.</returns>
    public static implicit operator EnumValue<T>(T value) => new EnumValue<T>(value);

    /// <summary>
    /// Implicitly converts the specified value to a String value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The converted string.</returns>
    public static implicit operator string?(EnumValue<T> value)
    {
        if (value is null)
        {
            return null;
        }

        return value.InnerText;
    }

    private protected override OpenXmlSimpleType CloneImpl() => new EnumValue<T>(this);

    /// <inheritdoc />
    internal override bool IsInVersion(FileFormatVersions fileFormat)
    {
        Debug.Assert(HasValue);

        return fileFormat.AtLeast(Value.Version);
    }

    private protected override bool ShouldParse(string? value) => value is not null;

    private protected override void ValidateSet(T value)
    {
        if (!value.IsValid)
        {
            throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessages.InvalidEnumValue);
        }
    }

    private protected override string GetText(T input) => input.Value;

    private protected override bool TryParse(string? input, out T value)
    {
        // Because T is a struct, we can use a default instance to create a value. Ideally, we would use static virtual members in interfaces,
        // but those aren't available on platforms before .NET 7
        if (input is not null && default(T).Create(input) is { IsValid: true } result)
        {
            value = result;
            return true;
        }

        value = default;
        return false;
    }

    private protected override T Parse(string? input)
    {
        if (TryParse(input, out var value))
        {
            return value;
        }

        throw new FormatException(ExceptionMessages.TextIsInvalidEnumValue);
    }
}
