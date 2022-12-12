// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 2.3 Element's attribute value should be unique within specified type of element.
    /// </summary>
    internal class UniqueAttributeValueConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly OpenXmlQualifiedName? _parent;
        private readonly StringComparer _comparer;

        public UniqueAttributeValueConstraint(OpenXmlQualifiedName attribute, bool caseSensitive, OpenXmlQualifiedName? parent)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _parent = parent;
            _comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            if (_parent is not null)
            {
                return null;
            }

            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _attribute, out var attribute))
            {
                return null;
            }

            // if the attribute is omitted, semantic validation will do nothing
            if (attribute.Value is null || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            var root = GetRoot(element);

            if (root is null)
            {
                return null;
            }

            var elementType = element.GetType();
            var textValues = context.State.GetOrCreate(new { elementType, root, constraint = this }, static (key, context) =>
            {
                var set = new DuplicateFinder(key.constraint._comparer);

                foreach (var e in key.root.Descendants(context.FileFormat, TraversalOptions.SelectAlternateContent))
                {
                    if (e.GetType() == key.elementType)
                    {
                        if (TryFindAttribute(e, key.constraint._attribute, out var eValue) && eValue.Value is not null)
                        {
                            set.Add(eValue.Value.InnerText);
                        }
                    }
                }

                set.Complete();

                return set;
            });

            var isDuplicate = textValues.IsDuplicate(attribute.Value.InnerText);

            if (!isDuplicate)
            {
                return null;
            }

            return new ValidationErrorInfo
            {
                Id = "Sem_UniqueAttributeValue",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_UniqueAttributeValue,
                    attribute.Property.QName,
                    attribute.Value.InnerText),
            };
        }

        private OpenXmlElement? GetRoot(OpenXmlElement element)
        {
            if (!_parent.HasValue)
            {
                return element.GetPart()?.RootElement;
            }

            var parent = _parent.Value;

            foreach (var ancestor in element.Ancestors())
            {
                if (ancestor.QName.Equals(parent))
                {
                    return ancestor;
                }
            }

            return null;
        }

        private class DuplicateFinder
        {
            private readonly StringComparer _comparer;

            private bool _isCompleted;
            private HashSet<string?>? _set;
            private HashSet<string?>? _duplicate;

            public DuplicateFinder(StringComparer comparer)
            {
                _comparer = comparer;
            }

            /// <summary>
            /// Add a text value and track whether it has been seen before or not.
            /// </summary>
            public void Add(string? text)
            {
                if (_isCompleted)
                {
                    throw new InvalidOperationException();
                }

                if (_set is null)
                {
                    _set = new HashSet<string?>(_comparer);
                }

                if (!_set.Add(text))
                {
                    if (_duplicate is null)
                    {
                        _duplicate = new HashSet<string?>(_comparer);
                    }

                    _duplicate.Add(text);
                }
            }

            /// <summary>
            /// Clear the tracking set to free up space
            /// </summary>
            public void Complete()
            {
                _isCompleted = true;
                _set = null;
            }

            /// <summary>
            /// Checks if a duplicate was detected. Once a duplicate is checked, subsequent calls will result in <c>false</c> so we only raise the error once.
            /// </summary>
            public bool IsDuplicate(string? text)
            {
                if (_duplicate is null)
                {
                    return false;
                }

                return _duplicate.Remove(text);
            }
        }
    }
}
