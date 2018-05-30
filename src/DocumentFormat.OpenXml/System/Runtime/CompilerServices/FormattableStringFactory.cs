// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Runtime.CompilerServices
{
	internal static class FormattableStringFactory
	{
		public static FormattableString Create(string format, params object[] arguments)
		{
			return new FormattableString(format, arguments);
		}
	}
}
