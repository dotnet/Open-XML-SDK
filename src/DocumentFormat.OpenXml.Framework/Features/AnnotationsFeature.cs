// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace DocumentFormat.OpenXml.Features
{
    internal class AnnotationsFeature
    {
        // implement annotations mechanism like XObject in LINQ to XML
        // Annotations will not be cloned when calling .Clone() and .CloneNode(bool)
        private object? _annotations;

        public AnnotationsFeature()
        {
        }

        /// <summary>
        /// Adds an object to the annotation list of this collection.
        /// </summary>
        /// <param name="annotation">The annotation to add to this collection.</param>
        public void AddAnnotation(object annotation)
        {
            if (annotation is null)
            {
                throw new ArgumentNullException(nameof(annotation));
            }

            if (_annotations is null)
            {
                _annotations = (annotation is object[]) ? new object[] { annotation } : annotation;
            }
            else
            {
                if (_annotations is not object?[] annotations)
                {
                    _annotations = new object[] { _annotations, annotation };
                }
                else
                {
                    var index = 0;
                    while ((index < annotations.Length) && (annotations[index] is not null))
                    {
                        index++;
                    }

                    if (index == annotations.Length)
                    {
                        Array.Resize(ref annotations, index * 2);
                        _annotations = annotations;
                    }

                    annotations[index] = annotation;
                }
            }
        }

        public T? Annotation<T>()
            where T : class
        {
            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    return _annotations as T;
                }

                for (var i = 0; i < annotations.Length; i++)
                {
                    var obj = annotations[i];

                    if (obj is null)
                    {
                        break;
                    }

                    if (obj is T t)
                    {
                        return t;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Get the first annotation object of the specified type from the current OpenXmlElement element.
        /// </summary>
        /// <param name="type">The type of the annotation to retrieve.</param>
        /// <returns>The first annotation object with the specified type.</returns>
        public object? Annotation(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        return _annotations;
                    }
                }
                else
                {
                    for (var i = 0; i < annotations.Length; i++)
                    {
                        var obj = annotations[i];
                        if (obj is null)
                        {
                            break;
                        }

                        if (type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo()))
                        {
                            return obj;
                        }
                    }
                }
            }

            return null;
        }

        public IEnumerable<T> Annotations<T>()
            where T : class
        {
            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    if (_annotations is T t)
                    {
                        yield return t;
                    }
                }
                else
                {
                    for (var i = 0; i < annotations.Length; i++)
                    {
                        var obj = annotations[i];
                        if (obj is null)
                        {
                            break;
                        }

                        if (obj is T t)
                        {
                            yield return t;
                        }
                    }
                }
            }
        }

        public IEnumerable<object> Annotations(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        yield return _annotations;
                    }
                }
                else
                {
                    for (var i = 0; i < annotations.Length; i++)
                    {
                        var obj = annotations[i];
                        if (obj is null)
                        {
                            break;
                        }

                        if (type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo()))
                        {
                            yield return obj;
                        }
                    }
                }
            }
        }

        public void RemoveAnnotations<T>()
            where T : class
        {
            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    if (_annotations is T)
                    {
                        _annotations = null;
                    }
                }
                else
                {
                    var index = 0;
                    var num = 0;
                    while (index < annotations.Length)
                    {
                        var obj = annotations[index];
                        if (obj is null)
                        {
                            break;
                        }

                        if (!(obj is T))
                        {
                            annotations[num++] = obj;
                        }

                        index++;
                    }

                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        _annotations = null;
                    }
                }
            }
        }

        public void RemoveAnnotations(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            if (_annotations is not null)
            {
                if (_annotations is not object?[] annotations)
                {
                    if (type.GetTypeInfo().IsAssignableFrom(_annotations.GetType().GetTypeInfo()))
                    {
                        _annotations = null;
                    }
                }
                else
                {
                    var index = 0;
                    var num = 0;
                    while (index < annotations.Length)
                    {
                        var o = annotations[index];
                        if (o is null)
                        {
                            break;
                        }

                        if (!type.GetTypeInfo().IsAssignableFrom(o.GetType().GetTypeInfo()))
                        {
                            annotations[num++] = o;
                        }

                        index++;
                    }

                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        _annotations = null;
                    }
                }
            }
        }
    }
}
