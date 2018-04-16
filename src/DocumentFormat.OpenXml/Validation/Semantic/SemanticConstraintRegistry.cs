// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
        protected readonly Dictionary<int, List<SemanticConstraint>> _semConstraintMap = new Dictionary<int, List<SemanticConstraint>>();
        protected readonly Dictionary<int, List<SemanticConstraint>> _cleanList = new Dictionary<int, List<SemanticConstraint>>();
        protected readonly Dictionary<int, List<CallBackMethod>> _callBackMethods = new Dictionary<int, List<CallBackMethod>>();

        private readonly FileFormatVersions _format;
        private readonly ApplicationType _appType;

        /// <summary>
        /// Constructor
        /// </summary>
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
                AddConstraintToDic(constraint, ancestorTypeID, _cleanList);
                AddConstraintToDic(constraint, elementTypeID, _semConstraintMap);
            }
        }

        public void AddCallBackMethod(OpenXmlElement element, CallBackMethod method)
        {
            if (!_callBackMethods.Keys.Contains(element.ElementTypeId))
            {
                _callBackMethods.Add(element.ElementTypeId, new List<CallBackMethod>());
            }

            // _callBackMethods[element.ElementTypeId] is a List. Let's check if the method obj is already added to the list.
            if (!_callBackMethods[element.ElementTypeId].Contains(method))
            {
                _callBackMethods[element.ElementTypeId].Add(method);
            }
        }

        private static void AddConstraintToDic(SemanticConstraint constraint, int key, Dictionary<int, List<SemanticConstraint>> dic)
        {
            if (key < 0)
            {
                return;
            }

            List<SemanticConstraint> list;

            if (dic.ContainsKey(key))
            {
                list = dic[key];
            }
            else
            {
                list = new List<SemanticConstraint>();
                dic.Add(key, list);
            }

            // Let's check if the constraint obj is already added to the list.
            if (!list.Contains(constraint))
            {
                list.Add(constraint);
            }
        }

        /// <summary>
        /// Check if specified context meets all registered constraints
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ValidationErrorInfo> CheckConstraints(ValidationContext context)
        {
            SemanticValidationLevel level = SemanticValidationLevel.Element;

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
                foreach (SemanticConstraint constraint in constraints)
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

        public void ActCallBack(int elementId)
        {
            if (_callBackMethods.TryGetValue(elementId, out var callbacks))
            {
                foreach (var method in callbacks)
                {
                    method();
                }
            }
        }

        /// <summary>
        /// Clean state of all registered constraints
        /// </summary>
        public void ClearConstraintState(SemanticValidationLevel level)
        {
            foreach (var constraints in _semConstraintMap.Values)
            {
                foreach (var constraint in constraints)
                {
                    if ((constraint.StateScope & level) != 0)
                    {
                        constraint.ClearState(null);
                    }
                }
            }
        }
    }
}
