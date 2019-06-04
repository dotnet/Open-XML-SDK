// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal delegate void CallBackMethod();

    /// <summary>
    /// Semantic constraint registry base class
    /// </summary>
    internal partial class SemanticConstraintRegistry
    {
        protected readonly IntegerMultivalueCollection<SemanticConstraint> _semConstraintMap = new IntegerMultivalueCollection<SemanticConstraint>();
        protected readonly IntegerMultivalueCollection<SemanticConstraint> _cleanList = new IntegerMultivalueCollection<SemanticConstraint>();

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
        public void RegisterConstraint(int elementTypeID, int ancestorTypeID, FileFormatVersions fileFormat, ApplicationType appType, SemanticConstraint constraint)
        {
            if ((fileFormat & _format) == _format && (appType & _appType) == _appType)
            {
                _cleanList.Add(ancestorTypeID, constraint);
                _semConstraintMap.Add(elementTypeID, constraint);
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

            int elementTypeID = context.Element.ElementTypeId;

            if (_cleanList.TryGetValue(elementTypeID, out var cleanConstraints))
            {
                foreach (var con in cleanConstraints)
                {
                    con.ClearState(context);
                }
            }

            if (_semConstraintMap.TryGetValue(elementTypeID, out var constraints))
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
