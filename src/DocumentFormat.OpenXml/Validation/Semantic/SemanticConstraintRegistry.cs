// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal partial class SemanticConstraintRegistry
    {
        protected readonly MultivalueCollection<Type, SemanticConstraint> _semConstraintMap = new MultivalueCollection<Type, SemanticConstraint>();

        private readonly FileFormatVersions _format;
        private readonly ApplicationType _appType;

        public SemanticConstraintRegistry(FileFormatVersions format, ApplicationType appType)
        {
            _format = format;
            _appType = appType;

            Initialize();
        }

        /// <summary>
        /// Register a constraint to this registry.
        /// </summary>
        public void RegisterConstraint(Type type, FileFormatVersions fileFormat, ApplicationType appType, SemanticConstraint constraint)
        {
            if (_format.AtLeast(fileFormat) && (appType & _appType) == _appType)
            {
                _semConstraintMap.Add(type, constraint);
            }
        }

        /// <summary>
        /// Check if specified context meets all registered constraints
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ValidationErrorInfo> CheckConstraints(ValidationContext context)
        {
            var level = SemanticValidationLevel.Element;

            if (context.Part != null)
            {
                level = SemanticValidationLevel.Part;
            }

            if (context.Package != null)
            {
                level = SemanticValidationLevel.Package;
            }

            context.Events.OnElementValidationStarted(context);

            if (_semConstraintMap.TryGetValue(context.Element.GetType(), out var constraints))
            {
                foreach (var constraint in constraints)
                {
                    if ((constraint.SemanticValidationLevel & level) == level)
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
