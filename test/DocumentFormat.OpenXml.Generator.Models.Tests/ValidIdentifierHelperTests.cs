// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator;
using Xunit;

namespace DocumentFormat.OpenXml.Generator.Models.Tests;

public class ValidIdentifierHelperTests
{
    [Fact]
    public void NullReturnsFalse()
    {
        Assert.False(ValidIdentifierHelper.IsValidIdentifier(null!));
    }

    [Fact]
    public void EmptyStringReturnsFalse()
    {
        Assert.False(ValidIdentifierHelper.IsValidIdentifier(string.Empty));
    }

    [Fact]
    public void LongerThan512ReturnsFalse()
    {
        Assert.False(ValidIdentifierHelper.IsValidIdentifier(new string('a', 513)));
    }

    [Fact]
    public void Exactly512ReturnsTrue()
    {
        Assert.True(ValidIdentifierHelper.IsValidIdentifier(new string('a', 512)));
    }

    [Fact]
    public void KeywordReturnsFalse()
    {
        Assert.False(ValidIdentifierHelper.IsValidIdentifier("class"));
    }

    [Fact]
    public void NonKeywordReturnsTrue()
    {
        Assert.True(ValidIdentifierHelper.IsValidIdentifier("myVariable"));
    }

    [Fact]
    public void AtPrefixedKeywordReturnsTrue()
    {
        Assert.True(ValidIdentifierHelper.IsValidIdentifier("@class"));
    }

    [Fact]
    public void AtPrefixedNonKeywordReturnsTrue()
    {
        Assert.True(ValidIdentifierHelper.IsValidIdentifier("@myVariable"));
    }

    [Fact]
    public void AtAloneReturnsFalse()
    {
        // "@" alone is not a valid identifier — after stripping '@', the remaining value is empty
        Assert.False(ValidIdentifierHelper.IsValidIdentifier("@"));
    }
}
