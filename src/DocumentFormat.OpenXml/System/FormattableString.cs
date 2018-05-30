// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace System
{
    internal sealed class FormattableString : IFormattable
    {
        private readonly string _format;
        private readonly object[] _arguments;

        public FormattableString(string format, object[] arguments)
        {
            _format = format;
            _arguments = arguments;
        }

        string IFormattable.ToString(string _, IFormatProvider formatProvider) => ToString(formatProvider);

        public string ToString(IFormatProvider formatProvider) => string.Format(formatProvider, _format, _arguments);

        public static string Invariant(FormattableString formattable)
        {
            if (formattable == null)
            {
                throw new ArgumentNullException(nameof(formattable));
            }

            return formattable.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToString() => ToString(CultureInfo.CurrentCulture);
    }
}
