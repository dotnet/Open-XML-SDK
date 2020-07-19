// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class SemanticConstraintRegistry
    {
        private readonly FileFormatVersions _format;
        private readonly ApplicationType _appType;

        public SemanticConstraintRegistry(FileFormatVersions format, ApplicationType appType)
        {
            _format = format;
            _appType = appType;
        }

        /// <summary>
        /// Check if specified context meets all registered constraints
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ValidationErrorInfo> CheckConstraints(ValidationContext context)
        {
            var level = SemanticValidationLevel.Element;
            var current = context.Stack.Current;

            if (current.Part != null)
            {
                level = SemanticValidationLevel.Part;
            }

            if (current.Package != null)
            {
                level = SemanticValidationLevel.Package;
            }

            foreach (var constraint in current.Element.Metadata.Constraints)
            {
                if ((constraint.SemanticValidationLevel & level) == level)
                {
                    if (_format.AtLeast(constraint.Version) && (constraint.Application & _appType) == _appType)
                    {
                        var err = constraint.Validate(context);

                        if (err != null)
                        {
                            yield return err;
                        }
                    }
                }
            }
        }
    }
}
